using Coworking.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class DataBaseMapper
    {
        public DataBaseMapper() { }

        public List<T> mapDataTable<T>(DataTable dataTable, Func<DataRow, T> mapFunction)
        {
            var list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(mapFunction(row));
            }
            return list;
        }

        public Clan mapClan(DataRow red)
        {
            return new Clan
            {
                clanId = (int)red["clan_id"],
                ime = red["ime"].ToString(),
                prezime = red["prezime"].ToString(),
                mail = red["email"].ToString(),
                brTelefona = red["telefon"].ToString(),
                datumPocetka = red["datum_pocetka"].ToString(),
                datumKraja = red["datum_kraja"].ToString(),
                statusNaloga = red["status_naloga"].ToString(),
                tipClanstva = red["tip_clanstva_id"].ToString(),
                kreiran = red["kreiran_u"].ToString()
            };
        }

        public Lokacija mapLokacija(DataRow red)
        {
            return new Lokacija
            {
                lokacijaId = (int)red["lokacija_id"],
                naziv = red["naziv"].ToString(),
                adresa = red["adresa"].ToString(),
                grad = red["grad"].ToString(),
                radnoVreme = red["radno_vreme"].ToString(),
                maxKapacitet = (int)red["max_kapacitet"],
                opis = red["opis"].ToString()
            };
        }

        public Resurs mapResurs(DataRow red)
        {
            return new Resurs
            {
                resursId = (int)red["resurs_id"],
                lokacijaId = (int)red["lokacija_id"],
                oznaka = red["oznaka"].ToString(),
                tipResursa = red["tip_resursa"].ToString(),
                opis = red["opis"].ToString(),
                aktivan = (int)red["aktivan"],
            };
        }

        public TipClanstva mapTipClanstva(DataRow red)
        {
            return new TipClanstva
            {
                tipClanstvaId = (int)red["tip_clanstva_id"],
                naziv = red["naziv"].ToString(),
                cena = float.Parse(red["cena"].ToString()),
                trajanjeDana = (int)red["trajanje_dana"],
                maxSatiRezervacijeMesecno = (int)red["max_sati_nedelje"],
                dozvoljenaSala = red["dozvoljena_sala"].ToString(),
                satiSaleMesecno = (int)red["sati_sale_mesecno"]
            };
        }

        public Rezervacija mapRezervacija(DataRow red)
        {
            return new Rezervacija
            {
                rezervacijaId = (int)red["rezervacija_id"],
                pocetak = red["pocetak"].ToString(),
                kraj = red["kraj"].ToString(),
                status = (int)red["status"],
                kreiranoU = red["kreirano_u"].ToString(),
                otkazanoU = red["otkazano_u"].ToString(),
                clanId = (int)red["clan_id"],
                resursId = (int)red["resurs_id"]
            };
        }
    }
}
