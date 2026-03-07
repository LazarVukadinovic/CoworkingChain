namespace Coworking.Domain.Enums
{
    public static class PodtipRadnogMestaTransformator
    {
        // ToDbString vrsi "mapranje" switch-om koja zapravo vrednost ce se poslati u bazi
        public static string ToDbString(this PodtipRadnogMesta podtip) =>
            podtip switch
            {
                PodtipRadnogMesta.private_office => "Private office",
                PodtipRadnogMesta.hot_desk => "Hot desk",
                PodtipRadnogMesta.dedicated_desk => "Dedicated desk",
                _ => throw new ArgumentOutOfRangeException(nameof(podtip), podtip, "Greska u podtipu!")
            };

        // FromDbString vrsi "mapiranje" switch-om vrednosti podtipa koje dolaze iz baze
        public static PodtipRadnogMesta FromDbString(string? dbStatus) =>
            dbStatus switch
            {
                "Private office" => PodtipRadnogMesta.private_office,
                "Hot desk" => PodtipRadnogMesta.hot_desk,
                "Dedicated desk" => PodtipRadnogMesta.dedicated_desk,
                _ => throw new ArgumentException($"Nepoznat status u bazi: '{dbStatus}'", nameof(dbStatus))
            };

        // RAZLOG:
        // smanjivanje redudanse stringova u kodu i eliminisanje TYPO greske
    }
}
