using Coworking.Domain.Entities;
using Microsoft.Extensions.Logging.Abstractions;
using System.Security.Claims;

namespace Coworking.Data.Providers
{
    internal class DataBaseProxy : IDataBase
    {
        private IDataBase _facade;

        bool check2=false;
        List<Clan>? cachedClanovi = null;
        List<Clan>? cachedClanoviFiltrirano = null;

        List<(Lokacija lokacija, int brojResursa, int brojRezervisanih, double procenatZauzetosti)>? cachedLokacijaStatistika = null;
        List<Lokacija>? cachedLokacija = null;

        List<Rezervacija>? cachedRezervacije = null;
        private Dictionary<int, List<Rezervacija>> cachedRezervacijeSaStatusomZaIzabranogClana = new Dictionary<int, List<Rezervacija>>();
        private Dictionary<(string datum, string lokacija), List<Rezervacija>> cachedRezervacijeZaDanILokaciju = new Dictionary<(string, string), List<Rezervacija>>();

        private Dictionary<int, List<RadnoMesto>> cachedRadnaMestaPoLokaciji = new Dictionary<int, List<RadnoMesto>>();
        List<SalaZaSastanke>? cachedSalaZaSastanke = null;
        private Dictionary<int, List<Resurs>> cachedResursiPoLokacijiIPoTipu = new Dictionary<int, List<Resurs>>();
        List<Resurs> cachedResursi = null;

        List<TipClanstva>? cachedTipClanstva = null;

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

        //ovde mozda treba dictionary
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            if (cachedClanoviFiltrirano == null || needReset == true)
            {
                cachedClanoviFiltrirano = _facade.PrikaziClanoveFiltrirano(lokacijaId,tipClanstvaId,status);
                needReset = false;
            }
            return cachedClanoviFiltrirano;
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
            if (cachedLokacijaStatistika == null || needReset == true)
            {
                cachedLokacijaStatistika = _facade.PrikaziStatistikuLokacija();
                needReset = false;
            }
            return cachedLokacijaStatistika;
        }
        public List<Lokacija> prikaziLokacije(bool check)
        {
            if (check2 != check)
            {
                check2 = check;
                needReset = true;
            }
            if (cachedLokacija == null || needReset)
            {
                cachedLokacija = _facade.prikaziLokacije(check);
                needReset = false;
            }

            return cachedLokacija;
        }

        public List<Lokacija> GetLokacijaByName(string naziv) => _facade.GetLokacijaByName(naziv);

        public Lokacija GetLokacijaById(int id)
        {
            return _facade.GetLokacijaById(id);
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
        public void otkaziRezervaciju(int rezervacijaId)
        {
            _facade.otkaziRezervaciju(rezervacijaId);
            needReset = true;
        }
        public List<Rezervacija> prikaziSveRezervacije()
        {
            if (cachedRezervacije == null || needReset == true)
            {
                cachedRezervacije = _facade.prikaziSveRezervacije();
                
            }
            return cachedRezervacije;
        }

        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO
        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId)
        {
            if (cachedRezervacijeSaStatusomZaIzabranogClana.ContainsKey(clanId) == false || needReset == true)
            {
                cachedRezervacijeSaStatusomZaIzabranogClana[clanId] = _facade.prikaziRezervacijeSaStatusomZaIzabranogClana(clanId);
                needReset = false;
            }
            return cachedRezervacijeSaStatusomZaIzabranogClana[clanId];
        }
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacija)
        {
            var key = (datum, lokacija);
            if (cachedRezervacijeZaDanILokaciju.ContainsKey(key) == false || needReset)
            {
                cachedRezervacijeZaDanILokaciju[key] = _facade.prikaziRezervacijeZaDanILokaciju(datum, lokacija);
                needReset = false;
            }
            return cachedRezervacijeZaDanILokaciju[key];
        }


        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------
        //-------------------------RESURSI-------------------------

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
            if (cachedRadnaMestaPoLokaciji.ContainsKey(lokacijaId) == false || needReset == true)
            {
                cachedRadnaMestaPoLokaciji[lokacijaId] = _facade.prikaziRadnaMestaPoLokaciji(lokacijaId);
                needReset = false;
            }
            return cachedRadnaMestaPoLokaciji[lokacijaId];
        }
        public List<SalaZaSastanke> prikaziSaleZaSastanke()
        {
            if (cachedSalaZaSastanke == null || needReset == true)
            {
                cachedSalaZaSastanke = _facade.prikaziSaleZaSastanke();
                needReset = false;
            }
            return cachedSalaZaSastanke;
        }
        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int lokacijaId)
        {
            if (cachedResursiPoLokacijiIPoTipu.ContainsKey(lokacijaId) == false || needReset == true)
            {
                cachedResursiPoLokacijiIPoTipu[lokacijaId] = _facade.prikaziResursePoLokacijiIPoTipu(lokacijaId);
                needReset = false;
            }
            return cachedResursiPoLokacijiIPoTipu[lokacijaId];
        }
        public List<Resurs> prikaziSveResurse()
        {
            if (cachedResursi == null || needReset == true)
            {
                cachedResursi = _facade.prikaziSveResurse();
                needReset = false;
            }
            return cachedResursi;
        }


        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------
        //-------------------------TIP CLANSTVA-------------------------

        public void dodajTipClanstva(Domain.Entities.TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
            needReset = true;
        }
        public List<TipClanstva> prikaziSveTipoveClanstva()
        {
            if (cachedTipClanstva == null || needReset == true)
            {
                cachedTipClanstva = _facade.prikaziSveTipoveClanstva();
                needReset = false;
            }
            return cachedTipClanstva;
        }

        public void izmeniTipClanstva(TipClanstva t)
        {
            _facade.updateTipClanstva(t);
            needReset = true;
        }

        public List<TipClanstva> GetTipClanstvaByName(string naziv)
        {
            return _facade.GetTipClanstvaByName(naziv);
        }

        public void updateTipClanstva(TipClanstva t)
        {
            _facade.updateTipClanstva(t);
            needReset = true;
        }

        public TipClanstva GetTipClanstvaById(int id)
        {
            return _facade.GetTipClanstvaById(id);
        }

        public void DeleteTipClanstva(int id)
        {
            _facade.DeleteTipClanstva(id);
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
