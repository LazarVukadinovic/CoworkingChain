using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

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

        public List<Resurs> GetResourcesByLocation(int? locationId, string name)
        {
            string upit = $@"
            SELECT r.*
            FROM resurs r
            WHERE r.lokacija_id = {locationId}
            AND r.tip_resursa = {name}";
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
