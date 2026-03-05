using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Data.Repositories
{
    internal interface IRezervacijaRepository : IRepository<Rezervacija>
    {
        public List<Rezervacija> GetByClanIdAndStatuses(int clanId, List<ReservationStatus> statusi);
        void Cancel(int rezervacijaId);
        public List<Rezervacija> GetReservationsByDateAndLocation(string date, int location);

        public void UpdateStatus(int rezervacijaId, ReservationStatus status);
    }

}
