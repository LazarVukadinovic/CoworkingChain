using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.Data.Chain_Of_Responsibility
{
    public class LimitSatiClanValidator : RezervacijaHandler
    {
        public LimitSatiClanValidator(IDataBase proxy) : base(proxy)
        { }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var clan = _proxy.prikaziClanove().FirstOrDefault(c => c.clanId == rezervacija.clanId);
            if (clan == null) return ValidationResult.Fail("Nepostojeći član.");

            var tipClanstva = _proxy.prikaziSveTipoveClanstva().FirstOrDefault(t => t.tipClanstvaId == clan.tipClanstva);
            if (tipClanstva == null) return ValidationResult.Fail("Nepostojeći tip članstva.");

            if (!tipClanstva.maxSatiRezervacijeMesecno.HasValue)
                return base.Handle(rezervacija);

            double satiUtroseni = _proxy.vratiUkupneSateSalaZaClana(clan.clanId);

            if (!DateTime.TryParse(rezervacija.pocetak, out DateTime novaPoc))
                return ValidationResult.Fail("Neispravan format početka.");
            if (!DateTime.TryParse(rezervacija.kraj, out DateTime novaKr))
                return ValidationResult.Fail("Neispravan format kraja.");

            double satiNoveRezervacije = (novaKr - novaPoc).TotalHours;

            if ((satiUtroseni + satiNoveRezervacije) > tipClanstva.maxSatiRezervacijeMesecno.Value)
            {
                return ValidationResult.Fail(
                    $"Prekoračen mesečni limit od {tipClanstva.maxSatiRezervacijeMesecno} sati. " +
                    $"Već rezervisano (sa radnim vremenom): {Math.Round(satiUtroseni, 1)}h");
            }

            return base.Handle(rezervacija);
        }
    }
}
