using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal interface IRezervacijaRepository : IRepository<Rezervacija>
    {
        List<Rezervacija> GetByClanId(int clanId);
        void Cancel(int rezervacijaId);
        public List<Rezervacija> GetReservationsByDateAndLocation(string date, string location);

        public void UpdateStatus(int rezervacijaId, string status);
    }

}
