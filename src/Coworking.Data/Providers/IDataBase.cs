using Coworking.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Recources
{
    internal interface IDataBase
    {
        string prikazLanca();

        List<Clan> prikaziClanove();

        List<Lokacija> prikaziLokacije();

        List<Resurs> prikaziResurse();

        List<Rezervacija> prikaziRezervacije();

        List<Rezervacija> prikaziKorisnickeRezervacije();

        void dodajRezervaciju(Rezervacija rezervacija);

        void otkaziRezervaciju(Rezervacija rezervacija);
        
        void izmeniRezervaciju(Rezervacija rezervacija);

        void dodajClana(Clan c);
        
        void dodajLokaciju(Lokacija l);

        void dodajTipClanstva(TipClanstva t);



    }
}
