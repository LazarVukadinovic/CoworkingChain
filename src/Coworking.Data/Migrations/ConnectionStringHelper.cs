using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;

namespace Coworking.Data.Migrations
{
    internal static class ConnectionStringHelper
    {
        public static string DajNazivBaze(DbProvider provider, string targetCs)
        {
            if (provider == DbProvider.MsSql)
            {
                var b = new SqlConnectionStringBuilder(targetCs);
                return b.InitialCatalog;
            }
            else
            {
                var b = new MySqlConnectionStringBuilder(targetCs);
                return b.Database;
            }
        }

        public static string NapraviMasterKonekciju(DbProvider provider, string targetCs)
        {
            if (provider == DbProvider.MsSql)
            {
                // konekcija mssql master
                var b = new SqlConnectionStringBuilder(targetCs)
                {
                    InitialCatalog = "master"
                };
                return b.ConnectionString;
            }
            else
            {
                // konekcija mysql master
                var b = new MySqlConnectionStringBuilder(targetCs)
                {
                    Database = ""
                };
                return b.ConnectionString;
            }
        }
    }
}
