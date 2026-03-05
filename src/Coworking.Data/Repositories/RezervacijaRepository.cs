using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Data.Repositories
{
    internal class RezervacijaRepository : IRezervacijaRepository
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public RezervacijaRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {

            _adapter = adapter;
            _mapper = mapper;
        }

        public void Add(Rezervacija item)
        {
            string upit = $@"
                INSERT INTO rezervacija (pocetak, kraj, status, kreirano_u, otkazano_u, clan_id, resurs_id)
                VALUES (
                    '{item.pocetak}',
                    '{item.kraj}',
                    '{item.status.ToDbString()}',
                    '{item.kreiranoU}',
                    '{item.otkazanoU}',
                    '{item.clanId}',
                    '{item.resursId}'
                );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Update(Rezervacija item)
        {
            string upit = $@"
                UPDATE rezervacija
                SET pocetak = '{item.pocetak}',
                    kraj = '{item.kraj}',
                    status = '{item.status.ToDbString()}',
                    kreirano_u = '{item.kreiranoU}',
                    otkazano_u = '{item.otkazanoU}',
                    clan_id = '{item.clanId}',
                    resurs_id = '{item.resursId}'
                WHERE rezervacija_id = '{item.rezervacijaId}';";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Cancel(int rezervacijaId)
        {
            string upit = $@"
                UPDATE rezervacija
                SET status = '{ReservationStatus.Otkazana.ToDbString()}'
                WHERE rezervacija_id = {rezervacijaId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Rezervacija> GetAll()
        {
            string upit = "SELECT * FROM rezervacija";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public void UpdateStatus(int rezervacijaId, ReservationStatus status)
        {
            string upit = $@"
                UPDATE rezervacija
                SET status = '{status.ToDbString()}'
                WHERE rezervacija_id = {rezervacijaId};";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Rezervacija> GetByClanId(int clanId)
        {
            string upit = $"SELECT * FROM rezervacija WHERE clan_id={clanId}";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public List<Rezervacija> GetReservationsByDateAndLocation(string date, string location)
        {
            // DATEADD je MSSQL, puca u MySQL
            string upit = $"SELECT rv.*, r.oznaka FROM rezervacija rv JOIN resurs r on rv.resurs_id=r.resurs_id " +
                $"WHERE rv.pocetak >= '{date}' AND rv.kraj < DATEADD(day, 1, '{date}') AND r.lokacija_id={location} AND rv.status != '{ReservationStatus.Otkazana.ToDbString()}'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public void Delete(int id)
        {
            string upit = $"DELETE FROM rezervacija WHERE rezervacija_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Rezervacija GetById(int id)
        {
            var upit = $"SELECT * FROM rezervacija WHERE rezervacija_id = {id}";
            var rezervacije = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
            return rezervacije.Count > 0 ? rezervacije[0] : null;
        }

        public List<Rezervacija> GetByName(string name)
        {
            string upit = $"SELECT rv.*, r.oznaka FROM rezervacija rv JOIN resurs r ON rv.resurs_id = r.resurs_id WHERE r.naziv LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }
    }
}
