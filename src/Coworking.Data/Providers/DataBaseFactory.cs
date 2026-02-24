using Coworking.Data.Factories;

namespace Coworking.Data.Providers
{
    internal class DataBaseFactory
    {
        public IDataBaseFactory? vratiFactory(string konekcioniString)
        {
            konekcioniString = konekcioniString.ToLower();

            if (konekcioniString.Contains("localhost"))
                return new MySqlFactory();

            else if (konekcioniString.Contains("mssqllocaldb"))
                return new MsSqlFactory();

            else return null;
        }
    }
}
