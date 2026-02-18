using Coworking.Data.Factories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class DataBaseAdapter
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
    }
}
