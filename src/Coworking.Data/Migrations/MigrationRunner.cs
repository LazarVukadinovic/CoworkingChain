using Coworking.Data.Providers;
using System.Text;

namespace Coworking.Data.Migrations
{
    internal sealed class MigrationRunner
    {
        private readonly DataBaseAdapter _adapter;
        private readonly MigrationHistoryRepository _history;
        private readonly DbProvider _provider;

        public MigrationRunner(DataBaseAdapter adapter, MigrationHistoryRepository history, DbProvider provider)
        {
            _adapter = adapter;
            _history = history;
            _provider = provider;
        }

        public void DajNoveMigracije(string folderPath)
        {
            _history.ObezbediIstorijuMigracija();

            var applied = _history.DajMigrirane();
            var files = MigrationFileProvider.DajMigracioneFajlove(folderPath);

            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                if (name == null || applied.Contains(name)) continue;

                var sql = File.ReadAllText(file);

                foreach (var stmt in SplitSql(sql, _provider))
                {
                    _adapter.izvrsiUpitBezRezultata(stmt);
                }

                _history.OznaciMigraciju(name);
            }
        }

        private static string[] SplitSql(string sql, DbProvider provider)
        {
            if (provider == DbProvider.MsSql)
            {
                // MSSQL: split po GO (batch separator), ignorisi prazne
                return sql
                    .Split(new[] { "\nGO", "\r\nGO" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToArray();
            }
            else
            {
                // MySQL: split po DELIMITER bloku ako postoji, inace obican split po ;
                if (sql.Contains("DELIMITER"))
                {
                    return SplitMySqlWithDelimiter(sql);
                }
                return sql
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToArray();
            }
        }

        private static string[] SplitMySqlWithDelimiter(string sql)
        {
            var rezultat = new List<string>();
            string delimiter = ";";
            var lines = sql.Split('\n');
            var trenutniBlok = new StringBuilder();

            foreach (var line in lines)
            {
                var trimmed = line.Trim();

                // Detektuj DELIMITER promenu npr. "DELIMITER //"
                if (trimmed.StartsWith("DELIMITER", StringComparison.OrdinalIgnoreCase))
                {
                    delimiter = trimmed.Split(' ')[1].Trim();
                    continue;
                }

                trenutniBlok.AppendLine(line);

                // Ako linija završava trenutnim delimiterom — to je kraj izjave
                if (trimmed.EndsWith(delimiter))
                {
                    var stmt = trenutniBlok.ToString().Trim();
                    // Ukloni delimiter sa kraja
                    if (stmt.EndsWith(delimiter))
                        stmt = stmt[..^delimiter.Length].Trim();

                    if (!string.IsNullOrWhiteSpace(stmt))
                        rezultat.Add(stmt);

                    trenutniBlok.Clear();
                }
            }

            return rezultat.ToArray();
        }
    }
}
