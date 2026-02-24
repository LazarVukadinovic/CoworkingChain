using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    '{item.status}',
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
                    status = '{item.status}',
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
                SET status = 'Otkazana'
                WHERE rezervacija_id = {rezervacijaId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Rezervacija> GetAll()
        {
            string upit = "SELECT * FROM rezervacija";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }

        public void UpdateStatus(int rezervacijaId, string status)
        {
            string upit = $@"
                UPDATE rezervacija
                SET status = '{status}'
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
            string upit = $"SELECT rv.*,r.naziv FROM rezervacija rv JOIN resurs r on rv.resurs_id=r.resurs_id " +
                $"WHERE rv.pocetak >= '{date}' AND rv.kraj < DATEADD(day, 1, '{date}') AND r.lokacija_id={location} AND rv.status != 'Otkazana'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRezervacija);
        }
    }
}
