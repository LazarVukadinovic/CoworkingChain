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
    internal class SalaZaSastankeRepository : IRepository<SalaZaSastanke>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public SalaZaSastankeRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }
        public void Add(SalaZaSastanke item)
        {
            string upit = $@"
            INSERT INTO sala_detalj (resurs_id, kapacitet, ima_projektor, ima_tv, ima_tablu, ima_online_opremu)
            VALUES (
                {item.resursId},
                {item.kapacitet},
                {Convert.ToInt32(item.imaProjektor)},
                {Convert.ToInt32(item.imaTv)},
                {Convert.ToInt32(item.imaTablu)},
                {Convert.ToInt32(item.imaOpremuZaOnlineSastanke)}
            );";

            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<SalaZaSastanke> GetAll()
        {
            string upit = $@"
            SELECT r.*,s.kapacitet,s.ima_projektor,s.ima_tv,s.ima_tablu,s.ima_online_opremu
            FROM sala_detalj s
            JOIN resurs r on r.resurs_id=s.resurs_id
            ";

            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapSalaZaSastanke);
        }

        public void Update(SalaZaSastanke item)
        {
            string upit = $@"
            UPDATE sala_detalj
            SET 
                resurs_id = {item.resursId},
                kapacitet = {item.kapacitet},
                ima_projektor = {Convert.ToInt32(item.imaProjektor)},
                ima_tv = {Convert.ToInt32(item.imaTv)},
                ima_tablu = {Convert.ToInt32(item.imaTablu)},
                ima_online_opremu = {Convert.ToInt32(item.imaOpremuZaOnlineSastanke)}
            WHERE resurs_id = {item.resursId};";

            _adapter.izvrsiUpitBezRezultata(upit);
        }
        public void Delete(int id)
        {
            string upit = $"DELETE FROM sala_detalj WHERE resurs_id = {id}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }
        public SalaZaSastanke GetById(int resursId)
        {
            string upit = $@"
            SELECT r.*,s.sala_detalj_id,s.kapacitet,s.ima_projektor,s.ima_tv,s.ima_tablu,s.ima_online_opremu
            FROM sala_detalj s
            JOIN resurs r on r.resurs_id=s.resurs_id
            WHERE s.resurs_id={resursId}
            ";

            List<SalaZaSastanke> sala = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapSalaZaSastanke);
            return sala.Count > 0 ? sala[0] : null;
        }

        public List<SalaZaSastanke> GetByName(string name)
        {
            return null;
        }
    }
}
