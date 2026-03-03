using Coworking.Data.Reports;
using Coworking.Data.Providers;

static void Main(string[] args)
{
    PeriodStrategy strategy = new PeriodStrategy(PeriodType.Week1);

    var proxy = DataBaseSingleton.vratiInstancu();
    var report = new CreateReport(proxy);
    var rows = report.GenerateReport(strategy);

    var exporter = new CsvExporter();
    //exporter.ExportToCsv(rows,$"C:\\Reports\\report_{DateTime.Now:yyyy_MM}.csv");
}