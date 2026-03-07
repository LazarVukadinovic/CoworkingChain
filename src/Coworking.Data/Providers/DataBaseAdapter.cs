using Coworking.Data.Factories;
using System.Data;

namespace Coworking.Data.Providers
{
    public class DataBaseAdapter
    {
        private readonly IDataBaseFactory _factory;
        private readonly string _konekcioniString;

        public DataBaseAdapter(IDataBaseFactory factory, string konekcioniString)
        {
            _factory = factory;
            _konekcioniString = konekcioniString;
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
            return _factory is MySqlFactory ? "NOW()" : "SYSDATETIME()";
        }

        public string AddDaysExpr(string dateParam, int days)
        {
            return _factory is MySqlFactory
                ? $"DATE_ADD({dateParam}, INTERVAL {days} DAY)"
                : $"DATEADD(day, {days}, {dateParam})";
        }

        public string DateDiffMinutesExpr(string startExpr, string endExpr)
        {
            return _factory is MySqlFactory
                ? $"TIMESTAMPDIFF(MINUTE, {startExpr}, {endExpr})"
                : $"DATEDIFF(minute, {startExpr}, {endExpr})";
        }

        public string LimitOneExpr(string orderByColumn, string direction = "DESC")
        {
            return _factory is MySqlFactory
                ? $"ORDER BY {orderByColumn} {direction} LIMIT 1"
                : $"ORDER BY {orderByColumn} {direction} OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
        }

        public object izvrsiUpitSkalar(string upit)
        {
            // Koristimo tvoju fabriku da dobijemo odgovarajuću konekciju i komandu
            using (var connection = _factory.napraviKonekciju(_konekcioniString))
            using (var command = _factory.napraviKomandu(upit, connection))
            {
                connection.Open();
                // ExecuteScalar vraća prvi stubac prvog reda (idealno za SUM)
                return command.ExecuteScalar();
            }
        }
    }
}
