using Coworking.Data.Repositories;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Microsoft.Identity.Client;
using System.Data;
using System.Diagnostics;

namespace Coworking.Data.Providers
{
    public class DataBaseFacade : IDataBase
    {
        private readonly ClanRepository _clanRepo;
        private readonly LokacijaRepository _lokacijaRepo;
        private readonly ResursRepository _resursRepo;
        private readonly RadnoMestoRepository _radnoMestoRepo;
        private readonly SalaZaSastankeRepository _salaRepo;
        private readonly RezervacijaRepository _rezRepo;
        private readonly TipClanstvaRepository _tcRepo;
        private readonly AdminRepository _adminRepo;
        private readonly string _applicationName;

        public event Action<DataEntity> DataChanged;

        public DataBaseFacade(DBSettings settings)
        {
            _clanRepo = new ClanRepository(settings.Adapter, settings.Mapper);
            _lokacijaRepo = new LokacijaRepository(settings.Adapter, settings.Mapper);
            _resursRepo = new ResursRepository(settings.Adapter, settings.Mapper);
            _radnoMestoRepo = new RadnoMestoRepository(settings.Adapter, settings.Mapper);
            _salaRepo = new SalaZaSastankeRepository(settings.Adapter, settings.Mapper);
            _rezRepo = new RezervacijaRepository(settings.Adapter, settings.Mapper);
            _tcRepo = new TipClanstvaRepository(settings.Adapter, settings.Mapper);
            _adminRepo = new AdminRepository(settings.Adapter, settings.Mapper);
            _applicationName = settings.ApplicationName;
        }

        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        public void dodajClana(Clan c) => _clanRepo.Add(c);
        public void izmeniClana(Clan c) => _clanRepo.Update(c);
        public List<Clan> prikaziClanove() => _clanRepo.GetAll();
        public void obrisiClana(int clanId) => _clanRepo.Delete(clanId);


        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            // Uvek kreni od svih, pa sucavaj krug
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

        public List<Clan> vratiClanovePoImenu(string name) => _clanRepo.GetByName(name);

        public int vratiClanovePoLokaciji(int lokacijaId) => _clanRepo.vratiClanovePoLokaciji(lokacijaId).Count();
        //Marta:druga dva ifa mogu da se pozivaju da rade preko baze sa upitima preko repozitorijuma

        public double vratiUkupneSateSalaZaClana(int clanId)
        {
            var podaci = _clanRepo.GetReservationDetailsForMonth(clanId);
            double suma = 0;
            DateTime startMeseca = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime krajMeseca = startMeseca.AddMonths(1);

            foreach (var stavka in podaci)
            {
                // Parsiranje formata "08:00 - 22:00"
                string[] delovi = stavka.RadnoVreme.Split('-');

                // Trim sklanja razmake, Substring(0,2) uzima samo sate
                int otvara = int.Parse(delovi[0].Trim().Substring(0, 2));
                int zatvara = int.Parse(delovi[1].Trim().Substring(0, 2));

                DateTime rezPocetak = Convert.ToDateTime(stavka.PodaciRezervacije.pocetak);
                DateTime rezKraj = Convert.ToDateTime(stavka.PodaciRezervacije.kraj);

                for (DateTime dan = rezPocetak.Date; dan <= rezKraj.Date; dan = dan.AddDays(1))
                {
                    if (dan < startMeseca || dan >= krajMeseca) continue;

                    DateTime lokOtvara = dan.AddHours(otvara);
                    DateTime lokZatvara = dan.AddHours(zatvara);

                    DateTime stvPocetak = rezPocetak > lokOtvara ? rezPocetak : lokOtvara;
                    DateTime stvKraj = rezKraj < lokZatvara ? rezKraj : lokZatvara;

                    if (stvKraj > stvPocetak)
                    {
                        suma += (stvKraj - stvPocetak).TotalHours;
                    }
                }
            }
            return Math.Round(suma, 2);
        }

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

        public List<StatistikaLokacijeDTO> PrikaziStatistikuLokacija() => _lokacijaRepo.GetTrenutnaStatistika();


        public List<Lokacija> prikaziLokacije(bool check) => _lokacijaRepo.GetAllActive(check);
        public Lokacija getLokacijaByResursId(int resursId) => _lokacijaRepo.getLokacijaByResursId(resursId);


        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------

