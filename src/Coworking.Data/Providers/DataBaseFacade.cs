using Coworking.Domain.Entities;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class DataBaseFacade : IDataBase
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public DataBaseFacade()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseHelper();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void dodajClana(Clan c)
        {
            string upit = $@"
            INSERT INTO clan (ime, prezime, email, telefon, datum_pocetka, datum_kraja, status_naloga, tip_clanstva_id, kreiran_u)
            VALUES (
                '{c.ime}',
                '{c.prezime}',
                '{c.mail}',
                '{c.brTelefona}',
                '{c.datumPocetka}',
                '{c.datumKraja}',
                '{c.statusNaloga}',
                '{c.tipClanstva}',
                '{c.kreiran}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void dodajLokaciju(Lokacija l)
        {
            string upit = $@"
            INSERT INTO lokacija (naziv, adresa, grad, radno_vreme, max_kapacitet, opis)
            VALUES (
                '{l.naziv}',
                '{l.adresa}',
                '{l.grad}',
                '{l.radnoVreme}',
                '{l.maxKapacitet}',
                '{l.opis}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void dodajRezervaciju(Rezervacija r)
        {
            string upit = $@"
            INSERT INTO rezervacija (pocetak, kraj, status, kreirano_u, otkazano_u, clan_id, resurs_id)
            VALUES (
                '{r.pocetak}',
                '{r.kraj}',
                '{r.status}',
                '{r.kreiranoU}',
                '{r.otkazanoU}',
                '{r.clanId}',
                '{r.resursId}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void dodajTipClanstva(TipClanstva t)
        {
            string upit = $@"
            INSERT INTO tip_clanstva (naziv, cena, trajanje_dana, max_sati_mesecno, dozvoljena_sala, sati_sale_mesecno)
            VALUES (
                '{t.naziv}',
                '{t.cena}',
                '{t.trajanjeDana}',
                '{t.maxSatiRezervacijeMesecno}',
                '{t.dozvoljenaSala}',
                '{t.satiSaleMesecno}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void izmeniRezervaciju(Rezervacija r)
        {
            string upit = $@"
            UPDATE rezervacija
            SET pocetak = '{r.pocetak}',
            kraj = '{r.kraj}',
            status = '{r.status}',
            kreirano_u = '{r.kreiranoU}',
            otkazano_u = '{r.otkazanoU}',
            clan_id = '{r.clanId}'
            resurs_id = {r.resursId};
            WHERE rezervacija_id = '{r.rezervacijaId}'
            ";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public void otkaziRezervaciju(Rezervacija r)
        {
            // ne treba delete vec update, da status bude 'Otkazana'
            string upit = $"DELETE FROM rezervacija WHERE rezervacija_id = {r.rezervacijaId}";
            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Clan> prikaziClanove()
        {
            string upit = "SELECT * FROM clan";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapClan);

        }

        public List<Rezervacija> prikaziKorisnickeRezervacije(int clan_id)
        {
            // interfejs je bez parametara
            string upit = $"SELECT * FROM rezervacija WHERE clan_id={clan_id}";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRezervacija);
        }

        public List<Lokacija> prikaziLokacije()
        {
            string upit = "SELECT * FROM lokacija";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapLokacija);
        }

        public List<Resurs> prikaziResurse()
        {
            string upit = "SELECT * FROM resurs";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public List<Rezervacija> prikaziRezervacije(string datum,string lokacija)
        {
            // interfejs je bez parametara
            string upit = $"SELECT rv.*,r.naziv FROM rezervacija rv JOIN resurs r on rv.resurs_id=r.resurs_id WHERE rv.pocetak={DateTime.Parse(datum).Date} AND r.lokacija_id={lokacija}";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRezervacija);
        }

        public string prikazLanca()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            return File.ReadAllLines(path)[0];
        }
    }
}
