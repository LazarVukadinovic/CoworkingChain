using Coworking.Data.Repositories;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace Coworking.Data.Providers
{
    public class DataBaseFacade : IDataBase
    {
        private readonly ClanRepository _clanRepo;
        private readonly LokacijaRepository _lokacijaRepo;
        private readonly ResursRepository _resursRepo;
        private readonly RezervacijaRepository _rezRepo;
        private readonly TipClanstvaRepository _tcRepo;
        private readonly AdminRepository _adminRepo;

        public DataBaseFacade(DBSettings settings)
        {
            _clanRepo = new ClanRepository(settings.Adapter, settings.Mapper);
            _lokacijaRepo = new LokacijaRepository(settings.Adapter, settings.Mapper);
            _resursRepo = new ResursRepository(settings.Adapter, settings.Mapper);
            _rezRepo = new RezervacijaRepository(settings.Adapter, settings.Mapper);
            _tcRepo = new TipClanstvaRepository(settings.Adapter, settings.Mapper);
            _adminRepo = new AdminRepository(settings.Adapter, settings.Mapper);
        }

        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        public void dodajClana(Clan c) => _clanRepo.Add(c);
        public void izmeniClana(Clan c) => _clanRepo.Update(c);
        public List<Clan> prikaziClanove() => _clanRepo.GetAll();
        public void obrisiClana(int clanId) => _clanRepo.delete(clanId);


        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            // Uvek kreni od svih, pa sužavaj krug
            var clanovi = _clanRepo.GetAll();

            if (lokacijaId.HasValue)
            {
                var poLokaciji = _clanRepo.vratiClanovePoLokaciji((int)lokacijaId);
                clanovi = clanovi.FindAll(c => poLokaciji.Any(pl => pl.clanId == c.clanId));
            }

            if (tipClanstvaId.HasValue)
                clanovi = clanovi.FindAll(c => c.tipClanstva == tipClanstvaId);

            if (!string.IsNullOrEmpty(status))
                clanovi = clanovi.FindAll(c => c.statusNaloga == status);

            return clanovi;
        }

        public int vratiClanovePoLokaciji(int lokacijaId) => _clanRepo.vratiClanovePoLokaciji(lokacijaId).Count();
        //Marta:druga dva ifa mogu da se pozivaju da rade preko baze sa upitima preko repozitorijuma


        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------

        public void dodajLokaciju(Lokacija l) => _lokacijaRepo.Add(l);
        public void izmeniLokaciju(Lokacija l) => _lokacijaRepo.Update(l);
        public void obrisiLokaciju(int lokacijaId) => _lokacijaRepo.Delete(lokacijaId);

        public List<Lokacija> GetLokacijaByName(string naziv) => _lokacijaRepo.GetByName(naziv);

        public Lokacija GetLokacijaById(int id)
        {
            return _lokacijaRepo.GetById(id);
        }

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
                    r.status == ReservationStatus.Rezervisana ||
                    r.status == ReservationStatus.Potvrdjena).Count;

                double procenat = brojResursa == 0 ? 0 : (double)brojRezervisanih / brojResursa * 100;

                rezultat.Add((l, brojResursa, brojRezervisanih, procenat));
            }

            return rezultat;
        }


        public List<Lokacija> prikaziLokacije(bool check) => _lokacijaRepo.GetAllActive(check);


        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------

        public void dodajRezervaciju(Rezervacija r) => _rezRepo.Add(r);
        public void izmeniRezervaciju(Rezervacija r) => _rezRepo.Update(r);
        public void otkaziRezervaciju(int rezervacijaId) => _rezRepo.Cancel(rezervacijaId);
        public List<Rezervacija> prikaziSveRezervacije() => _rezRepo.GetAll();


        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO


        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId)
        {
            var rezervacije = _rezRepo.GetByClanId(clanId);

            foreach (var r in rezervacije)
                if (DateTime.Parse(r.kraj) < DateTime.Now)
                {
                    _rezRepo.UpdateStatus(r.rezervacijaId, ReservationStatus.Zavrsena);
                    r.status = ReservationStatus.Zavrsena;
                }

            return rezervacije;
        }


        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacijaId) => _rezRepo.GetReservationsByDateAndLocation(datum, lokacijaId);


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId) => _resursRepo.prikaziRadnaMestaPoLokaciji(lokacijaId);

        public List<SalaZaSastanke> prikaziSaleZaSastankePoId(int resurdId) => _resursRepo.prikaziSaleZaSastankePoId(resurdId);
        public List<RadnoMesto> prikaziRadnaMestaPoId(int resurdId) => _resursRepo.prikaziRadnaMestaPoId(resurdId);

        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int? lokacijaId, string? name) 
        {
            // Uvek kreni od svih, pa sužavaj krug
            var resursi = _resursRepo.GetAll();

            if (lokacijaId.HasValue)
                resursi = resursi.FindAll(r => r.lokacijaId == lokacijaId);

            if (!string.IsNullOrEmpty(name))
                resursi = resursi.FindAll(r => r.tipResursa == name);

            return resursi;
        }
        public List<Resurs> prikaziSveResurse() => _resursRepo.GetAll();


        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------

        public void dodajTipClanstva(TipClanstva t) => _tcRepo.Add(t);
        public List<TipClanstva> prikaziSveTipoveClanstva() => _tcRepo.GetAll();

        public void updateTipClanstva(TipClanstva t) => _tcRepo.Update(t);

        public List<TipClanstva> GetTipClanstvaByName(string naziv) => _tcRepo.GetByName(naziv);


        public TipClanstva GetTipClanstvaById(int id)
        {
            return _tcRepo.GetById(id);
        }


        public void DeleteTipClanstva(int id)
        {
            _tcRepo.Delete(id);
        }

        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------

        public string prikazLanca()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            return File.ReadAllLines(path)[0];
        }

        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------
        public bool getAdminByUsername(string username, string password)
        {
            // tokom radne faze projekta return true, za gotov projekat se brise return true
            return true;
            var admin = _adminRepo.getAdminByUsername(username);
            if (admin == null)
                return false;

            
            return BCrypt.Net.BCrypt.Verify(password, admin.LozinkaHash);
        }

        public void addAdmin(Admin admin)
        {
            admin.LozinkaHash = BCrypt.Net.BCrypt.HashPassword(admin.LozinkaHash, 11);
            _adminRepo.addAdmin(admin);
        }


    }
}
