using Coworking.Data.Reports;
using Coworking.Data.Repositories;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Microsoft.Extensions.Logging.Abstractions;
using System.Security.Claims;
using System.Timers;

namespace Coworking.Data.Providers
{
    public class DataBaseProxy : IDataBase //promenio sa internal na public
    {
        private IDataBase _facade;

        bool check2=false;
        List<Clan>? cachedClanovi = null;
        List<Lokacija>? cachedLokacija = null;
        List<Rezervacija>? cachedRezervacije = null;
        List<Resurs> cachedResursi = null;
        List<TipClanstva>? cachedTipClanstva = null;

       /* List<Clan>? cachedClanoviFiltrirano = null;

        List<(Lokacija lokacija, int brojResursa, int brojRezervisanih, double procenatZauzetosti)>? cachedLokacijaStatistika = null;

        private Dictionary<int, List<Rezervacija>> cachedRezervacijeSaStatusomZaIzabranogClana = new Dictionary<int, List<Rezervacija>>();
        private Dictionary<(string datum, int lokacija), List<Rezervacija>> cachedRezervacijeZaDanILokaciju = new Dictionary<(string, int), List<Rezervacija>>();

        private Dictionary<int, List<RadnoMesto>> cachedRadnaMestaPoLokaciji = new Dictionary<int, List<RadnoMesto>>();
        SalaZaSastanke? cachedSalaZaSastanke = null;
        List<RadnoMesto> cachedRadnaMesta = null;
        private Dictionary<int, List<Resurs>> cachedResursiPoLokacijiIPoTipu = new Dictionary<int, List<Resurs>>();


        !!!!ovo se sve vrlo verovatno ne koristi i nema potrebe da se koristi
        */



        bool clanReset = true;
        bool lokacijaReset = true;
        bool resursReset = true;
        bool rezervacijaReset = true;
        bool tipClanstvaReset = true;

        System.Timers.Timer _timer;

        public event Action<DataEntity> DataChanged;

        DateTime lastCheck = DateTime.MinValue;

        public DataBaseProxy(IDataBase facade) 
        {
            _facade = facade;
            _timer = new System.Timers.Timer(5000); // 5 sekundi
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            _timer.Start();

            _timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            CheckExternalChanges();
        }

        public void CheckExternalChanges()
        {
            var changes = _facade.GetChangesAfter(lastCheck);

            foreach (var change in changes)
            {
                var entity = Enum.Parse<DataEntity>(change.EntityName);

                InvalidateCache(entity);

                Notify(entity);
            }

            lastCheck = DateTime.Now;
        }

        private void InvalidateCache(DataEntity entity)
        {
            switch (entity)
            {
                case DataEntity.Clan:
                    clanReset = true;
                    break;

                case DataEntity.Resurs:
                    resursReset = true;
                    break;

                case DataEntity.Lokacija:
                    lokacijaReset = true;
                    break;

                case DataEntity.Rezervacija:
                    rezervacijaReset = true;
                    break;
                case DataEntity.TipClanstva:
                    tipClanstvaReset = true;
                    break;
            }
        }

        private void Notify(DataEntity entity) => DataChanged?.Invoke(entity);

        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------

        public void dodajClana(Clan c)
        {
            _facade.dodajClana(c);
            clanReset = true;
            Notify(DataEntity.Clan);
        }
        public void izmeniClana(Clan c)
        {
            _facade.izmeniClana(c);
            clanReset = true;
            Notify(DataEntity.Clan);
        }
        public List<Clan> prikaziClanove()
        {
            if (cachedClanovi == null || clanReset == true)
            {
                cachedClanovi = _facade.prikaziClanove();
                clanReset = false;
            }
            return cachedClanovi;
        }
        public void obrisiClana(int clanId)
        {
            _facade.obrisiClana(clanId);

            //if (cachedClanovi != null)
            //    cachedClanovi.RemoveAll(c => c.clanId == clanId);

            //if (cachedKorisnickeRezervacije.ContainsKey(clanId))
            //    cachedKorisnickeRezervacije.Remove(clanId);

            //Ovo:briše clana iz cachedClanovi, briše njegove rezervacije iz cachedKorisnickeRezervacije i dalje forsira reload
            //sledeci put

            clanReset = true;
            Notify(DataEntity.Clan);
        }

