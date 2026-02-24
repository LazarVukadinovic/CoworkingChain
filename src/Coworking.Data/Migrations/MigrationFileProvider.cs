using System.Text.RegularExpressions;

namespace Coworking.Data.Migrations
{
    internal static class MigrationFileProvider
    {
        private static readonly Regex Rx = new(@"^\d{3}_.+\.sql$", RegexOptions.IgnoreCase);

        public static List<string> DajMigracioneFajlove(string folderPath)
        {
            return Directory.GetFiles(folderPath, "*.sql", SearchOption.TopDirectoryOnly)
                .Where(f => Rx.IsMatch(Path.GetFileName(f)))
                .OrderBy(f => Path.GetFileName(f))
                .ToList();
        }
    }
}
