using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal interface ITipClanstvaRepository : IRepository<TipClanstva>
    {
        TipClanstva GetById(int id);
        List<TipClanstva> GetByName(string name);
    }
}
