using Coworking.Domain.Entities;

namespace Coworking.Data.Repositories
{
    internal interface ITipClanstvaRepository : IRepository<TipClanstva>
    {
        TipClanstva GetById(int id);
        List<TipClanstva> GetByName(string name);
    }
}
