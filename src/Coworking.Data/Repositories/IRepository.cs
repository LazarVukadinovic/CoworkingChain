
namespace Coworking.Data.Repositories
{
    internal interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);

        void Delete(int id);
        T GetById(int id);
        List<T> GetByName(string name);
    }
}
