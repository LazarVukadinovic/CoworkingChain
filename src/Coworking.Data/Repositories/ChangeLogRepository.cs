using Coworking.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    //proveriti da li ovde treba da se nasledi IRepository(ako treba onda mora da se napravi obicna klasa za change(moze biti EntityChange))
    internal class ChangeLogRepository : IRepository<EntityChange>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;
        public ChangeLogRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }

        public List<EntityChange> GetChangesAfter(DateTime lastCheck)
        {
            string upit = $@"SELECT entity_name, change_time
                            FROM change_log
                            WHERE change_time > '{lastCheck}'";
            return _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapEntity);
        }

        //-------------------------------------------------------------------------------------
        //ovo dole je nepotrebno

        public void Add(EntityChange item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityChange> GetAll()
        {
            throw new NotImplementedException();
        }

        public EntityChange GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityChange> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityChange item)
        {
            throw new NotImplementedException();
        }
    }
}
