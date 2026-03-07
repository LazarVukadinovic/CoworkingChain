using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Data.Providers
{
    public interface IDataBase
    {
        //-------------------------CLANOVI-------------------------
        public void dodajClana(Clan c);
        public void izmeniClana(Clan c);
        public List<Clan> prikaziClanove();
        public void obrisiClana(int clanId);
        // Lista svih clanova, sa mogucnoscu filtriranja po lokaciji, tipu clanstva ili statusu naloga
        public List<Clan> PrikaziClanoveFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status);
        public int vratiClanovePoLokaciji(int lokacijaId);

        public double vratiUkupneSateSalaZaClana(int clanId);

        public List<Clan> vratiClanovePoImenu(string name);

        //-------------------------LOKACIJE-------------------------
        public void dodajLokaciju(Lokacija l);
        public void izmeniLokaciju(Lokacija l);
        public void obrisiLokaciju(int lokacijaId);
        // Lista svih co-working lokacija sa osnovnim statistikama (ukupan broj radnih mesta, broj trenutno rezervisanih,
        // procenat zauzetosti).
        public List<(Lokacija lokacija, int brojResursa, int brojRezervisanih, double procenatZauzetosti)> PrikaziStatistikuLokacija();
        // Prikaz liste svih lokacija, uz mogucnost izbora aktivne lokacije
        public List<Lokacija> prikaziLokacije(bool check);

        public List<Lokacija> GetLokacijaByName(string naziv);

        public Lokacija GetLokacijaById(int id);
        public Lokacija getLokacijaByResursId(int resursId);

        //-------------------------REZERVACIJE-------------------------
        public void dodajRezervaciju(Rezervacija r);
        public void izmeniRezervaciju(Rezervacija r);
        public void otkaziRezervaciju(int rezervacijaId);
        public void obrisiRezervaciju(int rezervacijaId);
        public List<Rezervacija> prikaziSveRezervacije();
        // Kreiranje rezervacija: korisnik + resurs (radno mesto ili sala) + lokacija + datum i vreme pocetka + datum i vreme zavrsetka
        // TO-DO

        // Lista svih rezervacija za izabranog korisnika, sa prikazom statusa (aktivna, prosla, otkazana)
        public List<Rezervacija> prikaziRezervacijeSaStatusomZaIzabranogClana(int clanId, List<ReservationStatus> filterStatusi);
        // Lista rezervacije za odabrani dan i lokaciju radi prikaza zauzetosti u toku dana.
        public List<Rezervacija> prikaziRezervacijeZaDanILokaciju(string datum, int lokacijaId);


        //-------------------------RESURSI-------------------------

        // Evidencija radnih mesta po lokaciji: hot desk, dedicated desk, privatna kancelarija,
        // sa informacijom da li je trenutno dostupno ili zauzeto.
        public List<RadnoMesto> prikaziDostupnaRadnaMestaPoLokaciji(int lokacijaId);
        public List<RadnoMesto> prikaziDostupnaRadnaMesta();
        // Evidencija sala za sastanke: naziv, kapacitet, opremljenost (projekat, TV, tabla, oprema za online sastanke...).
        public SalaZaSastanke prikaziSaleZaSastankePoId(int resursId);
        public RadnoMesto prikaziRadnaMestaPoId(int resursId);
        // Lista svih resursa po lokaciji, razvrstanih po tipu (radna mesta, sala za sastanke)
        public List<Resurs> prikaziResursePoLokacijiIPoTipu(int? lokacijaId, string name);
        // Lista svih resursa
        public List<Resurs> prikaziSveResurse();
        public void obrisiResurs(int resursId);

        public void izmeniRadnoMesto(RadnoMesto r);
        public void dodajRadnoMesto(RadnoMesto r);
        public void izmeniSaluZaSastanke(SalaZaSastanke s);
        public void dodajSaluZaSastanke(SalaZaSastanke s);
        public void izmeniResurs(Resurs r);
        public void dodajResurs(Resurs r);
        public Resurs giveLastAddedResource();

        //-------------------------TIP CLANSTVA-------------------------
        public void dodajTipClanstva(TipClanstva t);
        public List<TipClanstva> prikaziSveTipoveClanstva();

        public void updateTipClanstva(TipClanstva t);
        public List<TipClanstva> GetTipClanstvaByName(string naziv);

        public TipClanstva GetTipClanstvaById(int id);

        public void DeleteTipClanstva(int id);



        //-------------------------NAZIV LANCA-------------------------
        public string prikazLanca();


        //-------------------------LOGIN-------------------------
        public Admin getAdminByUsername(string username, string password);

        public void updateAdminByUsername(Admin admin, string username);
        public void addAdmin(Admin admin);
        public void updateAdmin(Admin admin);
        public void deleteAdmin(int id);
    }
}


