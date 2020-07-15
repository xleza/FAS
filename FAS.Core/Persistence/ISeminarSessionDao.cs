using System.Threading.Tasks;
using FAS.Core.Entities;

namespace FAS.Core.Persistence
{
    public interface ISeminarSessionDao
    {
        Task<SeminarSession> GetAsync(string id);
        Task<bool> ExistsByIdAsync(string id);
        Task<bool> ExistsByWhereAsync(string where);
        Task AddAsync(SeminarSession session);
        Task UpdateAsync(SeminarSession session);
        Task AddAttendeeAsync(SessionAttendee attendee);
    }
}
