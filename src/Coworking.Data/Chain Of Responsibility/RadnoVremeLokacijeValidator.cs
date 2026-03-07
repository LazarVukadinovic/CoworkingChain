using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.Data.Chain_Of_Responsibility
{
    public class RadnoVremeLokacijeValidator : RezervacijaHandler
    {
        public RadnoVremeLokacijeValidator(IDataBase proxy) : base(proxy)
        {
        }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            //var resurs = _proxy.prikaziSveResurse().FirstOrDefault(r => r.resursId == rezervacija.resursId);
            //if (resurs == null) return ValidationResult.Fail("Nepostojeci resurs.");

            //var lokacija = _proxy.prikaziLokacije(false).FirstOrDefault(l => l.lokacijaId == resurs.lokacijaId);
            //if (lokacija == null) return ValidationResult.Fail("Nepostojeca lokacija.");

            //var parts = lokacija.radnoVreme!.Split('-');
            //TimeSpan lokacijaOd = TimeSpan.Parse(parts[0]);
            //TimeSpan lokacijaDo = TimeSpan.Parse(parts[1]);

            //TimeSpan rezervacijaOd = DateTime.Parse(rezervacija.pocetak!).TimeOfDay;
            //TimeSpan rezervacijaDo = DateTime.Parse(rezervacija.kraj!).TimeOfDay;

            //bool vanRadnogVremena = rezervacijaOd < lokacijaOd || rezervacijaDo > lokacijaDo;

            //if (vanRadnogVremena)
            //{
            //    return ValidationResult.Fail("Lokacija ne radi u to vreme.");
            //}
            //return base.Handle(rezervacija);

            var resurs = _proxy.prikaziSveResurse().FirstOrDefault(r => r.resursId == rezervacija.resursId);
            if (resurs == null) return ValidationResult.Fail("Nepostojeci resurs.");

            var lokacija = _proxy.prikaziLokacije(false).FirstOrDefault(l => l.lokacijaId == resurs.lokacijaId);
            if (lokacija == null) return ValidationResult.Fail("Nepostojeca lokacija.");

            if (string.IsNullOrWhiteSpace(lokacija.radnoVreme))
                return ValidationResult.Fail("Lokacija nema definisano radno vreme.");

            var parts = lokacija.radnoVreme.Split('-');
            if (parts.Length != 2)
                return ValidationResult.Fail("Neispravan format radnog vremena lokacije.");

            if (!TimeSpan.TryParse(parts[0].Trim(), out TimeSpan lokacijaOd))
                return ValidationResult.Fail("Neispravan format pocetka radnog vremena.");

            if (!TimeSpan.TryParse(parts[1].Trim(), out TimeSpan lokacijaDo))
                return ValidationResult.Fail("Neispravan format kraja radnog vremena.");

            if (!DateTime.TryParse(rezervacija.pocetak, out DateTime rezervacijaPocetak))
                return ValidationResult.Fail("Neispravan format pocetka rezervacije.");

            if (!DateTime.TryParse(rezervacija.kraj, out DateTime rezervacijaKraj))
                return ValidationResult.Fail("Neispravan format kraja rezervacije.");

            TimeSpan rezervacijaOd = rezervacijaPocetak.TimeOfDay;
            TimeSpan rezervacijaDo = rezervacijaKraj.TimeOfDay;

            bool vanRadnogVremena = rezervacijaOd < lokacijaOd || rezervacijaDo > lokacijaDo;

            if (vanRadnogVremena)
                return ValidationResult.Fail("Lokacija ne radi u to vreme.");

            return base.Handle(rezervacija);
        }
    }
}
