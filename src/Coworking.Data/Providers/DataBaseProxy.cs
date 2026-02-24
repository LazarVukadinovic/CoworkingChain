using Coworking.Domain.Entities;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void dodajClana(Clan c)
        {
            _facade.dodajClana(c);
            needReset = true;
        }

        public void dodajLokaciju(Lokacija l)
        {
            _facade.dodajLokaciju(l);
            needReset = true;
        }

        public void dodajRezervaciju(Rezervacija r)
        {
            _facade.dodajRezervaciju(r);
            needReset = true;
        }

        public void dodajTipClanstva(Domain.Entities.TipClanstva t)
        {
            _facade.dodajTipClanstva(t);
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

        public List<Clan> prikaziClanove()
        {
            if(cachedClanovi == null || needReset == true)
            {
                cachedClanovi = _facade.prikaziClanove();
                needReset = false;
            }
            return cachedClanovi;
        }

        public List<Rezervacija> prikaziKorisnickeRezervacije(int clan_id) 
        {   
            if (!cachedKorisnickeRezervacije.ContainsKey(clan_id) || needReset) 
            { 
                cachedKorisnickeRezervacije[clan_id] = _facade.prikaziKorisnickeRezervacije(clan_id); 
                needReset = false; 
            } 
            return cachedKorisnickeRezervacije[clan_id]; 
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

        public string prikazLanca()
        {
            return _facade.prikazLanca();
        }

        public List<Resurs> prikaziResursePoLokaciji(int lokacijaId)
        {
            return _facade.prikaziResursePoLokaciji(lokacijaId);
        }

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
