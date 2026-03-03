using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Chain_Of_Responsibility
{
    internal class LimitSatiClanValidator : RezervacijaHandler
    {
        public LimitSatiClanValidator(IDataBase proxy) : base(proxy)
        {
        }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var clan = _proxy.prikaziClanove().FirstOrDefault(c => c.clanId == rezervacija.clanId);
            if(clan == null) return ValidationResult.Fail("Nepostojeci clan.");

            var tipClanstva = _proxy.prikaziSveTipoveClanstva().FirstOrDefault(t => t.tipClanstvaId == clan.tipClanstva);
            if (tipClanstva == null) return ValidationResult.Fail("Nepostojeci tip clanstva");

            // TO DO

            bool prekoracenLimit = false;

            if (prekoracenLimit)
            {
                return ValidationResult.Fail("Korisnik je prekoracio dozvoljeni broj sati rezervacija.");
            }
            return base.Handle(rezervacija);
        }
    }
}
