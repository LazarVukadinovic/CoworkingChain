using Coworking.Data.Providers;
using Coworking.Data.Reports;
using Microsoft.Extensions.Hosting;

namespace Coworking.ReportService
{
    public class Worker : BackgroundService
    {
        private readonly IDataBase _db;

        public Worker()
        {
            try
            {
                _db = DataBaseSingleton.vratiInstancu();
            }
            catch (Exception ex)
            {
                string logPath = Path.Combine(AppContext.BaseDirectory, "service.log");
                File.AppendAllText(logPath, $"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - Greska pri inicijalizaciji baze: {ex.Message}\n");
                throw;
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var ciklusPocetak = DateTime.Now;
                try
                {
                    var config = UcitajKonfiguraciju();
                    var strategy = new PeriodStrategy(config.periodType);
                    var rows = new CreateReport(_db).GenerateReport(strategy);

                    string fileName = $"report_{DateTime.Now:yyyy_MM_dd_HH_mm}.csv";
                    string fullPath = Path.Combine(config.outputFolder, fileName);

                    new CsvExporter().ExportToCsv(rows, fullPath);

                    LogInfo($"Izvestaj generisan: {fullPath}");

                    var elapsed = DateTime.Now - ciklusPocetak;
                    var remaining = config.interval - elapsed;
                    if (remaining > TimeSpan.Zero)
                        await Task.Delay(remaining, stoppingToken);
                }
                catch (Exception ex)
                {
                    LogError(ex.Message);

                    var elapsed = DateTime.Now - ciklusPocetak;
                    var remaining = TimeSpan.FromMinutes(1) - elapsed;
                    if (remaining > TimeSpan.Zero)
                        await Task.Delay(remaining, stoppingToken);
                }
            }
        }

        private ServiceConfig UcitajKonfiguraciju()
        {
            string configPath = Path.Combine(AppContext.BaseDirectory, "service_config.txt");

            if (!File.Exists(configPath))
                throw new FileNotFoundException($"Nije pronadjen service_config.txt na putanji: {configPath}");

            var lines = File.ReadAllLines(configPath)
                            .Where(l => !string.IsNullOrWhiteSpace(l) && !l.StartsWith("#"))
                            .ToArray();

            // Format:
            // lines[0] = Interval     (npr. Hour1)  - na koliko se generise izvestaj
            // lines[1] = PeriodType   (npr. Month1) - koliko unazad izvestaj pokriva
            // lines[2] = OutputFolder (npr. C:\Reports)

            if (lines.Length < 3)
                throw new InvalidOperationException("service_config.txt mora imati 3 linije: Interval, PeriodType i OutputFolder");

            var intervalType = Enum.Parse<PeriodType>(lines[0].Trim());
            var periodType = Enum.Parse<PeriodType>(lines[1].Trim());
            string outputFolder = lines[2].Trim();

            TimeSpan interval = intervalType switch
            {
                PeriodType.Min5 => TimeSpan.FromMinutes(5),
                PeriodType.Hour1 => TimeSpan.FromHours(1),
                PeriodType.Hour5 => TimeSpan.FromHours(5),
                PeriodType.Day1 => TimeSpan.FromDays(1),
                PeriodType.Week1 => TimeSpan.FromDays(7),
                PeriodType.Month1 => TimeSpan.FromDays(30),
                PeriodType.Month3 => TimeSpan.FromDays(90),
                PeriodType.Month6 => TimeSpan.FromDays(180),
                PeriodType.Year1 => TimeSpan.FromDays(365),
                _ => TimeSpan.FromHours(1)
            };

            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            return new ServiceConfig(periodType, interval, outputFolder);
        }

        private void LogInfo(string message)
        {
            string logPath = Path.Combine(AppContext.BaseDirectory, "service.log");
            File.AppendAllText(logPath, $"[INFO]  {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}\n");
        }

        private void LogError(string message)
        {
            string logPath = Path.Combine(AppContext.BaseDirectory, "service.log");
            File.AppendAllText(logPath, $"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}\n");
        }
    }

    internal record ServiceConfig(PeriodType periodType, TimeSpan interval, string outputFolder);
}