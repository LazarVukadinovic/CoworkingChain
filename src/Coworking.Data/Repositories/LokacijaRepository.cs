using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

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

        

        public List<Lokacija> GetAllActive(bool check)
        {
            string upit = "SELECT DISTINCT l.* FROM lokacija l";
            if(check)
            {
                upit += $@" JOIN resurs r on r.lokacija_id=l.lokacija_id 
                            JOIN rezervacija rv on rv.resurs_id=r.resurs_id 
                            WHERE rv.status='{ReservationStatus.Rezervisana.ToDbString()}' OR 
                                    rv.status='{ReservationStatus.Potvrdjena.ToDbString()}'";
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

        public void Delete(int id)
        {
            string upit = $"DELETE FROM lokacija WHERE lokacija_id = {id};";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Lokacija GetById(int id)
        {
            string upit = $"SELECT * FROM lokacija WHERE lokacija_id = {id};";
            var lokacije = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
            return lokacije.FirstOrDefault();
        }

        public List<Lokacija> GetByName(string name)
        {
            string upit = $"SELECT * FROM lokacija WHERE naziv LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);

        }
    }
}
