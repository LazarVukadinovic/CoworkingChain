
namespace Coworking.Data.Providers
{
    public class DBSettings
    {
        public DataBaseAdapter Adapter { get; }
        public DataBaseMapper Mapper { get; }
        public DBSettings()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            var konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseFactory();
            var factory = helper.vratiFactory(konekcioniString);

            Adapter = new DataBaseAdapter(factory, konekcioniString);
            Mapper = new DataBaseMapper();
        }
    }
}
