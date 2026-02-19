using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal interface IRezervacijaRepository : IRepository<Rezervacija>
    {
        List<Rezervacija> GetByClanId(int clanId);
        void Cancel(int rezervacijaId);
    }

}
