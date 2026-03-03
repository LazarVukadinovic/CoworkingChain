using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
    }
}
