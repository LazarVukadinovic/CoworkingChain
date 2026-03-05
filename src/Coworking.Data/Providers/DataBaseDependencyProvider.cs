
namespace Coworking.Data.Providers
{
    internal static class DataBaseDependencyProvider
    {
        public static IDataBase Create()
        {
            var settings = new DBSettings();
            var facade = new DataBaseFacade(settings);
            return new DataBaseProxy(facade);
        }
    }
}
