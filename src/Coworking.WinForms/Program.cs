using Coworking.Data.Providers;

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

            Application.Run(new Form1());
        }
    }
}