using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Chain_Of_Responsibility
{
    internal class ZauzetostResursaValidator : RezervacijaHandler
    {
        public ZauzetostResursaValidator(IDataBase proxy) : base(proxy)
        {
        }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var sveRezervacije = _proxy.prikaziSveRezervacije();
            bool zauzet = sveRezervacije.Any(r => 
                r.resursId == rezervacija.resursId &&
                DateTime.Parse(r.pocetak!) < DateTime.Parse(rezervacija.kraj!) &&
                DateTime.Parse(r.kraj!) > DateTime.Parse(rezervacija.pocetak!) &&
                r.status == "aktivna"
            );

            if (zauzet)
            {
                return ValidationResult.Fail("Resurs vec zauzet u tom terminu.");
            }
            return base.Handle(rezervacija);
        }
    }
}
