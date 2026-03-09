using Coworking.Data.Adapter;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Coworking.Data.Factories
{
    public class MsSqlFactory : IDataBaseFactory
    {
        public IDbDataAdapter napraviAdapter(IDbCommand komanda)
        {
            return new SqlDataAdapter((SqlCommand)komanda);
        }

        public IDbCommand napraviKomandu(string upit, IDbConnection konekcija)
        {
            return new SqlCommand(upit,(SqlConnection)konekcija);
        }

        public IDbConnection napraviKonekciju(string konekcioniString)
        {
            return new SqlConnection(konekcioniString);
        }
        public ISqlSyntaxAdapter createSqlSyntaxAdapter()
            => new MsSqlSyntaxAdapter();
    }
}

