using Coworking.Data.Reports;
using Coworking.Data.Providers;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        PeriodStrategy strategy = new PeriodStrategy(PeriodType.Week1);

        var proxy = DataBaseSingleton.vratiInstancu();
        var report = new CreateReport(proxy);
        var rows = report.GenerateReport(strategy);

        var exporter = new CsvExporter();

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = $"report_{DateTime.Now:yyyy_MM}.csv";
        string fullPath = Path.Combine(desktopPath, fileName);

        exporter.ExportToCsv(rows, fullPath);
    }
}