using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    public interface IDataBase
    {
        string prikazLanca();

        List<Clan> prikaziClanove();

        List<Lokacija> prikaziLokacije(bool check);

        List<Resurs> prikaziResurse();

        List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, string lokacija);

        List<Rezervacija> prikaziKorisnickeRezervacije(int clan_id);

        void dodajRezervaciju(Rezervacija r);

        void otkaziRezervaciju(int rezervacijaId);
        
        void izmeniRezervaciju(Rezervacija r);

        void dodajClana(Clan c);
        
        void dodajLokaciju(Lokacija l);

        void dodajTipClanstva(Domain.Entities.TipClanstva t);

        //dodati funkcije iz faced koje nema ovde i dodati iste u proxy gde se i pozivaju za facade
        public List<Resurs> prikaziResursePoTipu(int lokacijaId);

        public bool getAdminByUsername(string username, string password);
        
        public void addAdmin(Admin admin);


    }
}
