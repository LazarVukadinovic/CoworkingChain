
namespace Coworking.Data.Migrations
{
    internal enum DbProvider
    {
        MySql,
        MsSql
    }

    internal static class DbProviderDetector
    {
        public static DbProvider Proveri(string connectionString)
        {
            var cs = connectionString ?? "";

            if (cs.Contains("localhost", StringComparison.OrdinalIgnoreCase))
                return DbProvider.MySql;

            if (cs.Contains("MSSQLLocalDB", StringComparison.OrdinalIgnoreCase))
                return DbProvider.MsSql;

            throw new InvalidOperationException("Ne mogu da odredim bazu iz connection string-a.");
        }
    }
}
