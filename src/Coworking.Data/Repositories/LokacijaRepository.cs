using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using System.Data;

namespace Coworking.Data.Repositories
{
    internal class LokacijaRepository : IRepository<Lokacija>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;
        public LokacijaRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }
        public void Add(Lokacija item)
        {
            string upit = $@"
            INSERT INTO lokacija (naziv, adresa, grad, radno_vreme, max_kapacitet, opis)
            VALUES (
                '{item.naziv}',
                '{item.adresa}',
                '{item.grad}',
                '{item.radnoVreme}',
                '{item.maxKapacitet}',
                '{item.opis}'
            );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        

        public List<Lokacija> GetAllActive(bool check)
        {
            string upit = "SELECT DISTINCT l.* FROM lokacija l";
            if(check)
            {
                upit += $@" JOIN resurs r on r.lokacija_id=l.lokacija_id 
                            JOIN rezervacija rv on rv.resurs_id=r.resurs_id 
                            WHERE rv.status='{ReservationStatus.Rezervisana.ToDbString()}' OR 
                                    rv.status='{ReservationStatus.Potvrdjena.ToDbString()}'";
            }
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
        }

        public List<Lokacija> GetAll()
        {
            string upit = "SELECT * FROM lokacija";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
        }

        public void Update(Lokacija item)
        {
            string upit = $@"
            UPDATE lokacija
            SET 
                naziv = '{item.naziv}',
                adresa = '{item.adresa}',
                grad = '{item.grad}',
                radno_vreme = '{item.radnoVreme}',
                max_kapacitet = '{item.maxKapacitet}',
                opis = '{item.opis}'
            WHERE lokacija_id = {item.lokacijaId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int id)
        {
            string upit = $"DELETE FROM lokacija WHERE lokacija_id = {id};";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Lokacija GetById(int id)
        {
            string upit = $"SELECT * FROM lokacija WHERE lokacija_id = {id};";
            var lokacije = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
            return lokacije.FirstOrDefault();
        }

        public List<Lokacija> GetByName(string name)
        {
            string upit = $"SELECT * FROM lokacija WHERE naziv LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);

        }
        public Lokacija getLokacijaByResursId(int resursId)
        {
            string upit = $@"
                SELECT l.*
                FROM lokacija l
                JOIN resurs r ON r.lokacija_id = l.lokacija_id
                WHERE r.resurs_id = {resursId};";

            var lokacije = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapLokacija);
            return lokacije.FirstOrDefault();
        }

        public List<StatistikaLokacijeDTO> GetTrenutnaStatistika()
        {
            // Koristimo tvoj adapter da dobijemo pravu funkciju za vreme (NOW ili GETDATE)
            string nowFunc = _adapter.NowExpr();

            string sql = $@"
        SELECT 
            l.lokacija_id, 
            MAX(l.naziv) AS NazivLokacije, 
            COUNT(DISTINCT r.resurs_id) AS UkupnoResursa,
            COUNT(DISTINCT CASE 
                WHEN rez.status IN ('Rezervisana', 'Potvrdjena') 
                AND {nowFunc} BETWEEN rez.pocetak AND rez.kraj
                THEN r.resurs_id 
            END) AS TrenutnoZauzetih
        FROM lokacija l
        LEFT JOIN resurs r ON l.lokacija_id = r.lokacija_id
        LEFT JOIN rezervacija rez ON r.resurs_id = rez.resurs_id
        GROUP BY l.lokacija_id";

            DataTable dt = _adapter.izvrsiUpit(sql);
            var rezultati = new List<StatistikaLokacijeDTO>();

            foreach (DataRow row in dt.Rows)
            {
                int ukupno = Convert.ToInt32(row["UkupnoResursa"]);
                int zauzeto = Convert.ToInt32(row["TrenutnoZauzetih"]);

                rezultati.Add(new StatistikaLokacijeDTO
                {
                    LokacijaId = Convert.ToInt32(row["lokacija_id"]),
                    Naziv = row["NazivLokacije"].ToString(),
                    UkupnoResursa = ukupno,
                    ZauzetihResursa = zauzeto,
                    ProcenatZauzetosti = ukupno == 0 ? 0 : Math.Round((double)zauzeto / ukupno * 100, 2)
                });
            }
            return rezultati;
        }
    }

    public class StatistikaLokacijeDTO
    {
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public int UkupnoResursa { get; set; }
        public int ZauzetihResursa { get; set; }
        public double ProcenatZauzetosti { get; set; }

        // Opciono: Dodajemo opisni status koji možeš direktno vezati za labelu u GUI-ju
        public string StatusOpis => $"{ZauzetihResursa} / {UkupnoResursa} zauzeto ({ProcenatZauzetosti}%)";
    }
}
