using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Domain.Enums
{
    public static class ReservationStatusTransformator
    {
        // ToDbString vrsi "mapranje" switch-om koja zapravo vrednost ce se poslati u bazi
        public static string ToDbString(this ReservationStatus status) =>
            status switch
            {
                ReservationStatus.Rezervisana => "Rezervisana",
                ReservationStatus.Potvrdjena => "Potvrdjena",
                ReservationStatus.Otkazana => "Otkazana",
                ReservationStatus.Zavrsena => "Zavrsena",
                _ => throw new ArgumentOutOfRangeException(nameof(status), status, "Greska u statusu rezervacije!")
            };

        // FromDbString vrsi "mapiranje" switch-om vrednosti statusa koje dolaze iz baze
        public static ReservationStatus FromDbString(string dbStatus) =>
            dbStatus switch
            {
                "Rezervisana" => ReservationStatus.Rezervisana,
                "Potvrdjena" => ReservationStatus.Potvrdjena,
                "Otkazana" => ReservationStatus.Otkazana,
                "Zavrsena" => ReservationStatus.Zavrsena,
                _ => throw new ArgumentException($"Nepoznat status u bazi: '{dbStatus}'", nameof(dbStatus))
            };

        // RAZLOG:
        // smanjivanje redudanse stringova u kodu i eliminisanje TYPO greske
    }
}
