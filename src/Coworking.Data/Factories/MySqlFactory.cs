using Coworking.Data.Adapter;
using MySql.Data.MySqlClient;
using System.Data;

namespace Coworking.Data.Factories
{
    public class MySqlFactory : IDataBaseFactory
    {
        public IDbDataAdapter napraviAdapter(IDbCommand komanda)
        {
            return new MySqlDataAdapter((MySqlCommand)komanda);
        }

        public IDbCommand napraviKomandu(string upit, IDbConnection konekcija)
        {
            return new MySqlCommand(upit, (MySqlConnection)konekcija);
        }

        public IDbConnection napraviKonekciju(string konekcioniString)
        {
            return new MySqlConnection(konekcioniString);
        }
        public ISqlSyntaxAdapter createSqlSyntaxAdapter()
            => new MySqlSyntaxAdapter();
    }
}

