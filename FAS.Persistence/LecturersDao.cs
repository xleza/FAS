using System.Data;
using System.Threading.Tasks;
using FAS.Core.Entities;
using FAS.Core.Persistence;

namespace FAS.Persistence
{
    public sealed class LecturersDao : Dao<Lecturer, string>, ILecturerDao
    {

        public LecturersDao(string connectionString) : base((nameof(Student.Id), DbType.AnsiString), "Lecturers", connectionString)
        {
        }
        
        public Task<Lecturer> GetAsync(string id) => GetAsync<Lecturer>(id);
    }
}
