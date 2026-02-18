using Coworking.Data.Factories;
using Coworking.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Migrations
{
    public static class MigrationBootstrapper
    {
        public static void EnsureDbAndMigrate(string targetConnectionString, string migrationsBasePath)
        {
            DatabaseInitializer.ObezbediPostojanjeBaze(targetConnectionString);
            var provider = DbProviderDetector.Proveri(targetConnectionString);

            IDataBaseFactory factory = provider == DbProvider.MySql ? new MySqlFactory() : new MsSqlFactory();
            var adapter = new DataBaseAdapter(factory, targetConnectionString);

            TryPing(adapter);

            string providerFolder = provider == DbProvider.MySql ? "mysql" : "mssql";
            string migrationsPath = System.IO.Path.Combine(migrationsBasePath, providerFolder);

            var history = new MigrationHistoryRepository(adapter, provider);
            var runner = new MigrationRunner(adapter, history);
            runner.DajNoveMigracije(migrationsPath);
        }

        private static void TryPing(DataBaseAdapter db)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    db.izvrsiUpit("SELECT 1");
                    return;
                }
                catch
                {
                    System.Threading.Thread.Sleep(250);
                }
            }
            db.izvrsiUpit("SELECT 1");
        }
    }
}
