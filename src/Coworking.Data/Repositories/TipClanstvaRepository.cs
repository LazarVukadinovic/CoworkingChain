using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal class TipClanstvaRepository : ITipClanstvaRepository
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public TipClanstvaRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
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

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public TipClanstva GetById(int id)
        {
            string upit = $"SELECT * FROM tip_clanstva WHERE tip_clanstva_id = {id}";
            var tipClanstvaList = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapTipClanstva);
            return tipClanstvaList.FirstOrDefault();

            //var tipClanstva = tipClanstvaList.FirstOrDefault();
            //if (tipClanstva == null) throw new KeyNotFoundException($"Tip clanstva id='{id}' ne postoji");
            //return tipClanstva;
        }

        public List<TipClanstva> GetAll()
        {
            string upit = "SELECT * FROM tip_clanstva";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapTipClanstva);
        }

        public List<TipClanstva> GetByName(string name)
        {
            // Koristimo LIKE '%term%' da pronađemo poklapanje bilo gde u reči
            string upit = $"SELECT * FROM tip_clanstva WHERE naziv LIKE '%{name.Trim()}%'";

            var tabela = _adapter.izvrsiUpit(upit);
            return _mapper.mapDataTable(tabela, _mapper.mapTipClanstva);
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
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int id)
        {
            string upit = $"DELETE FROM tip_clanstva WHERE tip_clanstva_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }
    }
}
