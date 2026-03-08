using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System.Data;

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
            string telefonVal = item.brTelefona == null ? "NULL" : $"'{item.brTelefona}'";

            string upit = $@"
            INSERT INTO clan (ime, prezime, email, telefon, datum_pocetka, datum_kraja, status_naloga, tip_clanstva_id, kreiran_u)
            VALUES (
                '{item.ime}',
                '{item.prezime}',
                '{item.mail}',
                {telefonVal},
                '{item.datumPocetka}',
                '{item.datumKraja}',
                '{item.statusNaloga}',
                {item.tipClanstva},
                '{item.kreiran}'
            );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int clanId)
        {
            string upit = $@"
            DELETE FROM clan
            WHERE clan_id = {clanId};
            ";

            _adapter.izvrsiUpitBezRezultata(upit);
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
            string upit = $"SELECT * FROM clan WHERE ime LIKE '%{name.Trim()}%'";
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
                                    rv.status IN ('Rezervisana', 'Potvrdjena')";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }

        public List<RezervacijaSaLokacijom> GetReservationDetailsForMonth(int clanId)
        {
            DateTime sada = DateTime.Now;
            string start = new DateTime(sada.Year, sada.Month, 1).ToString("yyyy-MM-dd 00:00:00");
            string kraj = new DateTime(sada.Year, sada.Month, 1).AddMonths(1).ToString("yyyy-MM-dd 00:00:00");

            string upit = $@"
                SELECT rv.*, l.radno_vreme 
                FROM rezervacija rv
                JOIN resurs r ON rv.resurs_id = r.resurs_id
                JOIN lokacija l ON r.lokacija_id = l.lokacija_id
                WHERE rv.clan_id = {clanId} 
                AND rv.status != 'Otkazana'
                AND rv.pocetak < '{kraj}' AND rv.kraj > '{start}'";

            DataTable dt = _adapter.izvrsiUpit(upit);

            var lista = new List<RezervacijaSaLokacijom>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new RezervacijaSaLokacijom
                {
                    PodaciRezervacije = _mapper.mapRezervacija(row), // Koristi tvoj postojeći mapper
                    RadnoVreme = row["radno_vreme"].ToString()
                });
            }
            return lista;
        }

        // OPTIMIZOVANO
        public List<Clan> GetFiltrirano(int? lokacijaId, int? tipClanstvaId, string? status)
        {
            string upit = "SELECT DISTINCT c.* FROM clan c";

            var uslovi = new List<string>();

            if (lokacijaId.HasValue)
            {
                upit += @" JOIN resurs r ON r.lokacija_id = r.lokacija_id
                   JOIN rezervacija rv ON rv.resurs_id = r.resurs_id
                     AND rv.clan_id = c.clan_id";
                uslovi.Add($"r.lokacija_id = {lokacijaId.Value}");
            }

            if (tipClanstvaId.HasValue)
                uslovi.Add($"c.tip_clanstva_id = {tipClanstvaId.Value}");

            if (!string.IsNullOrEmpty(status))
                uslovi.Add($"c.status_naloga = '{status}'");

            if (uslovi.Count > 0)
                upit += " WHERE " + string.Join(" AND ", uslovi);

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapClan);
        }
    }

    public class RezervacijaSaLokacijom
    {
        public Rezervacija PodaciRezervacije { get; set; }
        public string RadnoVreme { get; set; }
    }
}
