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
            string otkazanoUVal = item.otkazanoU == null ? "NULL" : $"'{item.otkazanoU}'";

            string upit = $@"
            INSERT INTO rezervacija (pocetak, kraj, status, kreirano_u, otkazano_u, clan_id, resurs_id)
            VALUES (
                '{item.pocetak}',
                '{item.kraj}',
                '{item.status.ToDbString()}',
                '{item.kreiranoU}',
                {otkazanoUVal},
                {item.clanId},
                {item.resursId}
            );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Update(Rezervacija item)
        {
            string otkazanoUVal = item.otkazanoU == null ? "NULL" : $"'{item.otkazanoU}'";

            string upit = $@"
            UPDATE rezervacija
            SET pocetak = '{item.pocetak}',
                kraj = '{item.kraj}',
                status = '{item.status.ToDbString()}',
                kreirano_u = '{item.kreiranoU}',
                otkazano_u = {otkazanoUVal},
                clan_id = {item.clanId},
                resurs_id = {item.resursId}
            WHERE rezervacija_id = {item.rezervacijaId};";

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

        public List<Rezervacija> GetByClanIdAndStatuses(int clanId, List<ReservationStatus> statusi)
        {
            string upit = $@"SELECT rv.*, r.oznaka 
                     FROM rezervacija rv 
                     JOIN resurs r ON rv.resurs_id = r.resurs_id 
                     WHERE rv.clan_id = {clanId}";

            if (statusi != null && statusi.Count > 0)
            {
                string statusiString = string.Join(",", statusi.Select(s => $"'{s.ToDbString()}'"));
                upit += $" AND rv.status IN ({statusiString})";
            }

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public List<Rezervacija> GetReservationsByDateAndLocation(string date, int location)
        {
            // Pretpostavljam da AddDaysExpr vraća nešto tipa: DATE_ADD('2025-02-16', INTERVAL 1 DAY)
            string nextDay = _adapter.AddDaysExpr($"'{date}'", 1);

            // UKLONJENI NAVODNICI oko {nextDay}
            string upit = $"SELECT rv.*, r.oznaka FROM rezervacija rv JOIN resurs r on rv.resurs_id=r.resurs_id " +
                          $"WHERE rv.pocetak >= '{date}' AND rv.kraj < {nextDay} " +
                          $"AND r.lokacija_id={location} AND rv.status != '{ReservationStatus.Otkazana.ToDbString()}'";

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
            string upit = $@"SELECT rv.*, r.oznaka FROM rezervacija rv 
                    JOIN resurs r ON rv.resurs_id = r.resurs_id 
                    WHERE r.oznaka LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public List<SatiSaleInfo> vratiSatiSaleZaClana(int clanId)
        {
            string now = _adapter.NowExpr();
            string upit = $@"
            SELECT rv.pocetak, rv.kraj, l.radno_vreme
            FROM rezervacija rv
            JOIN resurs r ON rv.resurs_id = r.resurs_id
            JOIN lokacija l ON r.lokacija_id = l.lokacija_id
            WHERE rv.clan_id = {clanId}
              AND r.tip_resursa = 'sala'
              AND rv.status IN ('Rezervisana', 'Potvrdjena', 'Zavrsena')
              AND MONTH(rv.pocetak) = MONTH({now})
              AND YEAR(rv.pocetak)  = YEAR({now})";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), red => new SatiSaleInfo
            {
                pocetak = red["pocetak"].ToString(),
                kraj = red["kraj"].ToString(),
                radnoVreme = red["radno_vreme"].ToString()
            });
        }
    }
}
