using Coworking.Data.Providers;
using System.Data;

namespace Coworking.Data.Migrations
{
    internal sealed class MigrationHistoryRepository
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DbProvider _provider;

        public MigrationHistoryRepository(DataBaseAdapter adapter, DbProvider provider)
        {
            _adapter = adapter;
            _provider = provider;
        }

        public void ObezbediIstorijuMigracija()
        {
            string sql = _provider == DbProvider.MySql
                ? @"CREATE TABLE IF NOT EXISTS schema_migrations (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        filename VARCHAR(255) NOT NULL UNIQUE,
                        applied_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );"
                : @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'schema_migrations')
                    BEGIN
                      CREATE TABLE schema_migrations (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        filename NVARCHAR(255) NOT NULL UNIQUE,
                        applied_at DATETIME2 NOT NULL DEFAULT SYSDATETIME()
                      );
                    END";

            _adapter.izvrsiUpitBezRezultata(sql);
        }

        public HashSet<string> DajMigrirane()
        {
            var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            DataTable dt = _adapter.izvrsiUpit("SELECT filename FROM schema_migrations");
            foreach (DataRow row in dt.Rows)
                set.Add(row["filename"]?.ToString() ?? "");
            return set;
        }

        public void OznaciMigraciju(string filename)
        {
            var safe = filename.Replace("'", "''");
            _adapter.izvrsiUpitBezRezultata($"INSERT INTO schema_migrations (filename) VALUES ('{safe}')");
        }
    }
}
