using System.Threading.Tasks;
using FAS.Core.Entities;

namespace FAS.Core.Persistence
{
    public interface ILecturerDao
    {
        Task<Lecturer> GetAsync(string id);
        Task<bool> ExistsAsync(string id);
        Task AddAsync(Lecturer lecturer);
    }
}
