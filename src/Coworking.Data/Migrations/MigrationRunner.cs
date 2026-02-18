using Coworking.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Migrations
{
    internal sealed class MigrationRunner
    {
        private readonly DataBaseAdapter _adapter;
        private readonly MigrationHistoryRepository _history;

        public MigrationRunner(DataBaseAdapter adapter, MigrationHistoryRepository history)
        {
            _adapter = adapter;
            _history = history;
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

                foreach (var stmt in SplitSql(sql))
                {
                    _adapter.izvrsiUpitBezRezultata(stmt);
                }

                _history.OznaciMigraciju(name);
            }
        }

        private static string[] SplitSql(string sql)
        {
            // radi za create table/insert/view
            var parts = sql.Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++) parts[i] = parts[i].Trim();
            return Array.FindAll(parts, p => !string.IsNullOrWhiteSpace(p));
        }
    }
}
