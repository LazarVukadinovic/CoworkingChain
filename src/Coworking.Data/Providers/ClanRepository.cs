using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class ClanRepository : IRepository<Clan>
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public ClanRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseFactory();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void Add(Clan item)
        {
            string upit = $@"
            INSERT INTO clan (ime, prezime, email, telefon, datum_pocetka, datum_kraja, status_naloga, tip_clanstva_id, kreiran_u)
            VALUES (
                '{item.ime}',
                '{item.prezime}',
                '{item.mail}',
                '{item.brTelefona}',
                '{item.datumPocetka}',
                '{item.datumKraja}',
                '{item.statusNaloga}',
                '{item.tipClanstva}',
                '{item.kreiran}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Clan> GetAll()
        {
            string upit = "SELECT * FROM clan";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapClan);
        }

        public void Update(Clan item)
        {
            string upit = $@"
            UPDATE clan
            SET 
                ime = '{item.ime}',
                prezime = '{item.prezime}',
                mail = '{item.mail}',
                br_telefona = '{item.brTelefona}',
                datum_pocetka = '{item.datumPocetka}',
                datum_kraja = '{item.datumKraja}',
                status_naloga = '{item.statusNaloga}',
                tip_clanstva = '{item.tipClanstva}',
                kreiran = '{item.kreiran}'
            WHERE clan_id = {item.clanId};";
            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Clan> vratiClanovePoLokaciji(int lokacijaId)
        {
            string upit = @$"SELECT * FROM clan c JOIN rezervacija rv on rv.clan_id=c.clan_id JOIN resurs r on r.resurs_id=rv.resurs_id WHERE r.lokacija_id={lokacijaId}";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapClan);
        }
    }
}
