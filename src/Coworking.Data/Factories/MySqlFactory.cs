using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Factories
{
    internal class MySqlFactory : IDataBaseFactory
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
    }
}
