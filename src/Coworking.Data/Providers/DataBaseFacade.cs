using Coworking.Data.Repositories;
using Coworking.Domain.Entities;

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

        // Dodavanje, izmena, prikaz i brisanje CLANOVA
        public void dodajClana(Clan c) => _clanRepo.Add(c);
        public void izmeniClana(Clan c) => _clanRepo.Update(c);
        public List<Clan> prikaziClanove() => _clanRepo.GetAll();
        public void obrisiClana(int clanId) => _clanRepo.delete(clanId);


        // Lista svih clanova, sa mogucnoscu filtriranja po lokaciji, tipu clanstva ili statusu naloga
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)//stavljeno u Clan klasi tipClanstva da bude int, a ne string
        {
            var clanovi = _clanRepo.GetAll();

            if (lokacijaId.HasValue)
                clanovi = _clanRepo.vratiClanovePoLokaciji(lokacijaId.Value);

            if (tipClanstvaId.HasValue)
                clanovi = clanovi.FindAll(c => c.tipClanstva == tipClanstvaId);

            if (!string.IsNullOrEmpty(status))
                clanovi = clanovi.FindAll(c => c.statusNaloga == status);

            return clanovi;
        }
        //Marta:druga dva ifa mogu da se pozivaju da rade preko baze sa upitima preko repozitorijuma


        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------

        // Dodavanje i brisanje co-working LOKACIJA 
        public void dodajLokaciju(Lokacija l) => _lokacijaRepo.Add(l);
        public void obrisiLokaciju(int lokacijaId) => _lokacijaRepo.delete(lokacijaId);


        // Lista svih co-working lokacija sa osnovnim statistikama (ukupan broj radnih mesta, broj trenutno rezervisanih, procenat zauzetosti).
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


        // Prikaz liste svih lokacija, uz mogucnost izbora aktivne lokacije
        public List<Lokacija> prikaziLokacije(bool check) => _lokacijaRepo.GetAllActive(check);


        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------

        // Dodavanje, izmena, otkazivanje i prikaz REZERVACIJA
        public void dodajRezervaciju(Rezervacija r) => _rezRepo.Add(r);
        public void izmeniRezervaciju(Rezervacija r) => _rezRepo.Update(r);
        public void otkaziRezervaciju(int rezervacijaId) => _rezRepo.Cancel(rezervacijaId);
        public List<Rezervacija> prikaziRezervacije() => _rezRepo.GetAll();


        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO


        // Lista svih rezervacija za izabranog korisnika, sa prikazom statusa (aktivna, prosla, otkazana)
        //1. nacin
        public List<Rezervacija> prikaziKorisnickeRezervacije(int clanId) => _rezRepo.GetByClanId(clanId);
        //2. nacin
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


        // Lista rezervacije za odabrani dan i lokaciju radi prikaza zauzetosti u toku dana.
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacijaId) => _rezRepo.GetReservationsByDateAndLocation(datum, lokacijaId);


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------


        // Evidencija radnih mesta po lokaciji: hot desk, dedicated desk, privatna kancelarija,
        // sa informacijom da li je trenutno dostupno ili zauzeto.
        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId) => _resursRepo.prikaziRadnaMestaPoLokaciji(lokacijaId);


        // Evidencija sala za sastanke: naziv, kapacitet, opremljenost (projekat, TV, tabla, oprema za online sastanke...).
        public List<SalaZaSastanke> salaZaSastanke() => _resursRepo.prikaziSaleZaSastanke();


        // Lista svih resursa po lokaciji, razvrstanih po tipu (radna mesta, sala za sastanke)
        public List<Resurs> prikaziResursePoLokaciji(int lokacijaId) => _resursRepo.GetResourcesByLocation(lokacijaId);


        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------

        // Definisanje razlicitih TIPOVA CLANSTVA 
        public void dodajTipClanstva(TipClanstva t) => _tcRepo.Add(t);



        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------


        // Prikaz naziva lanca co-working prostora preuzetog iz konfiguracionog fajla
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
            var admin = _adminRepo.getAdminByUsername(username);
            if (admin == null)
                return false;

            return BCrypt.Net.BCrypt.EnhancedVerify(password, admin.LozinkaHash);
        }

        public void addAdmin(Admin admin)
        {
            admin.LozinkaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(admin.LozinkaHash, 13);
            _adminRepo.addAdmin(admin);
        }
    }
}