        //ovde mozda treba dictionary
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
                return _facade.PrikaziClanoveFiltrirano(lokacijaId,tipClanstvaId,status);
        }

        public List<StatistikaLokacijeDTO> PrikaziStatistikuLokacija() => _facade.PrikaziStatistikuLokacija();   

        public List<Clan> vratiClanovePoImenu(string name) => _facade.vratiClanovePoImenu(name);

        public int vratiClanovePoLokaciji(int lokacijaId) => _facade.vratiClanovePoLokaciji(lokacijaId);

        public double vratiUkupneSateSalaZaClana(int clanId)
        {
            return _facade.vratiUkupneSateSalaZaClana(clanId);
        }

        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        public void dodajLokaciju(Lokacija l)
        {
            _facade.dodajLokaciju(l);
            lokacijaReset = true;
            Notify(DataEntity.Lokacija);
        }
        public void izmeniLokaciju(Lokacija l)
        {
            _facade.izmeniLokaciju(l);
            lokacijaReset = true;
            Notify(DataEntity.Lokacija);
        }
        public void obrisiLokaciju(int lokacijaId)
        {
            _facade.obrisiLokaciju(lokacijaId);
            lokacijaReset = true;
            Notify(DataEntity.Lokacija);
        }

        public List<Lokacija> prikaziLokacije(bool check)
        {
            if (check2 != check)
            {
                check2 = check;
                lokacijaReset = true;
            }
            if (cachedLokacija == null || lokacijaReset)
            {
                cachedLokacija = _facade.prikaziLokacije(check);
                lokacijaReset = false;
            }

            return cachedLokacija;
        }

        public List<Lokacija> GetLokacijaByName(string naziv) => _facade.GetLokacijaByName(naziv);

        public Lokacija GetLokacijaById(int id)
        {
            return _facade.GetLokacijaById(id);
        }

