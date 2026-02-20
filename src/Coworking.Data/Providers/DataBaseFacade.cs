using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Coworking.Data.Providers
{
    public class DataBaseFacade : IDataBase
    {
        private readonly ClanRepository _clanRepo;
        private readonly LokacijaRepository _lokacijaRepo;
        private readonly ResursRepository _resursRepo;
        private readonly RezervacijaRepository _rezRepo;
        private readonly TipClanstvaRepository _tcRepo;

        public DataBaseFacade()
        {
            _clanRepo = new ClanRepository();
            _lokacijaRepo = new LokacijaRepository();
            _resursRepo = new ResursRepository();
            _rezRepo = new RezervacijaRepository();
        }

        // --- Članovi ---
        public void dodajClana(Clan c) => _clanRepo.Add(c);
        public List<Clan> prikaziClanove() => _clanRepo.GetAll();
        public void obrisiClana(int clanId) => _clanRepo.delete(clanId);

        // Filtriranje članova po lokaciji, tipu članstva ili statusu ?
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)//stavljeno u Clan klasi tipClanstva da bude int, a ne string
        {
            var clanovi = _clanRepo.GetAll();

            if (lokacijaId.HasValue)
                clanovi = _clanRepo.vratiClanovePoLokaciji(lokacijaId.Value);

            if (tipClanstvaId.HasValue)
                clanovi = clanovi.FindAll(c => c.tipClanstva == tipClanstvaId);

            if (!string.IsNullOrEmpty(status))
                clanovi = clanovi.FindAll(c => c.statusNaloga == status);

            //druga dva ifa mogu da se pozivaju da rade preko baze sa upitima preko repozitorijuma-marta

            return clanovi;
        }

        // --- Lokacije ---
        public void dodajLokaciju(Lokacija l) => _lokacijaRepo.Add(l);
        public List<Lokacija> prikaziLokacije(bool check) => _lokacijaRepo.GetAllActive(check); // za prikaz aktivne lokacije dodati
        public void obrisiLokaciju(int lokacijaId) => _lokacijaRepo.delete(lokacijaId);

        // Statistika po lokaciji: broj resursa, broj rezervisanih, procenat zauzetosti
        public List<(Lokacija lokacija, int brojResursa, int brojRezervisanih, double procenatZauzetosti)> PrikaziStatistikuLokacija()
        {
            var lokacije = _lokacijaRepo.GetAllActive(false);
            var resursi = _resursRepo.GetAll();
            var rezervacije = _rezRepo.GetAll();

            var rezultat = new List<(Lokacija, int, int, double)>();

            foreach (var l in lokacije)
            {
                var resursiLokacije = resursi.FindAll(r => r.lokacijaId == l.lokacijaId);
                int brojResursa = resursiLokacije.Count;

                int brojRezervisanih = rezervacije.FindAll(r =>
                    resursiLokacije.Exists(res => res.resursId == r.resursId) &&
                    r.status == "Aktivna").Count;

                double procenat = brojResursa == 0 ? 0 : (double)brojRezervisanih / brojResursa * 100;

                rezultat.Add((l, brojResursa, brojRezervisanih, procenat));
            }

            return rezultat;
        }

        // --- Resursi ---
        public void dodajResurs(Resurs r) => _resursRepo.Add(r);
        public List<Resurs> prikaziResurse() => _resursRepo.GetAll();

        public List<Resurs> prikaziResursePoLokaciji(int lokacijaId)
        {
            var resursi = _resursRepo.GetAll();
            return resursi.FindAll(r => r.lokacijaId == lokacijaId);
        }

        // --- Rezervacije ---
        public void dodajRezervaciju(Rezervacija r) => _rezRepo.Add(r);
        public void izmeniRezervaciju(Rezervacija r) => _rezRepo.Update(r);
        public void otkaziRezervaciju(int rezervacijaId) => _rezRepo.Cancel(rezervacijaId);
        public List<Rezervacija> prikaziRezervacije() => _rezRepo.GetAll();
        public List<Rezervacija> prikaziKorisnickeRezervacije(int clanId) => _rezRepo.GetByClanId(clanId);

        // Rezervacije sa statusom (aktivna, prošla, otkazana)
        public List<Rezervacija> prikaziRezervacijeSaStatusomZaClana(int clanId)
        {
            var rezervacije = _rezRepo.GetByClanId(clanId);
            var rezultat = new List<Rezervacija>();

            foreach (var r in rezervacije)
            {
                if (DateTime.Parse(r.kraj) < DateTime.Now)
                    _rezRepo.UpdateStatus(r.rezervacijaId, "Prošla");
                rezultat.Add(r);
            }

            return rezultat;
        }

        // Rezervacije za dan i lokaciju (zauzetost u toku dana)
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacijaId)
        {
            return _rezRepo.GetReservationsByDateAndLocation(datum, lokacijaId);
        }

        public List<Resurs> PrikaziResursePoTipu(int lokacijaId)
        {
            var resursi = _resursRepo.GetResourcesByLocation(lokacijaId);
            return resursi;
        }


        // --- Konfiguracija ---
        public string prikazLanca()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            return File.ReadAllLines(path)[0];
        }


        public void dodajTipClanstva(TipClanstva t)
        {
            _tcRepo.Add(t);
        }

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
             return _resursRepo.prikaziRadnaMestaPoLokaciji(lokacijaId);
        }

        public List<SalaZaSastanke> salaZaSastanke()
        {
            return _resursRepo.prikaziSaleZaSastanke();
        }
    }
}
