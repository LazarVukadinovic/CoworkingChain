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

        // --- Simple caches ---
        List<Clan>? cachedClanovi = null;
        List<Lokacija>? cachedLokacija = null;
        List<Rezervacija>? cachedRezervacije = null;
        List<Resurs>? cachedResursi = null;
        List<TipClanstva>? cachedTipClanstva = null;
        List<RadnoMesto>? cachedDostupnaRadnaMesta = null;

        // --- Dictionary caches za parametrizovane upite ---
        Dictionary<(int?, int?, string?), List<Clan>> cachedFiltriraneClanovi = new();
        Dictionary<(int?, string), List<Resurs>> cachedResursiPoLokacijiITipu = new();
        Dictionary<(string, int), List<Rezervacija>> cachedRezervacijePoDatumuILokaciji = new();
        Dictionary<(int, string), List<Rezervacija>> cachedRezervacijePoClanu = new();
        Dictionary<int, List<RadnoMesto>> cachedDostupnaRadnaMestaPoLokaciji = new();
        Dictionary<(DateTime, DateTime), List<ReportRow>> cachedReportRows = new();

        // --- Reset flags ---
        bool clanReset = true;
        bool lokacijaReset = true;
        bool resursReset = true;
        bool rezervacijaReset = true;
        bool tipClanstvaReset = true;

        bool check2 = false;

        private readonly object _lock = new object();
        private bool _checking = false;
        DateTime lastCheck;
        System.Timers.Timer _timer;

        public event Action<DataEntity> DataChanged;

        public DataBaseProxy(IDataBase facade)
        {
            _facade = facade;
            _timer = new System.Timers.Timer(10000);
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            lastCheck = DateTime.Now;
            _timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_checking) return;
            _checking = true;
            try { CheckExternalChanges(); }
            finally { _checking = false; }
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

        // BEZ lock-a unutra — uvek se poziva iz vec lock-ovanog konteksta
        private void InvalidateCache(DataEntity entity)
        {
            switch (entity)
            {
                case DataEntity.Clan:
                    clanReset = true;
                    cachedClanovi = null;
                    cachedFiltriraneClanovi.Clear();
                    break;

                case DataEntity.Resurs:
                    resursReset = true;
                    cachedResursi = null;
                    cachedResursiPoLokacijiITipu.Clear();
                    cachedDostupnaRadnaMesta = null;
                    cachedDostupnaRadnaMestaPoLokaciji.Clear();
                    break;

                case DataEntity.Lokacija:
                    lokacijaReset = true;
                    cachedLokacija = null;
                    break;

                case DataEntity.Rezervacija:
                    rezervacijaReset = true;
                    cachedRezervacije = null;
                    cachedRezervacijePoDatumuILokaciji.Clear();
                    cachedRezervacijePoClanu.Clear();
                    cachedReportRows.Clear(); // izvestaji zavise od rezervacija
                    break;

                case DataEntity.TipClanstva:
                    tipClanstvaReset = true;
                    cachedTipClanstva = null;
                    break;
            }
        }

        private void Notify(DataEntity entity) => DataChanged?.Invoke(entity);

        //-------------------------CLANOVI-------------------------

        public void dodajClana(Clan c)
        {
            _facade.dodajClana(c);
            lock (_lock) { InvalidateCache(DataEntity.Clan); }
            Notify(DataEntity.Clan);
        }

        public void izmeniClana(Clan c)
        {
            _facade.izmeniClana(c);
            lock (_lock) { InvalidateCache(DataEntity.Clan); }
            Notify(DataEntity.Clan);
        }

        public void obrisiClana(int clanId)
        {
            _facade.obrisiClana(clanId);
            lock (_lock) { InvalidateCache(DataEntity.Clan); }
            Notify(DataEntity.Clan);
        }

        public List<Clan> prikaziClanove()
        {
            lock (_lock)
            {
                if (cachedClanovi == null || clanReset)
                {
                    cachedClanovi = _facade.prikaziClanove();
                    clanReset = false;
                }
                return cachedClanovi;
            }
        }

        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            lock (_lock)
            {
                var key = (lokacijaId, tipClanstvaId, status);
                if (clanReset || !cachedFiltriraneClanovi.ContainsKey(key))
                {
                    cachedFiltriraneClanovi[key] = _facade.PrikaziClanoveFiltrirano(lokacijaId, tipClanstvaId, status);
                }
                return cachedFiltriraneClanovi[key];
            }
        }

        // Ne kesira — search upiti su uvek razliciti
        public List<Clan> vratiClanovePoImenu(string name) => _facade.vratiClanovePoImenu(name);

        public int vratiClanovePoLokaciji(int lokacijaId) => _facade.vratiClanovePoLokaciji(lokacijaId);

        public double vratiUkupneSateSalaZaClana(int clanId) => _facade.vratiUkupneSateSalaZaClana(clanId);

        public List<StatistikaLokacijeDTO> PrikaziStatistikuLokacija() => _facade.PrikaziStatistikuLokacija();

        //-------------------------LOKACIJE-------------------------

        public void dodajLokaciju(Lokacija l)
        {
            _facade.dodajLokaciju(l);
            lock (_lock) { InvalidateCache(DataEntity.Lokacija); }
            Notify(DataEntity.Lokacija);
        }

        public void izmeniLokaciju(Lokacija l)
        {
            _facade.izmeniLokaciju(l);
            lock (_lock) { InvalidateCache(DataEntity.Lokacija); }
            Notify(DataEntity.Lokacija);
        }

        public void obrisiLokaciju(int lokacijaId)
        {
            _facade.obrisiLokaciju(lokacijaId);
            lock (_lock) { InvalidateCache(DataEntity.Lokacija); }
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

        // Ne kesira — search upit
        public List<Lokacija> GetLokacijaByName(string naziv) => _facade.GetLokacijaByName(naziv);

        public Lokacija GetLokacijaById(int id) => _facade.GetLokacijaById(id);

        public Lokacija getLokacijaByResursId(int resursId) => _facade.getLokacijaByResursId(resursId);

        //-------------------------REZERVACIJE-------------------------

        public void dodajRezervaciju(Rezervacija r)
        {
            _facade.dodajRezervaciju(r);
            lock (_lock) { InvalidateCache(DataEntity.Rezervacija); }
            Notify(DataEntity.Rezervacija);
        }

        public void izmeniRezervaciju(Rezervacija r)
        {
            _facade.izmeniRezervaciju(r);
            lock (_lock) { InvalidateCache(DataEntity.Rezervacija); }
            Notify(DataEntity.Rezervacija);
        }

        public void otkaziRezervaciju(int rezervacijaId)
        {
            _facade.otkaziRezervaciju(rezervacijaId);
            lock (_lock) { InvalidateCache(DataEntity.Rezervacija); }
            Notify(DataEntity.Rezervacija);
        }

        public void obrisiRezervaciju(int rezervacijaId)
        {
            _facade.obrisiRezervaciju(rezervacijaId);
            lock (_lock) { InvalidateCache(DataEntity.Rezervacija); }
            Notify(DataEntity.Rezervacija);
        }

        public List<Rezervacija> prikaziSveRezervacije()
        {
            lock (_lock)
            {
                if (cachedRezervacije == null || rezervacijaReset)
                {
                    cachedRezervacije = _facade.prikaziSveRezervacije();
                    rezervacijaReset = false;
                }
                return cachedRezervacije;
            }
        }

        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, int lokacija)
        {
            lock (_lock)
            {
                var key = (datum, lokacija);
                if (rezervacijaReset || !cachedRezervacijePoDatumuILokaciji.ContainsKey(key))
                {
                    cachedRezervacijePoDatumuILokaciji[key] = _facade.prikaziRezervacijeZaDanILokaciju(datum, lokacija);
                }
                return cachedRezervacijePoDatumuILokaciji[key];
            }
        }

        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId, List<ReservationStatus> filterStatusi)
        {
            lock (_lock)
            {
                // Kljuc kombinuje clanId I sortiranu listu statusa da bi izbegao lazne cache hitove
                var statusKey = string.Join(",", filterStatusi.Select(s => (int)s).OrderBy(x => x));
                var key = (clanId, statusKey);

                if (rezervacijaReset || !cachedRezervacijePoClanu.ContainsKey(key))
                {
                    cachedRezervacijePoClanu[key] = _facade.prikaziRezervacijeSaStatusomZaIzabranogClana(clanId, filterStatusi);
                }
                return cachedRezervacijePoClanu[key];
            }
        }

        //-------------------------RESURSI-------------------------

        public void dodajResurs(Resurs r)
        {
            _facade.dodajResurs(r);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public void izmeniResurs(Resurs r)
        {
            _facade.izmeniResurs(r);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public void obrisiResurs(int resursId)
        {
            _facade.obrisiResurs(resursId);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        // RadnoMesto i SalaZaSastanke su podtipovi Resursa — invalidiraju Resurs kes
        public void dodajRadnoMesto(RadnoMesto r)
        {
            _facade.dodajRadnoMesto(r);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public void izmeniRadnoMesto(RadnoMesto r)
        {
            _facade.izmeniRadnoMesto(r);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public void dodajSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.dodajSaluZaSastanke(s);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public void izmeniSaluZaSastanke(SalaZaSastanke s)
        {
            _facade.izmeniSaluZaSastanke(s);
            lock (_lock) { InvalidateCache(DataEntity.Resurs); }
            Notify(DataEntity.Resurs);
        }

        public List<Resurs> prikaziSveResurse()
        {
            lock (_lock)
            {
                if (cachedResursi == null || resursReset)
                {
                    cachedResursi = _facade.prikaziSveResurse();
                    resursReset = false;
                }
                return cachedResursi;
            }
        }

        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int? lokacijaId, string name)
        {
            lock (_lock)
            {
                var key = (lokacijaId, name);
                if (resursReset || !cachedResursiPoLokacijiITipu.ContainsKey(key))
                {
                    cachedResursiPoLokacijiITipu[key] = _facade.prikaziResursePoLokacijiIPoTipu(lokacijaId, name);
                }
                return cachedResursiPoLokacijiITipu[key];
            }
        }

        public List<RadnoMesto> prikaziDostupnaRadnaMesta()
        {
            lock (_lock)
            {
                if (cachedDostupnaRadnaMesta == null || resursReset)
                {
                    cachedDostupnaRadnaMesta = _facade.prikaziDostupnaRadnaMesta();
                    // Ne resetujemo resursReset ovde jer ga dele vise metoda
                }
                return cachedDostupnaRadnaMesta;
            }
        }

        public List<RadnoMesto> prikaziDostupnaRadnaMestaPoLokaciji(int lokacijaId)
        {
            lock (_lock)
            {
                if (resursReset || !cachedDostupnaRadnaMestaPoLokaciji.ContainsKey(lokacijaId))
                {
                    cachedDostupnaRadnaMestaPoLokaciji[lokacijaId] = _facade.prikaziDostupnaRadnaMestaPoLokaciji(lokacijaId);
                }
                return cachedDostupnaRadnaMestaPoLokaciji[lokacijaId];
            }
        }

        public SalaZaSastanke prikaziSaleZaSastankePoId(int resursId) => _facade.prikaziSaleZaSastankePoId(resursId);

        public RadnoMesto prikaziRadnaMestaPoId(int resursId) => _facade.prikaziRadnaMestaPoId(resursId);

        public Resurs giveLastAddedResource() => _facade.giveLastAddedResource();

        //-------------------------TIP CLANSTVA-------------------------

        public void dodajTipClanstva(TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
            lock (_lock) { InvalidateCache(DataEntity.TipClanstva); }
            Notify(DataEntity.TipClanstva);
        }

        public void updateTipClanstva(TipClanstva t)
        {
            _facade.updateTipClanstva(t);
            lock (_lock) { InvalidateCache(DataEntity.TipClanstva); }
            Notify(DataEntity.TipClanstva);
        }

        public void DeleteTipClanstva(int id)
        {
            _facade.DeleteTipClanstva(id);
            lock (_lock) { InvalidateCache(DataEntity.TipClanstva); }
            Notify(DataEntity.TipClanstva);
        }

        public List<TipClanstva> prikaziSveTipoveClanstva()
        {
            lock (_lock)
            {
                if (cachedTipClanstva == null || tipClanstvaReset)
                {
                    cachedTipClanstva = _facade.prikaziSveTipoveClanstva();
                    tipClanstvaReset = false;
                }
                return cachedTipClanstva;
            }
        }

        // Ne kesira — search upit
        public List<TipClanstva> GetTipClanstvaByName(string naziv) => _facade.GetTipClanstvaByName(naziv);

        public TipClanstva GetTipClanstvaById(int id) => _facade.GetTipClanstvaById(id);

        //-------------------------NAZIV LANCA-------------------------

        public string prikazLanca() => _facade.prikazLanca();

        //-------------------------LOGIN-------------------------

        public Admin getAdminByUsername(string username, string password) => _facade.getAdminByUsername(username, password);

        public void addAdmin(Admin admin) => _facade.addAdmin(admin);

        public void updateAdmin(Admin admin) => _facade.updateAdmin(admin);

        public void deleteAdmin(int id) => _facade.deleteAdmin(id);

        public void updateAdminByUsername(Admin admin, string username) => _facade.updateAdminByUsername(admin, username);

        public List<EntityChange> GetChangesAfter(DateTime lastCheck)
        {
            throw new NotImplementedException();
            // Ne treba ovde — poziva se kroz _facade gore u CheckExternalChanges
        }

        //-------------------------IZVESTAJ-------------------------

        public List<ReportRow> GetReportRows(DateTime start, DateTime end)
        {
            lock (_lock)
            {
                var key = (start, end);
                if (!cachedReportRows.ContainsKey(key))
                {
                    cachedReportRows[key] = _facade.GetReportRows(start, end);
                }
                return cachedReportRows[key];
            }
        }
    }
}