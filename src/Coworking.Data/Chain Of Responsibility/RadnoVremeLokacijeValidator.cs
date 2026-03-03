using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Chain_Of_Responsibility
{
    internal class RadnoVremeLokacijeValidator : RezervacijaHandler
    {
        public RadnoVremeLokacijeValidator(IDataBase proxy) : base(proxy)
        {
        }

        public override ValidationResult Handle(Rezervacija rezervacija)
        {
            var resurs = _proxy.prikaziSveResurse().FirstOrDefault(r => r.resursId == rezervacija.resursId);
            if (resurs == null) return ValidationResult.Fail("Nepostojeci resurs.");

            var lokacija = _proxy.prikaziLokacije(false).FirstOrDefault(l => l.lokacijaId == resurs.lokacijaId);
            if (lokacija == null) return ValidationResult.Fail("Nepostojeca lokacija.");

            var parts = lokacija.radnoVreme!.Split('-');
            TimeSpan lokacijaOd = TimeSpan.Parse(parts[0]);
            TimeSpan lokacijaDo = TimeSpan.Parse(parts[1]);

            TimeSpan rezervacijaOd = DateTime.Parse(rezervacija.pocetak!).TimeOfDay;
            TimeSpan rezervacijaDo = DateTime.Parse(rezervacija.kraj!).TimeOfDay;

            bool vanRadnogVremena = rezervacijaOd < lokacijaOd || rezervacijaDo > lokacijaDo;

            if (vanRadnogVremena)
            {
                return ValidationResult.Fail("Lokacija ne radi u to vreme.");
            }
            return base.Handle(rezervacija);
        }
    }
}
