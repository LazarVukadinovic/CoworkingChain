using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal class RadnoMestoRepository : IRepository<RadnoMesto>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public RadnoMestoRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }
        public void Add(RadnoMesto item)
        {
            string upit = $@"
            INSERT INTO radno_mesto_detalj (resurs_id, podtip)
            VALUES (
                '{item.resursId}',
                '{item.podtip}'
            );";

            _adapter.izvrsiUpitBezRezultata(upit);

        }

        public List<RadnoMesto> GetAll()
        {
            string upit = $@"
            SELECT r.*,rad.podtip
            FROM radno_mesto_detalj rad
            JOIN resurs r on r.resurs_id=rad.resurs_id
            ";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRadnoMesto);
        }

        public void Update(RadnoMesto item)
        {
            string upit = $@"
            UPDATE radno_mesto_detalj
            SET 
                resurs_id = '{item.resursId}',
                podtip = '{item.podtip}'
            WHERE resurs_id = {item.resursId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }
        public void Delete(int id)
        {
            string upit = $"DELETE FROM radno_mesto_detalj WHERE resurs_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public RadnoMesto GetById(int resursId)
        {
            string upit = $@"
            SELECT r.*,rad.podtip
            FROM radno_mesto_detalj rad
            JOIN resurs r on r.resurs_id=rad.resurs_id
            WHERE rad.resurs_id={resursId}
            ";

            List<RadnoMesto> radnoMesto = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRadnoMesto);
            return radnoMesto.Count > 0 ? radnoMesto[0] : null;
        }

        public List<RadnoMesto> GetByName(string name)
        {
            return null;
        }
        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
            string now = _adapter.NowExpr();
            string upit = $@"
            SELECT r.*,rmd.podtip, 
                CASE 
                    WHEN rv.pocetak<{now} AND rv.kraj>{now} and rv.status!='{ReservationStatus.Otkazana.ToDbString()}'
                    THEN 'Zauzeto'
                    ELSE 'Dostupno'
                END AS dostupnost
            FROM radno_mesto_detalj rmd
            JOIN resurs r on rmd.resurs_id=r.resurs_id
            JOIN rezervacija rv on rv.resurs_id=r.resurs_id
            WHERE r.lokacija_id = {lokacijaId}";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRadnoMesto);
        }
    }
}
