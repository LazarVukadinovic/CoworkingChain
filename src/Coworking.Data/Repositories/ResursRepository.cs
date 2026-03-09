using Coworking.Data.Providers;
using Coworking.Domain.Entities;

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
                {item.lokacijaId},
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

        //public List<Resurs> GetResourcesByLocation(int? locationId, string name)
        //{
        //    string upit = $@"
        //    SELECT r.*
        //    FROM resurs r
        //    WHERE r.lokacija_id = {locationId}
        //    AND r.tip_resursa = '{name}'";
        //    return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        //}

        public List<Resurs> GetResourcesByLocation(int? locationId, string? name)
        {
            var uslovi = new List<string>();

            if (locationId.HasValue)
                uslovi.Add($"r.lokacija_id = {locationId.Value}");

            if (!string.IsNullOrEmpty(name))
                uslovi.Add($"r.tip_resursa = '{name}'");

            string where = uslovi.Count > 0 ? "WHERE " + string.Join(" AND ", uslovi) : "";

            string upit = $"SELECT r.* FROM resurs r {where}";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        }

        public void Update(Resurs item)
        {
            string upit = $@"
            UPDATE resurs
            SET 
                lokacija_id = {item.lokacijaId},
                oznaka = '{item.oznaka}',
                tip_resursa = '{item.tipResursa}',
                opis = '{item.opis}'
            WHERE resurs_id = {item.resursId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int id)
        {
            string upit = $"DELETE FROM resurs WHERE resurs_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Resurs GetById(int id)
        {
            string upit = $"SELECT * FROM resurs WHERE resurs_id = {id}";
            List<Resurs> resursi = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
            return resursi.Count > 0 ? resursi[0] : null;

            //if (resursi.Count == 0) throw new KeyNotFoundException($"Resurs sa id={id} ne postoji.");
            //return resursi[0];
        }

        public List<Resurs> GetByName(string name)
        {
            string upit = $"SELECT * FROM resurs WHERE oznaka LIKE '%{name.Trim()}%'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
        }

        public Resurs giveLastAddedResource()
        {
            string limitExpr = _adapter.LimitOneExpr("resurs_id");
            string upit = $@"
            SELECT *
            FROM resurs
            {limitExpr};";

            List<Resurs> resursi = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapResurs);
            return resursi.Count > 0 ? resursi[0] : null;
        }
    }
}
