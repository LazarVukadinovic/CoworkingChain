namespace Coworking.Data.Providers
{
    public sealed class DataBaseSingleton
    {
        private static readonly Lazy<IDataBase> _instance = 
            new(() => DataBaseDependencyProvider.Create(), isThreadSafe: true);

        private DataBaseSingleton() { }
        public static IDataBase vratiInstancu() => _instance.Value;
    }
}
