using Coworking.Data.Reports;
using Coworking.Data.Repositories;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using System.Timers;

namespace Coworking.Data.Providers
{
    public class DataBaseProxy : IDataBase
    {
        private IDataBase _facade;

        bool check2=false;
        List<Clan>? cachedClanovi = null;
        List<Lokacija>? cachedLokacija = null;
        List<Rezervacija>? cachedRezervacije = null;
        List<Resurs> cachedResursi = null;
        List<TipClanstva>? cachedTipClanstva = null;

        bool clanReset = true;
        bool lokacijaReset = true;
        bool resursReset = true;
        bool rezervacijaReset = true;
        bool tipClanstvaReset = true;

        private readonly object _lock = new object();

        System.Timers.Timer _timer;

        public event Action<DataEntity> DataChanged;

        
        private bool _checking = false;
        DateTime lastCheck;
        public DataBaseProxy(IDataBase facade) 
        {
            _facade = facade;
            _timer = new System.Timers.Timer(10000); // 5 sekundi
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            lastCheck = DateTime.Now;
            _timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_checking) return;

            _checking = true;

            try
            {
                CheckExternalChanges();
            }
            finally
            {
                _checking = false;
            }
        }

        public void CheckExternalChanges()
        {
            lock (_lock)
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
        }

        private void InvalidateCache(DataEntity entity)
        {
            lock (_lock)
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
        }

        private void Notify(DataEntity entity) => DataChanged?.Invoke(entity);

        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------

        public void dodajClana(Clan c)
        {
            _facade.dodajClana(c); // 1. Izvrši u bazi
            InvalidateCache(DataEntity.Clan); // 2. Očisti lokalni keš odmah
            Notify(DataEntity.Clan); // 3. Javi GUI-ju da se osveži TRENUTNO
        }

        public void izmeniClana(Clan c)
        {
            _facade.izmeniClana(c);
            InvalidateCache(DataEntity.Clan);
            Notify(DataEntity.Clan);
        }

        public List<Clan> prikaziClanove()
        {
            lock (_lock)
            {
                if (cachedClanovi == null || clanReset == true)
                {
                    cachedClanovi = _facade.prikaziClanove();
                    clanReset = false;
                }
                return cachedClanovi;
            }
        }
        public void obrisiClana(int clanId)
        {
            _facade.obrisiClana(clanId);
            InvalidateCache(DataEntity.Clan);
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
            InvalidateCache(DataEntity.Lokacija);
            Notify(DataEntity.Lokacija);
        }
        public void izmeniLokaciju(Lokacija l)
        {
            _facade.izmeniLokaciju(l);
            InvalidateCache(DataEntity.Lokacija);
            Notify(DataEntity.Lokacija);
        }
        public void obrisiLokaciju(int lokacijaId)
        {
            _facade.obrisiLokaciju(lokacijaId);
            InvalidateCache(DataEntity.Lokacija);
            Notify(DataEntity.Lokacija);
        }

        public List<Lokacija> prikaziLokacije(bool check)
        {
            lock (_lock)
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
            InvalidateCache(DataEntity.Rezervacija);
            Notify(DataEntity.Rezervacija);
        }
        public void izmeniRezervaciju(Rezervacija r)
        {
            _facade.izmeniRezervaciju(r);
            InvalidateCache(DataEntity.Rezervacija);
            Notify(DataEntity.Rezervacija);
        }
        public void otkaziRezervaciju(int rezervacijaId)
        {
            _facade.otkaziRezervaciju(rezervacijaId);
            InvalidateCache(DataEntity.Rezervacija);
            Notify(DataEntity.Rezervacija);
        }
        public void obrisiRezervaciju(int rezervacijaId)
        {
            _facade.obrisiRezervaciju(rezervacijaId);
            InvalidateCache(DataEntity.Rezervacija);
            Notify(DataEntity.Rezervacija);
        }
        public List<Rezervacija> prikaziSveRezervacije()
        {
            lock (_lock)
            {
                if (cachedRezervacije == null || rezervacijaReset == true)
                {
                    cachedRezervacije = _facade.prikaziSveRezervacije();
                    rezervacijaReset = false;
                }
                return cachedRezervacije;
            }
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
        }
        public void dodajRadnoMesto(RadnoMesto r)
        {
            _facade.dodajRadnoMesto(r);
        }
        public void izmeniSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.izmeniSaluZaSastanke(s);
        }
        public void dodajSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.dodajSaluZaSastanke(s);
        }
        public void dodajResurs(Resurs r)
        {
            _facade.dodajResurs(r);
            InvalidateCache(DataEntity.Resurs);
            Notify(DataEntity.Resurs);
        }

        public void izmeniResurs(Resurs r)
        {
            _facade.izmeniResurs(r);
            InvalidateCache(DataEntity.Resurs);
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
            lock (_lock)
            {
                if (cachedResursi == null || resursReset == true)
                {
                    cachedResursi = _facade.prikaziSveResurse();
                    resursReset = false;
                }
                return cachedResursi;
            }
        }
        public void obrisiResurs(int resursId)
        {
            _facade.obrisiResurs(resursId);
            InvalidateCache(DataEntity.Resurs);
            Notify(DataEntity.Resurs);
        }
        public Resurs giveLastAddedResource() => _facade.giveLastAddedResource();

        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------

        public void dodajTipClanstva(Domain.Entities.TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
            InvalidateCache(DataEntity.TipClanstva);
            Notify(DataEntity.TipClanstva);
        }
        public List<TipClanstva> prikaziSveTipoveClanstva()
        {
            lock (_lock)
            {
                if (cachedTipClanstva == null || tipClanstvaReset == true)
                {
                    cachedTipClanstva = _facade.prikaziSveTipoveClanstva();
                    tipClanstvaReset = false;
                }
                return cachedTipClanstva;
            }
        }

        public List<TipClanstva> GetTipClanstvaByName(string naziv)
        {
            return _facade.GetTipClanstvaByName(naziv);
        }

        public void updateTipClanstva(TipClanstva t)
        {
            _facade.updateTipClanstva(t);
            InvalidateCache(DataEntity.TipClanstva);
            Notify(DataEntity.TipClanstva);
        }

        public TipClanstva GetTipClanstvaById(int id)
        {
            return _facade.GetTipClanstvaById(id);
        }

        public void DeleteTipClanstva(int id)
        {
            _facade.DeleteTipClanstva(id);
            InvalidateCache(DataEntity.TipClanstva);
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


