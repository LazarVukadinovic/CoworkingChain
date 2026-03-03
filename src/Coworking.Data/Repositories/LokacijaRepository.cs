using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal class LokacijaRepository : IRepository<Lokacija>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;
        public LokacijaRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
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

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void delete(int lokacijaId)
        {
            string upit = $@"
            DELETE FROM lokacija
            WHERE lokacija_id={lokacijaId};
            ";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Lokacija> GetAllActive(bool check)
        {
            string upit = "SELECT DISTINCT l.* FROM lokacija l";
            if(check)
            {
                upit += $" JOIN resurs r on r.lokacija_id=l.lokacija_id JOIN rezervacija rv on rv.resurs_id=r.resurs_id WHERE rv.status='Rezervisana'";
            }
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
        }

        public List<Lokacija> GetAll()
        {
            string upit = "SELECT * FROM lokacija";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
        }

        public void Update(Lokacija item)
        {
            string upit = $@"
            UPDATE lokacija
            SET 
                naziv = '{item.naziv}',
                adresa = '{item.adresa}',
                grad = '{item.grad}',
                radno_vreme = '{item.radnoVreme}',
                max_kapacitet = '{item.maxKapacitet}',
                opis = '{item.opis}'
            WHERE lokacija_id = {item.lokacijaId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

    }
}
