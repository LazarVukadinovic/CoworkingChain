using Coworking.Data.Factories;
using Coworking.Data.Providers;

namespace Coworking.Data.Migrations
{
    internal static class DatabaseInitializer
    {
        public static void ObezbediPostojanjeBaze(string targetConnectionString)
        {
            var provider = DbProviderDetector.Proveri(targetConnectionString);

            string dbName = ConnectionStringHelper.DajNazivBaze(provider, targetConnectionString);
            string serverCs = ConnectionStringHelper.NapraviMasterKonekciju(provider, targetConnectionString);

            IDataBaseFactory factory = provider == DbProvider.MySql ? new MySqlFactory() : new MsSqlFactory();

            var serverDb = new DataBaseAdapter(factory, serverCs);

            if (provider == DbProvider.MsSql)
            {
                // sys.databases proverava postojanje baze
                string safe = dbName.Replace("'", "''");
                var dt = serverDb.izvrsiUpit($"SELECT COUNT(*) AS Cnt FROM sys.databases WHERE name = '{safe}'");
                int cnt = Convert.ToInt32(dt.Rows[0]["Cnt"]);

                if (cnt == 0)
                {
                    serverDb.izvrsiUpitBezRezultata($"CREATE DATABASE [{dbName}]");
                }
            }
            else
            {
                // MySQL: radi i ako već postoji
                serverDb.izvrsiUpitBezRezultata(
                    $"CREATE DATABASE IF NOT EXISTS `{dbName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"
                );
            }
        }
    }
}
