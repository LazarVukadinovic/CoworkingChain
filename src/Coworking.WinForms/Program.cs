using Coworking.Data.Providers;
using Coworking.Data.Reports;

namespace Coworking.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configPath = Path.Combine(AppContext.BaseDirectory, "config.txt");
            var lines = File.ReadAllLines(configPath);
            var targetCs = lines[1];

            // folder migracije kod exe fajla
            var migrationsBase = Path.Combine(AppContext.BaseDirectory, "migrations");

            // izvrsavanje migracija
            Data.Migrations.MigrationBootstrapper.EnsureDbAndMigrate(targetCs, migrationsBase);

            // izvrsavanje izvestaja
            //IDataBase dbSettings = DataBaseSingleton.vratiInstancu();
            //var reportCreator = new CreateReport(dbSettings);

            //var strategy = new PeriodStrategy(PeriodType.Day1);
            //var rows = reportCreator.GenerateReport(strategy);

            //var exporter = new CsvExporter();
            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\izvestaj.csv";
            //exporter.ExportToCsv(rows, filePath);

            //MessageBox.Show($"CSV izveštaj je napravljen: {filePath}");

            Application.Run(new LoginForm());
        }
    }
}