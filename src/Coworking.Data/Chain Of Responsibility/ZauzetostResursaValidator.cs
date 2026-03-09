using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Data.Chain_Of_Responsibility
{
    public class ZauzetostResursaValidator : RezervacijaHandler
    {
        public ZauzetostResursaValidator(IDataBase proxy) : base(proxy)
        { }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var sveRezervacije = _proxy.prikaziSveRezervacije();
            bool zauzet = sveRezervacije.Any(r => 
                r.rezervacijaId != rezervacija.rezervacijaId &&
                r.resursId == rezervacija.resursId &&
                DateTime.Parse(r.pocetak!) < DateTime.Parse(rezervacija.kraj!) &&
                DateTime.Parse(r.kraj!) > DateTime.Parse(rezervacija.pocetak!) &&
                (r.status == ReservationStatus.Rezervisana || 
                r.status == ReservationStatus.Potvrdjena)
            );

            if (zauzet)
            {
                return ValidationResult.Fail("Resurs vec zauzet u tom terminu.");
            }
            return base.Handle(rezervacija);
        }
    }
}
