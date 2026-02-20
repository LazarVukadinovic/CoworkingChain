using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class TipClanstvaRepository : IRepository<TipClanstva>
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public TipClanstvaRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseFactory();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void Add(TipClanstva item)
        {
            string upit = $@"
            INSERT INTO tip_clanstva (naziv, cena, trajanje_dana, max_sati_mesecno, dozvoljena_sala, sati_sale_mesecno)
            VALUES (
                '{item.naziv}',
                '{item.cena}',
                '{item.trajanjeDana}',
                '{item.maxSatiRezervacijeMesecno}',
                '{item.dozvoljenaSala}',
                '{item.satiSaleMesecno}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<TipClanstva> GetAll()
        {
            string upit = "SELECT * FROM tip_clanstva";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapTipClanstva);
        }

        public void Update(TipClanstva item)
        {
            string upit = $@"
            UPDATE tip_clanstva
            SET 
                naziv = '{item.naziv}',
                cena = '{item.cena}',
                trajanje_dana = '{item.trajanjeDana}',
                max_sati_mesecno = '{item.maxSatiRezervacijeMesecno}',
                dozvoljena_sala = '{item.dozvoljenaSala}',
                sati_sale_mesecno = '{item.satiSaleMesecno}'
            WHERE tip_clanstva_id = {item.tipClanstvaId};";
            adapter.izvrsiUpitBezRezultata(upit);
        }
    }
}
