using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Data.Chain_Of_Responsibility
{
    public class LimitSatiClanValidator : RezervacijaHandler
    {
        public LimitSatiClanValidator(IDataBase proxy) : base(proxy)
        {
        }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var clan = _proxy.prikaziClanove().FirstOrDefault(c => c.clanId == rezervacija.clanId);
            if (clan == null) return ValidationResult.Fail("Nepostojeci clan.");

            var tipClanstva = _proxy.prikaziSveTipoveClanstva().FirstOrDefault(t => t.tipClanstvaId == clan.tipClanstva);
            if (tipClanstva == null) return ValidationResult.Fail("Nepostojeci tip clanstva.");

            if (!tipClanstva.maxSatiRezervacijeMesecno.HasValue)
                return base.Handle(rezervacija);

            // Izracunaj sate vec utrosene ovog meseca
            int trenutniMesec = DateTime.Now.Month;
            int trenutnaGodina = DateTime.Now.Year;

            double satiUtroseni = _proxy.prikaziSveRezervacije()
                .Where(r =>
                    r.clanId == clan.clanId &&
                    r.rezervacijaId != rezervacija.rezervacijaId && // iskljuci sebe pri izmeni
                    (r.status == ReservationStatus.Rezervisana ||
                     r.status == ReservationStatus.Potvrdjena ||
                     r.status == ReservationStatus.Zavrsena) &&
                    DateTime.TryParse(r.pocetak, out DateTime p) &&
                    p.Month == trenutniMesec && p.Year == trenutnaGodina)
                .Sum(r =>
                {
                    if (!DateTime.TryParse(r.pocetak, out DateTime poc)) return 0;
                    if (!DateTime.TryParse(r.kraj, out DateTime kr)) return 0;
                    return (kr - poc).TotalHours;
                });

            // Izracunaj sate nove rezervacije
            if (!DateTime.TryParse(rezervacija.pocetak, out DateTime novaPoc))
                return ValidationResult.Fail("Neispravan format pocetka rezervacije.");
            if (!DateTime.TryParse(rezervacija.kraj, out DateTime novaKr))
                return ValidationResult.Fail("Neispravan format kraja rezervacije.");

            double satiNoveRezervacije = (novaKr - novaPoc).TotalHours;

            bool prekoracenLimit = (satiUtroseni + satiNoveRezervacije) > tipClanstva.maxSatiRezervacijeMesecno.Value;

            if (prekoracenLimit)
                return ValidationResult.Fail(
                    $"Prekoracen mesecni limit od {tipClanstva.maxSatiRezervacijeMesecno} sati. " +
                    $"Utroseno: {Math.Round(satiUtroseni, 1)}h, " +
                    $"Nova rezervacija: {Math.Round(satiNoveRezervacije, 1)}h.");

            return base.Handle(rezervacija);
        }
    }
}
