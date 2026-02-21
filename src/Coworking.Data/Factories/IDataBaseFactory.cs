using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Factories
{
    public interface IDataBaseFactory
    {
        IDbConnection napraviKonekciju(string konekcioniString);

        IDbDataAdapter napraviAdapter(IDbCommand komanda);

        IDbCommand napraviKomandu(string upit, IDbConnection konekcija);
    }
}
