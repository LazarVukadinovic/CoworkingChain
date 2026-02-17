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
        private readonly string konekcioniString;

        public DataBaseAdapter(IDataBaseFactory factory, string konekcioniString)
        {
            _factory = factory;
            this.konekcioniString = konekcioniString;
        }

        public DataTable izvrsiUpit(string upit)
        {
            using (var connStr = _factory.napraviKonekciju(konekcioniString))
            using (var cmn=_factory.napraviKomandu(upit,connStr))
            {
                var DataSet = new DataSet();
                connStr.Open();
                var adapter = _factory.napraviAdapter(cmn);
                adapter.Fill(DataSet);
                return DataSet.Tables[0];
            }
        }

        public void izvrsiUpitBezRezultata(string upit)
        {
            using (var connStr = _factory.napraviKonekciju(konekcioniString))
            using (var cmn = _factory.napraviKomandu(upit, connStr))
            {
                connStr.Open();
                cmn.ExecuteNonQuery();
            }
        }
    }
}