        public Lokacija getLokacijaByResursId(int resursId) => _facade.getLokacijaByResursId(resursId);

        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        public void dodajRezervaciju(Rezervacija r)
        {
            _facade.dodajRezervaciju(r);
            rezervacijaReset = true;
            Notify(DataEntity.Rezervacija);
        }
        public void izmeniRezervaciju(Rezervacija r)
        {
            _facade.izmeniRezervaciju(r);
            rezervacijaReset = true;
            Notify(DataEntity.Rezervacija);
        }
        public void otkaziRezervaciju(int rezervacijaId)
        {
            _facade.otkaziRezervaciju(rezervacijaId);
            rezervacijaReset = true;
            Notify(DataEntity.Rezervacija);
        }
        public void obrisiRezervaciju(int rezervacijaId)
        {
            _facade.obrisiRezervaciju(rezervacijaId);
            rezervacijaReset = true;
            Notify(DataEntity.Rezervacija);
        }
        public List<Rezervacija> prikaziSveRezervacije()
        {
            if (cachedRezervacije == null || rezervacijaReset == true)
            {
                cachedRezervacije = _facade.prikaziSveRezervacije();
                rezervacijaReset = false;
            }
            return cachedRezervacije;
        }

        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO
        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId, List<ReservationStatus> filterStatusi) => _facade.prikaziRezervacijeSaStatusomZaIzabranogClana(clanId, filterStatusi);
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, int lokacija)
        {
            return _facade.prikaziRezervacijeZaDanILokaciju(datum, lokacija);
        }


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------

        public List<RadnoMesto> prikaziDostupnaRadnaMestaPoLokaciji(int lokacijaId)
        {
            return _facade.prikaziDostupnaRadnaMestaPoLokaciji(lokacijaId);
        }

        public List<RadnoMesto> prikaziDostupnaRadnaMesta()
        {
            return _facade.prikaziDostupnaRadnaMesta();
        }
        public SalaZaSastanke prikaziSaleZaSastankePoId(int resursId)
        {
            
            return _facade.prikaziSaleZaSastankePoId(resursId);
        }
        public RadnoMesto prikaziRadnaMestaPoId(int resursId)
        {
            return _facade.prikaziRadnaMestaPoId(resursId);
        }
        public void izmeniRadnoMesto(RadnoMesto r)
        {
            _facade.izmeniRadnoMesto(r);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }
        public void dodajRadnoMesto(RadnoMesto r)
        {
            _facade.dodajRadnoMesto(r);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }
        public void izmeniSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.izmeniSaluZaSastanke(s);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }
        public void dodajSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.dodajSaluZaSastanke(s);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }
        public void dodajResurs(Resurs r)
        {
            _facade.dodajResurs(r);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }

        public void izmeniResurs(Resurs r)
        {
            _facade.izmeniResurs(r);
            resursReset = true;
            Notify(DataEntity.Resurs);
        }
        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int? lokacijaId, string name)
        {
            //if (cachedResursiPoLokacijiIPoTipu.ContainsKey(lokacijaId) == false || needReset == true)
            //{
                //cachedResursiPoLokacijiIPoTipu[lokacijaId] = _facade.prikaziResursePoLokacijiIPoTipu(lokacijaId);
                //needReset = false;
            //}
            return _facade.prikaziResursePoLokacijiIPoTipu(lokacijaId, name);
        }
        public List<Resurs> prikaziSveResurse()
        {
            if (cachedResursi == null || resursReset == true)
            {
                cachedResursi = _facade.prikaziSveResurse();
                resursReset = false;
            }
            return cachedResursi;
        }
        public void obrisiResurs(int resursId)
        {
            _facade.obrisiResurs(resursId);
            resursReset = true;
        }
        public Resurs giveLastAddedResource() => _facade.giveLastAddedResource();

        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------

        public void dodajTipClanstva(Domain.Entities.TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
            tipClanstvaReset = true;
            Notify(DataEntity.TipClanstva);
        }
        public List<TipClanstva> prikaziSveTipoveClanstva()
        {
            if (cachedTipClanstva == null || tipClanstvaReset == true)
            {
                cachedTipClanstva = _facade.prikaziSveTipoveClanstva();
                tipClanstvaReset = false;
            }
            return cachedTipClanstva;
        }

        public List<TipClanstva> GetTipClanstvaByName(string naziv)
        {
            return _facade.GetTipClanstvaByName(naziv);
        }

        public void updateTipClanstva(TipClanstva t)
        {
            _facade.updateTipClanstva(t);
            tipClanstvaReset = true;
            Notify(DataEntity.TipClanstva);
        }

        public TipClanstva GetTipClanstvaById(int id)
        {
            return _facade.GetTipClanstvaById(id);
        }

        public void DeleteTipClanstva(int id)
        {
            _facade.DeleteTipClanstva(id);
            tipClanstvaReset = true;
            Notify(DataEntity.TipClanstva);
        }


        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------
        //-------------------------NAZIV LANCA-------------------------

        public string prikazLanca()
        {
            return _facade.prikazLanca();
        }

        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------
        //-------------------------LOGIN-------------------------

        public Admin getAdminByUsername(string username, string password)
        {
            return _facade.getAdminByUsername(username, password);
        }

        public void addAdmin(Admin admin)
        {
            _facade.addAdmin(admin);
        }

        public void updateAdmin(Admin admin)
        {
            _facade.updateAdmin(admin);
        }

        public void deleteAdmin(int id)
        {
            _facade.deleteAdmin(id);
        }

        public void updateAdminByUsername(Admin admin, string username)
        {
            _facade.updateAdminByUsername(admin, username);
        }

        public List<EntityChange> GetChangesAfter(DateTime lastCheck)
        {
            throw new NotImplementedException();
            //ne treba nista da radi ovde, potrebna je gore u kodu da se pozove kroz facade za observer
        }

        //-------------------------IZVESTAJ-------------------------
        public List<ReportRow> GetReportRows(DateTime start, DateTime end) => _facade.GetReportRows(start, end);
    }
}


