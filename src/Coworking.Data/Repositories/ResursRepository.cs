using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Coworking.Data.Repositories
{
    internal class ResursRepository : IRepository<Resurs>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public ResursRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }
        public void Add(Resurs item)
        {
            string upit = $@"
            INSERT INTO resurs (lokacija_id, oznaka, tip_resursa, opis)
            VALUES (
                '{item.lokacijaId}',
                '{item.oznaka}',
                '{item.tipResursa}',
                '{item.opis}'
            );";

            _adapter.izvrsiUpitBezRezultata(upit);

        }

        public List<Resurs> GetAll()
        {
            string upit = "SELECT * FROM resurs";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        }

        public List<Resurs> GetResourcesByLocation(int locationId)
        {
            string upit = $@"
            SELECT r.*
            FROM resurs r
            WHERE r.lokacija_id = {locationId}
            ORDER BY r.tip_resursa";


            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        }

        public void Update(Resurs item)
        {
            string upit = $@"
            UPDATE resurs
            SET 
                lokacija_id = '{item.lokacijaId}',
                oznaka = '{item.oznaka}',
                tip_resursa = '{item.tipResursa}',
                opis = '{item.opis}'
            WHERE resurs_id = {item.resursId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
            string upit = $@"
            SELECT r.*,rmd.podtip CASE 
                WHEN rv.pocetak<SYSDATETIME() AND rv.kraj>SYSDATETIME() and rv.status!='Otkazan' THEN 'Zauzeto'
                ELSE 'Dostupno'
                END AS dostupnost
            FROM radno_mesto_detalj rmd
            JOIN resurs r on rmd.resurs_id=r.resurs_id
            JOIN rezervacija rv on rv.resurs_id=r.resurs_id
            WHERE r.lokacija_id = {lokacijaId}";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapRadnoMesto);
        }

        public List<SalaZaSastanke> prikaziSaleZaSastanke()
        {
            string upit = $@"
            SELECT r.*,s.sala_id,s.kapacitet,s.ima_projektor,s.ima_tv,s.ima_tablu,s.ima_online_opremu
            FROM sala_detalj s
            JOIN resurs r on r.resurs_id=s.resurs_id";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapSalaZaSastanke);
        }

        public void Delete(int id)
        {
            string upit = $"DeleTE FROM resurs WHERE resurs_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Resurs GetById(int id)
        {
            string upit = $"SELECT * FROM resurs WHERE resurs_id = {id}";
            List<Resurs> resursi = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
            return resursi.Count > 0 ? resursi[0] : null;
        }

        public List<Resurs> GetByName(string name)
        {
            string upit = $"SELECT * FROM resurs WHERE oznaka LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        }
    }
}
