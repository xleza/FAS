using System.Threading.Tasks;
using FAS.Core.Entities;

namespace FAS.Core.Persistence
{
    public interface ISeminarDao
    {
        Task<Seminar> GetAsync(string id);
        Task<bool> ExistsAsync(string id);
        Task AddAsync(Seminar seminar);
        Task AddAttendeeAsync(SeminarAttendee attendee);
        Task RemoveAttendeeAsync(SeminarAttendee attendee);
    }
}
