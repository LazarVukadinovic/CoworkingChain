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

        List<Rezervacija> prikaziRezervacije(string datum, string lokacija);

        List<Rezervacija> prikaziKorisnickeRezervacije(int clan_id);

        void dodajRezervaciju(Rezervacija r);

        void otkaziRezervaciju(Rezervacija r);
        
        void izmeniRezervaciju(Rezervacija r);

        void dodajClana(Clan c);
        
        void dodajLokaciju(Lokacija l);

        void dodajTipClanstva(Domain.Entities.TipClanstva t);



    }
}
