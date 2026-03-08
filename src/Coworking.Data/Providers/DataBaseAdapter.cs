using Coworking.Data.Adapter;
using Coworking.Data.Factories;
using System.Data;

namespace Coworking.Data.Providers
{
    public class DataBaseAdapter
    {
        private readonly IDataBaseFactory _factory;
        private readonly string _konekcioniString;
        private readonly ISqlSyntaxAdapter _syntax;

        public DataBaseAdapter(IDataBaseFactory factory, string konekcioniString)
        {
            _factory = factory;
            _konekcioniString = konekcioniString;
            _syntax = _factory.createSqlSyntaxAdapter();
        }

        public DataTable izvrsiUpit(string upit)
        {
            using (var connection = _factory.napraviKonekciju(_konekcioniString))
            using (var cmn=_factory.napraviKomandu(upit,connection))
            {
                var dataSet = new DataSet();
                connection.Open();
                var adapter = _factory.napraviAdapter(cmn);
                adapter.Fill(dataSet);

                // u slucaju da nema tabele
                if(dataSet.Tables.Count == 0) return new DataTable();

                return dataSet.Tables[0];
            }
        }

        public void izvrsiUpitBezRezultata(string upit)
        {
            using (var connection = _factory.napraviKonekciju(_konekcioniString))
            using (var cmd = _factory.napraviKomandu(upit, connection))
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string NowExpr()
        {
            return _syntax.NowExpr();
        }

        public string AddDaysExpr(string dateParam, int days)
        {
            return _syntax.AddDaysExpr(dateParam, days);
        }

        public string LimitOneExpr(string orderByColumn, string direction = "DESC")
        {
            return _syntax.LimitOneExpr(orderByColumn, direction);
        }
    }
}
