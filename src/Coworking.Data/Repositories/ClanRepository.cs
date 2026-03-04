using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal class ClanRepository : IRepository<Clan>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public ClanRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
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

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void delete(int clanId)
        {
            string upit = $@"
            DELETE FROM clan
            WHERE clan_id={clanId};
            ";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Clan> GetAll()
        {
            string upit = "SELECT * FROM clan";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }

        public Clan GetById(int id)
        {
            string upit = $"SELECT * FROM clan WHERE clan_id={id}";
            var clanovi = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
            return clanovi.Count > 0 ? clanovi[0] : null;
        }

        public List<Clan> GetByName(string name)
        {
            string upit = $"SELECT * FROM clan WHERE ime='{name}'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
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
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Clan> vratiClanovePoLokaciji(int lokacijaId)
        {
            string upit = @$"SELECT DISTINCT c.* FROM clan c JOIN rezervacija rv on rv.clan_id=c.clan_id JOIN resurs r on r.resurs_id=rv.resurs_id WHERE r.lokacija_id={lokacijaId} AND rv.status = 'Rezervisana'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }
    }
}
