using Coworking.Domain.Entities;

namespace Coworking.Data.Providers
{
    internal class DataBaseProxy : IDataBase
    {
        private IDataBase _facade;

        List<Clan>? cachedClanovi = null;
        List<Domain.Entities.TipClanstva>? cachedTipClanstva = null;
        List<Lokacija>? cachedLokacija = null;
        List<Resurs>? cachedResurs = null;
        private Dictionary<(string datum, string lokacija), List<Rezervacija>> cachedRezervacije = new Dictionary<(string, string), List<Rezervacija>>(); 
        private Dictionary<int, List<Rezervacija>> cachedKorisnickeRezervacije = new Dictionary<int, List<Rezervacija>>();

        bool needReset = true;

        public DataBaseProxy(IDataBase facade) 
        {
            _facade = facade;
        }

        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------
        //-------------------------CLANOVI-------------------------

        public void dodajClana(Clan c)
        {
            _facade.dodajClana(c);
            needReset = true;
        }
        public void izmeniClana(Clan c)
        {
            _facade.izmeniClana(c);
            needReset = true;
        }
        public List<Clan> prikaziClanove()
        {
            if (cachedClanovi == null || needReset == true)
            {
                cachedClanovi = _facade.prikaziClanove();
                needReset = false;
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

            //Ovo:briše člana iz cachedClanovi, briše njegove rezervacije iz cachedKorisnickeRezervacije i dalje forsira reload
            //sledeći put

            needReset = true;
        }
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            return null;
        }


        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        //-------------------------LOKACIJE-------------------------
        public void dodajLokaciju(Lokacija l)
        {
            _facade.dodajLokaciju(l);
            needReset = true;
        }
        public void izmeniLokaciju(Lokacija l)
        {
            _facade.izmeniLokaciju(l);
            needReset = true;
        }
        public void obrisiLokaciju(int lokacijaId)
        {
            _facade.obrisiLokaciju(lokacijaId);
            needReset = true;
        }
        public List<(Lokacija lokacija, int brojResursa, int brojRezervisanih, double procenatZauzetosti)> PrikaziStatistikuLokacija()
        {
            return null;
        }
        public List<Lokacija> prikaziLokacije(bool check)
        {
            if (cachedLokacija == null || needReset == true)
            {
                cachedLokacija = _facade.prikaziLokacije(check);
                needReset = false;
            }
            return cachedLokacija;
        }


        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        //-------------------------REZERVACIJE-------------------------
        public void dodajRezervaciju(Rezervacija r)
        {
            _facade.dodajRezervaciju(r);
            needReset = true;
        }
        public void izmeniRezervaciju(Rezervacija r)
        {
            _facade.izmeniRezervaciju(r);
            needReset = true;
        }
        public void otkaziRezervaciju(int rezId)
        {
            _facade.otkaziRezervaciju(rezId);
            needReset = true;
        }
        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO
        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId)
        {
            return null;
        }
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacija)
        {
            var key = (datum, lokacija);
            if (!cachedRezervacije.ContainsKey(key) || needReset)
            {
                cachedRezervacije[key] = _facade.prikaziRezervacijeZaDanILokaciju(datum, lokacija);
                needReset = false;
            }
            return cachedRezervacije[key];
        }


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
            return null;
        }
        public List<SalaZaSastanke> prikaziSaleZaSastanke()
        {
            return null;
        }
        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int lokacijaId)
        {
            return null;
        }


        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        
        public void dodajTipClanstva(Domain.Entities.TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
            needReset = true;
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

        public bool getAdminByUsername(string username, string password)
        {
            return _facade.getAdminByUsername(username, password);
        }

        public void addAdmin(Admin admin)
        {
            _facade.addAdmin(admin);
        }
    }
}
