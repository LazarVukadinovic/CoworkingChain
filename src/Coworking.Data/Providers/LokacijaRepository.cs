using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class LokacijaRepository : IRepository<Lokacija>
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;
        public LokacijaRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseHelper();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void Add(Lokacija item)
        {
            string upit = $@"
            INSERT INTO lokacija (naziv, adresa, grad, radno_vreme, max_kapacitet, opis)
            VALUES (
                '{item.naziv}',
                '{item.adresa}',
                '{item.grad}',
                '{item.radnoVreme}',
                '{item.maxKapacitet}',
                '{item.opis}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Lokacija> GetAll()
        {
            string upit = "SELECT * FROM lokacija";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapLokacija);
        }

        public void Update(Lokacija item)
        {
            throw new NotImplementedException();
        }
    }
}
