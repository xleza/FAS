using System.Threading.Tasks;
using FAS.Core.Entities;

namespace FAS.Core.Persistence
{
    public interface IUsersRepository
    {
        Task<Student> GetByIdAsync(string id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
    }
}
