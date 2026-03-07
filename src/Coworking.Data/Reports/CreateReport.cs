using Coworking.Data.Providers;

namespace Coworking.Data.Reports
{
    public class CreateReport
    {
        private readonly IDataBase _proxy;

        public CreateReport(IDataBase proxy)
        {
            _proxy = proxy;
        }

        public List<ReportRow> GenerateReport(PeriodStrategy strategy)
        {
            DateTime start = strategy.GetStartDate();
            DateTime end = DateTime.Now;

            var reportRows = new List<ReportRow>();
            var allClanovi = _proxy.prikaziClanove();
            var sviResursi = _proxy.prikaziSveResurse();
            var sveRezervacije = _proxy.prikaziSveRezervacije();
            var sviTipovi = _proxy.prikaziSveTipoveClanstva();

            foreach (var clan in allClanovi)
            {
                var rezervacije = sveRezervacije
                    .Where(r =>
                        r.clanId == clan.clanId &&
                        DateTime.TryParse(r.pocetak, out DateTime p) &&
                        DateTime.TryParse(r.kraj, out DateTime k) &&
                        p >= start && k <= end)
                    .ToList();

                foreach (var rez in rezervacije)
                {
                    var resurs = sviResursi.FirstOrDefault(r => r.resursId == rez.resursId);
                    if (resurs == null) continue;

                    if (!DateTime.TryParse(rez.pocetak, out DateTime poc)) continue;
                    if (!DateTime.TryParse(rez.kraj, out DateTime kr)) continue;
                    double sati = (kr - poc).TotalHours;

                    reportRows.Add(new ReportRow
                    {
                        ClanId = clan.clanId,
                        Ime = clan.ime ?? "",
                        Prezime = clan.prezime ?? "",
                        TipClanstva = clan.tipClanstva.ToString() ?? "",
                        NazivTipaClanstva = sviTipovi.FirstOrDefault(t => t.tipClanstvaId == clan.tipClanstva)?.naziv ?? "", // ← dodato
                        SatiKorisnik = Math.Round(sati, 2),
                        ResursId = resurs.resursId,
                        NazivResursa = resurs.oznaka ?? "",
                        TipResursa = resurs.tipResursa ?? ""
                    });
                }
            }

            return reportRows;
        }
    }
}
