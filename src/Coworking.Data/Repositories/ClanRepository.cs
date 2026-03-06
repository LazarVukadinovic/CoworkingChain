using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

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
                {item.tipClanstva},
                '{item.kreiran}'
            );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void delete(int clanId)
        {
            string upit = $@"
            DELETE FROM clan
            WHERE clan_id = {clanId};
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
            string upit = $"SELECT * FROM clan WHERE clan_id = {id}";
            var clanovi = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
            return clanovi.Count > 0 ? clanovi[0] : null;

            //if (clanovi.Count == 0) throw new KeyNotFoundException($"Clan sa id={id} ne postoji.");
            //return clanovi[0];
        }

        public List<Clan> GetByName(string name)
        {
            string upit = $"SELECT * FROM clan WHERE ime = '{name}'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }

        public void Update(Clan item)
        {
            string upit = $@"
                UPDATE clan
                SET 
                    ime = '{item.ime}',
                    prezime = '{item.prezime}',
                    telefon = '{item.brTelefona}',
                    datum_pocetka = '{item.datumPocetka}',
                    datum_kraja = '{item.datumKraja}',
                    status_naloga = '{item.statusNaloga}',
                    tip_clanstva_id = {item.tipClanstva}
                WHERE clan_id = {item.clanId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Clan> vratiClanovePoLokaciji(int lokacijaId)
        {
            string upit = @$"SELECT DISTINCT c.* FROM clan c 
                                JOIN rezervacija rv on rv.clan_id=c.clan_id 
                                JOIN resurs r on r.resurs_id=rv.resurs_id 
                                WHERE r.lokacija_id={lokacijaId} AND 
                                    rv.status = '{ReservationStatus.Rezervisana.ToDbString()}'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }

        public double GetTotalHoursInCurrentMonth(int clanId)
        {
            DateTime sada = DateTime.Now;
            string startMeseca = new DateTime(sada.Year, sada.Month, 1).ToString("yyyy-MM-dd HH:mm:ss");
            string krajMeseca = new DateTime(sada.Year, sada.Month, 1).AddMonths(1).ToString("yyyy-MM-dd HH:mm:ss");

            string otvaranjeSati = "SUBSTRING_INDEX(l.radno_vreme, '-', 1)";
            string zatvaranjeSati = "SUBSTRING_INDEX(l.radno_vreme, '-', -1)";

            string radnoOd = $"STR_TO_DATE(CONCAT(DATE(rv.pocetak), ' ', {otvaranjeSati}, ':00:00'), '%Y-%m-%d %H:%i:%s')";
            string radnoDo = $"STR_TO_DATE(CONCAT(DATE(rv.kraj), ' ', {zatvaranjeSati}, ':00:00'), '%Y-%m-%d %H:%i:%s')";
            string stvarniPocetak = $@"CASE 
            WHEN rv.pocetak < '{startMeseca}' THEN '{startMeseca}' 
            WHEN rv.pocetak < {radnoOd} THEN {radnoOd}
            ELSE rv.pocetak END";


            string stvarniKraj = $@"CASE 
            WHEN rv.kraj > '{krajMeseca}' THEN '{krajMeseca}' 
            WHEN rv.kraj > {radnoDo} THEN {radnoDo}
            ELSE rv.kraj END";

            string diffMinuta = _adapter.DateDiffMinutesExpr(stvarniPocetak, stvarniKraj);

            string upit = $@"SELECT COALESCE(SUM({diffMinuta}), 0) / 60.0 
                     FROM rezervacija rv
                     JOIN resurs r ON rv.resurs_id = r.resurs_id
                     JOIN lokacija l ON r.lokacija_id = l.lokacija_id
                     WHERE rv.clan_id = {clanId} 
                     AND rv.status != 'Otkazana'
                     AND rv.pocetak < '{krajMeseca}' AND rv.kraj > '{startMeseca}'";

            var result = _adapter.izvrsiUpitSkalar(upit);
            return (result != null && result != DBNull.Value) ? Convert.ToDouble(result) : 0;
        }
    }
}