        public void dodajRezervaciju(Rezervacija r) => _rezRepo.Add(r);
        public void izmeniRezervaciju(Rezervacija r) => _rezRepo.Update(r);
        public void otkaziRezervaciju(int rezervacijaId) => _rezRepo.Cancel(rezervacijaId);
        public void obrisiRezervaciju(int rezervacijaId) => _rezRepo.Delete(rezervacijaId);
        public List<Rezervacija> prikaziSveRezervacije()
        {
            var reservation = _rezRepo.GetAll();
            foreach (var r in reservation)
            {
                if (r.status != ReservationStatus.Zavrsena && DateTime.TryParse(r.kraj, out DateTime krajDt) && krajDt < DateTime.Now)
                {
                    _rezRepo.UpdateStatus(r.rezervacijaId, ReservationStatus.Zavrsena);
                    r.status = ReservationStatus.Zavrsena;
                }
            }
            return reservation;
        }

        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId, List<ReservationStatus> filterStatusi)
        {
            return _rezRepo.GetByClanIdAndStatuses(clanId, filterStatusi);
        }

        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, int lokacijaId) => _rezRepo.GetReservationsByDateAndLocation(datum, lokacijaId);


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------

        public List<RadnoMesto> prikaziDostupnaRadnaMestaPoLokaciji(int lokacijaId) => _radnoMestoRepo.prikaziDostupnaRadnaMestaPoLokaciji(lokacijaId);
        public List<RadnoMesto> prikaziDostupnaRadnaMesta() => _radnoMestoRepo.prikaziDostupnaRadnaMesta();
        public RadnoMesto prikaziRadnaMestaPoId(int resurdId) => _radnoMestoRepo.GetById(resurdId);
        public void izmeniRadnoMesto(RadnoMesto r) => _radnoMestoRepo.Update(r);
        public void dodajRadnoMesto(RadnoMesto r) => _radnoMestoRepo.Add(r);


        public SalaZaSastanke prikaziSaleZaSastankePoId(int resurdId) => _salaRepo.GetById(resurdId);
        public void izmeniSaluZaSastanke(SalaZaSastanke s) => _salaRepo.Update(s);
        public void dodajSaluZaSastanke(SalaZaSastanke s) => _salaRepo.Add(s);


        public void izmeniResurs(Resurs r) => _resursRepo.Update(r);
        public void dodajResurs(Resurs r) => _resursRepo.Add(r);
        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int? lokacijaId, string? name) 
        {
            // Uvek kreni od svih, pa su�avaj krug
            var resursi = _resursRepo.GetAll();

            if (lokacijaId.HasValue)
                resursi = resursi.FindAll(r => r.lokacijaId == lokacijaId);

            if (!string.IsNullOrEmpty(name))
                resursi = resursi.FindAll(r => r.tipResursa == name);

            return resursi;
        }
        public List<Resurs> prikaziSveResurse() => _resursRepo.GetAll();
        public void obrisiResurs(int resursId) => _resursRepo.Delete(resursId);
        public Resurs giveLastAddedResource() => _resursRepo.giveLastAddedResource();


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
            return _applicationName;
        }

        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------
        public Admin getAdminByUsername(string username, string password)
        {
            var lista = _adminRepo.GetByName(username);
            if (lista.Count == 0) return null;
            var admin = lista[0];

            if (BCrypt.Net.BCrypt.Verify(password, admin.LozinkaHash))
            {
                return admin;
            }

            return null;
        }

        public void addAdmin(Admin admin)
        {
            admin.LozinkaHash = BCrypt.Net.BCrypt.HashPassword(admin.LozinkaHash, 11);
            _adminRepo.Add(admin);
        }

        public void updateAdmin(Admin admin)
        {
            if (!string.IsNullOrEmpty(admin.LozinkaHash))
            {
                admin.LozinkaHash = BCrypt.Net.BCrypt.HashPassword(admin.LozinkaHash, 11);
            }
            _adminRepo.Update(admin);

        }

        public void updateAdminByUsername(Admin admin, string username)
        {
            _adminRepo.UpdateAdminByUsername(admin, username);
        }
        public void deleteAdmin(int id) => _adminRepo.Delete(id);
    }
}


