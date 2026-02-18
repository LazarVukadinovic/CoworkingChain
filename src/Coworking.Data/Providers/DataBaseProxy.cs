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
        private DataBaseFacade facade;

        List<Clan>? cachedClanovi = null;
        List<TipClanstva>? cachedTipClanstva = null;
        List<Lokacija>? cachedLokacija = null;
        List<Resurs>? cachedResurs = null;
        List<Rezervacija>? cachedRezervacija = null;
        List<Rezervacija>? cachedKorisnickaRezervacija = null;

        bool needReset = true;

        public DataBaseProxy() 
        {
            facade = new DataBaseFacade();
        }

        public void dodajClana(Clan c)
        {
            facade.dodajClana(c);
            needReset = true;
        }

        public void dodajLokaciju(Lokacija l)
        {
            facade.dodajLokaciju(l);
            needReset = true;
        }

        public void dodajRezervaciju(Rezervacija r)
        {
            facade.dodajRezervaciju(r);
            needReset = true;
        }

        public void dodajTipClanstva(TipClanstva t)
        {
            facade.dodajTipClanstva(t);
            needReset = true;
        }

        public void izmeniRezervaciju(Rezervacija r)
        {
            facade.izmeniRezervaciju(r);
            needReset = true;
        }

        public void otkaziRezervaciju(Rezervacija r)
        {
            facade.otkaziRezervaciju(r);
            needReset = true;
        }

        public List<Clan> prikaziClanove()
        {
            if(cachedClanovi == null || needReset == true)
            {
                cachedClanovi = facade.prikaziClanove();
                needReset = false;
            }
            return cachedClanovi;
        }

        public List<Rezervacija> prikaziKorisnickeRezervacije(int clan_id)
        {
            if (cachedKorisnickaRezervacija == null || needReset == true)
            {
                cachedKorisnickaRezervacija = facade.prikaziKorisnickeRezervacije(clan_id);
                needReset = false;
            }
            return cachedKorisnickaRezervacija;
        }

        public List<Lokacija> prikaziLokacije()
        {
            if (cachedLokacija == null || needReset == true)
            {
                cachedLokacija = facade.prikaziLokacije();
                needReset = false;
            }
            return cachedLokacija;
        }

        public List<Resurs> prikaziResurse()
        {
            if (cachedResurs == null || needReset == true)
            {
                cachedResurs = facade.prikaziResurse();
                needReset = false;
            }
            return cachedResurs;
        }

        public List<Rezervacija> prikaziRezervacije(string datum, string lokacija)
        {
            if (cachedRezervacija == null || needReset == true)
            {
                cachedRezervacija = facade.prikaziRezervacije(datum, lokacija);
                needReset = false;
            }
            return cachedRezervacija;
        }

        public string prikazLanca()
        {
            return facade.prikazLanca();
        }
    }
}
