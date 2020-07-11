using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAS.Persistence
{
    public interface IQueryDao
    {
        Task<T> GetAsync<T>(object id) where T : IQueryable;
        Task<List<T>> ListAsync<T>(string where = null) where T : IQueryable;
        List<T> List<T>(string where = null) where T : IQueryable;

    }
}
