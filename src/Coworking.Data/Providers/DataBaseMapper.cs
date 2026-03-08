using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Coworking.Data.Providers
{
    public class DataBaseMapper
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

        public EntityChange mapEntity(DataRow red)
        {
            return new EntityChange
            {
                EntityName = red["entity_name"].ToString(),
                ChangeTime = (red["change_time"]).ToString()
            };
        }

        public Clan mapClan(DataRow red)
        {
            return new Clan
            {
                clanId = Convert.ToInt32(red["clan_id"]),
                ime = red["ime"].ToString(),
                prezime = red["prezime"].ToString(),
                mail = red["email"].ToString(),
                brTelefona = red["telefon"] == DBNull.Value ? null : red["telefon"].ToString(),
                datumPocetka = red["datum_pocetka"].ToString(),
                datumKraja = red["datum_kraja"].ToString(),
                statusNaloga = red["status_naloga"].ToString(),
                tipClanstva = Convert.ToInt32(red["tip_clanstva_id"]),
                kreiran = red["kreiran_u"].ToString()
            };
        }

        public Lokacija mapLokacija(DataRow red)
        {
            return new Lokacija
            {
                lokacijaId = Convert.ToInt32(red["lokacija_id"]),
                naziv = red["naziv"].ToString(),
                adresa = red["adresa"].ToString(),
                grad = red["grad"].ToString(),
                radnoVreme = red["radno_vreme"] == DBNull.Value ? null : red["radno_vreme"].ToString(),
                maxKapacitet = Convert.ToInt32(red["max_kapacitet"]),
                opis = red["opis"] == DBNull.Value ? null : red["opis"].ToString()
            };
        }

        public Resurs mapResurs(DataRow red)
        {
            return new Resurs
            {
                resursId = Convert.ToInt32(red["resurs_id"]),
                lokacijaId = Convert.ToInt32(red["lokacija_id"]),
                oznaka = red["oznaka"].ToString(),
                tipResursa = red["tip_resursa"].ToString(),
                opis = red["opis"] == DBNull.Value ? null : red["opis"].ToString()
            };
        }

        public RadnoMesto mapRadnoMesto(DataRow red)
        {
            return new RadnoMesto
            {
                resursId = Convert.ToInt32(red["resurs_id"]),
                lokacijaId = Convert.ToInt32(red["lokacija_id"]),
                oznaka = red["oznaka"].ToString(),
                tipResursa = red["tip_resursa"].ToString(),
                opis = red["opis"].ToString(),
                podtip = PodtipRadnogMestaTransformator.FromDbString(red["podtip"]?.ToString() ?? "")
                //dostupan = red["dostupnost"].ToString()
            };
        }

        public SalaZaSastanke mapSalaZaSastanke(DataRow red)
        {
            return new SalaZaSastanke 
            {   resursId = Convert.ToInt32(red["resurs_id"]), 
                lokacijaId = Convert.ToInt32(red["lokacija_id"]), 
                oznaka = red["oznaka"].ToString(), 
                tipResursa = red["tip_resursa"].ToString(), 
                opis = red["opis"].ToString(),
                salaId= Convert.ToInt32(red["sala_detalj_id"]),
                kapacitet = Convert.ToInt32(red["kapacitet"]),
                imaProjektor = Convert.ToBoolean(red["ima_projektor"]), 
                imaTablu = Convert.ToBoolean(red["ima_tablu"]), 
                imaTv = Convert.ToBoolean(red["ima_tv"]), 
                imaOpremuZaOnlineSastanke = Convert.ToBoolean(red["ima_online_opremu"]) 
            };
        }


        public Domain.Entities.TipClanstva mapTipClanstva(DataRow red)
        {
            return new Domain.Entities.TipClanstva
            {
                tipClanstvaId = Convert.ToInt32(red["tip_clanstva_id"]),
                naziv = red["naziv"].ToString(),
                cena = Convert.ToSingle(red["cena"].ToString(), System.Globalization.CultureInfo.InvariantCulture),
                maxSatiRezervacijeMesecno = Convert.ToInt32(red["max_sati_mesecno"]),
                trajanjeDana = Convert.ToInt32(red["trajanje_dana"]),
                satiSaleMesecno = Convert.ToInt32(red["sati_sale_mesecno"]),
                dozvoljenaSala = Convert.ToBoolean(red["dozvoljena_sala"])
            };
        }

        //public Rezervacija mapRezervacija(DataRow red)
        //{
        //    return new Rezervacija
        //    {
        //        rezervacijaId = Convert.ToInt32(red["rezervacija_id"]),
        //        pocetak = red["pocetak"].ToString(),
        //        kraj = red["kraj"].ToString(),
        //        // red["status"]?.ToString() ?? ""
        //        // ako je red["status"] null ceo izraz postaje null i ne zove se ToString(), ako nije null normalno se izvrsava
        //        // ?? - ako je levi deo null koristi se prazan string "", ako nije null onda standardno levi
        //        status = ReservationStatusTransformator.FromDbString(red["status"]?.ToString() ?? ""),
        //        kreiranoU = red["kreirano_u"].ToString(),
        //        otkazanoU = red["otkazano_u"] == DBNull.Value ? null : red["otkazano_u"].ToString(),
        //        clanId = Convert.ToInt32(red["clan_id"]),
        //        resursId = Convert.ToInt32(red["resurs_id"])
        //    };
        //}

        public Rezervacija mapRezervacija(DataRow red)
        {
            return new Rezervacija
            {
                rezervacijaId = Convert.ToInt32(red["rezervacija_id"]),
                pocetak = red["pocetak"] == DBNull.Value ? null : red["pocetak"].ToString(),
                kraj = red["kraj"] == DBNull.Value ? null : red["kraj"].ToString(),
                status = ReservationStatusTransformator.FromDbString(red["status"]?.ToString() ?? ""),
                kreiranoU = red["kreirano_u"] == DBNull.Value ? null
                                : red["kreirano_u"].ToString() == "0001-01-01 00:00:00" ? null
                                : red["kreirano_u"].ToString(),
                otkazanoU = red["otkazano_u"] == DBNull.Value ? null
                                : red["otkazano_u"].ToString() == "0001-01-01 00:00:00" ? null
                                : red["otkazano_u"].ToString(),
                clanId = Convert.ToInt32(red["clan_id"]),
                resursId = Convert.ToInt32(red["resurs_id"])
            };
        }

        public Admin mapAdmin(DataRow red)
        {
            return new Admin
            {
                adminId = Convert.ToInt32(red["admin_id"]),
                KorisnickoIme = red["korisnicko_ime"].ToString(),
                LozinkaHash = red["lozinka_hash"].ToString(),
            };
        }
    }
}
