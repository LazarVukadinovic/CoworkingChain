using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class ResursRepository : IRepository<Resurs>
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public ResursRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseHelper();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void Add(Resurs item)
        {
            string upit = $@"
            INSERT INTO resurs (lokacija_id, oznaka, tip_resursa, opis, aktivan)
            VALUES (
                '{item.lokacijaId}',
                '{item.oznaka}',
                '{item.tipResursa}',
                '{item.opis}',
                '{item.aktivan}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);

        }

        public List<Resurs> GetAll()
        {
            string upit = "SELECT * FROM resurs";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public void Update(Resurs item)
        {
            throw new NotImplementedException();
        }
    }
}
