using System.Data;

namespace Coworking.Data.Factories
{
    public interface IDataBaseFactory
    {
        IDbConnection napraviKonekciju(string konekcioniString);

        IDbDataAdapter napraviAdapter(IDbCommand komanda);

        IDbCommand napraviKomandu(string upit, IDbConnection konekcija);
    }
}
