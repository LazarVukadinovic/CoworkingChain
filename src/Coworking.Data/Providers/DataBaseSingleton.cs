
namespace Coworking.Data.Providers
{
    public sealed class DataBaseSingleton
    {
        private static readonly Lazy<IDataBase> _instance = new(() =>
        {
            var settings = new DBSettings();
            var facade = new DataBaseFacade(settings);
            return new DataBaseProxy(facade);
        }, isThreadSafe: true);

        private DataBaseSingleton() { }
        public static IDataBase vratiInstancu() => _instance.Value;
    }
}
