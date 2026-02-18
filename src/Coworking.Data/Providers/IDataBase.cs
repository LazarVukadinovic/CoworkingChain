using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal interface IDataBase
    {
        string prikazLanca();

        List<Clan> prikaziClanove();

        List<Lokacija> prikaziLokacije();

        List<Resurs> prikaziResurse();

        List<Rezervacija> prikaziRezervacije();

        List<Rezervacija> prikaziKorisnickeRezervacije();

        void dodajRezervaciju(Rezervacija r);

        void otkaziRezervaciju(Rezervacija r);
        
        void izmeniRezervaciju(Rezervacija r);

        void dodajClana(Clan c);
        
        void dodajLokaciju(Lokacija l);

        void dodajTipClanstva(TipClanstva t);



    }
}
