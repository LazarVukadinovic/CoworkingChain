using Coworking.Domain.Entities;
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

        public DataBaseProxy() { }

        public void dodajClana(Clan c)
        {
            throw new NotImplementedException();
        }

        public void dodajLokaciju(Lokacija l)
        {
            throw new NotImplementedException();
        }

        public void dodajRezervaciju(Rezervacija r)
        {
            throw new NotImplementedException();
        }

        public void dodajTipClanstva(TipClanstva t)
        {
            throw new NotImplementedException();
        }

        public void izmeniRezervaciju(Rezervacija r)
        {
            throw new NotImplementedException();
        }

        public void otkaziRezervaciju(Rezervacija r)
        {
            throw new NotImplementedException();
        }

        public List<Clan> prikaziClanove()
        {
            throw new NotImplementedException();
        }

        public List<Rezervacija> prikaziKorisnickeRezervacije()
        {
            throw new NotImplementedException();
        }

        public List<Lokacija> prikaziLokacije()
        {
            throw new NotImplementedException();
        }

        public List<Resurs> prikaziResurse()
        {
            throw new NotImplementedException();
        }

        public List<Rezervacija> prikaziRezervacije()
        {
            throw new NotImplementedException();
        }

        public string prikazLanca()
        {
            throw new NotImplementedException();
        }
    }
}
