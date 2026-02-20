using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coworking.Data.Providers
{
    internal class RezervacijaRepository : IRezervacijaRepository
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public RezervacijaRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseFactory();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
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

            adapter.izvrsiUpitBezRezultata(upit);
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

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Cancel(int rezervacijaId)
        {
            string upit = $@"
                UPDATE rezervacija
                SET status = 'Otkazana'
                WHERE rezervacija_id = {rezervacijaId};";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Rezervacija> GetAll()
        {
            string upit = "SELECT * FROM rezervacija";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRezervacija);
        }

        public void UpdateStatus(int rezervacijaId, string status)
        {
            string upit = $@"
                UPDATE rezervacija
                SET status = '{status}'
                WHERE rezervacija_id = {rezervacijaId};";
            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Rezervacija> GetByClanId(int clanId)
        {
            string upit = $"SELECT * FROM rezervacija WHERE clan_id={clanId}";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRezervacija);
        }

        public List<Rezervacija> GetReservationsByDateAndLocation(string date, string location)
        {
            string upit = $"SELECT rv.*,r.naziv FROM rezervacija rv JOIN resurs r on rv.resurs_id=r.resurs_id " +
                $"WHERE rv.pocetak >= '{date}' AND rv.kraj < DATEADD(day, 1, '{date}') AND r.lokacija_id={location} AND rv.status != 'Otkazana'";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRezervacija);
        }
    }
}
