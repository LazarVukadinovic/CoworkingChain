namespace Coworking.Data.Providers
{
    public class DBSettings
    {
        public DataBaseAdapter Adapter { get; }
        public DataBaseMapper Mapper { get; }

        public string ApplicationName { get; }
        public DBSettings()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            var konekcioniString = File.ReadAllLines(path)[1];
            ApplicationName = File.ReadAllLines(path)[0];

            var factory = DataBaseFactory.vratiFactory(konekcioniString);

            Adapter = new DataBaseAdapter(factory, konekcioniString);
            Mapper = new DataBaseMapper();
        }
    }
}
