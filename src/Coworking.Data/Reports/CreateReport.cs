using Coworking.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Reports
{
    public class CreateReport
    {
        private readonly IDataBase _proxy;

        public CreateReport(IDataBase proxy)
        {
            _proxy = proxy;
        }

        //public List<ReportRow> GenerateReport(PeriodStrategy strategy)
        //{
        //    //DateTime start = strategy.GetStartDate();
        //    //DateTime end = DateTime.Now;

        //    //var reportRows = new List<ReportRow>();
        //    //var allClanovi = _proxy.prikaziClanove();

        //    //foreach (var clan in allClanovi)
        //    //{
        //    //    var rezervacije = _proxy.prikaziRezervacijeSaStatusomZaIzabranogClana(clan.clanId)
        //    //                        //.Where(r => DateTime.Parse(r.pocetak) >= start &&
        //    //                        //            DateTime.Parse(r.kraj) <= end)
        //    //                        .ToList();

        //    //    foreach (var rez in rezervacije)
        //    //    {
        //    //        var resurs = _proxy.prikaziSveResurse().FirstOrDefault(r => r.resursId == rez.resursId);

        //    //        double sati = (DateTime.Parse(rez.kraj) - DateTime.Parse(rez.pocetak)).TotalHours;

        //    //        reportRows.Add(new ReportRow
        //    //        {
        //    //            ClanId = clan.clanId,
        //    //            Ime = clan.ime,
        //    //            Prezime = clan.prezime,
        //    //            TipClanstva = clan.tipClanstva.ToString(),
        //    //            SatiKorisnik = sati,
        //    //            ResursId = resurs.resursId,
        //    //            NazivResursa = resurs.oznaka,
        //    //            TipResursa = resurs.tipResursa
        //    //        });
        //    //    }
        //    //}

        //    //return reportRows;
        //}
    }
}
