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
            INSERT INTO resurs (lokacija_id, oznaka, tip_resursa, opis)
            VALUES (
                '{item.lokacijaId}',
                '{item.oznaka}',
                '{item.tipResursa}',
                '{item.opis}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);

        }

        public List<Resurs> GetAll()
        {
            string upit = "SELECT * FROM resurs";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public List<Resurs> GetResourcesByLocation(int locationId)
        {
            string upit = $@"
            SELECT r.resurs_id, r.lokacija_id, r.oznaka, r.tip_resursa, r.opis,
                   rm.podtip,
                   s.ima_projektor, s.ima_tablu, s.ima_tv, s.ima_online_opremu
            FROM resurs r
            LEFT JOIN radno_mesto_detalj rm ON r.resurs_id = rm.resurs_id
            LEFT JOIN sala_detalj s ON r.resurs_id = s.resurs_id
            WHERE r.lokacija_id = {locationId}";


            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public void Update(Resurs item)
        {
            throw new NotImplementedException();
        }
    }
}
