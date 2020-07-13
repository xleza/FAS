using System.Data;
using System.Threading.Tasks;
using FAS.Core.Entities;
using FAS.Core.Persistence;

namespace FAS.Persistence
{
    public sealed class StudentsDao : Dao<Student, string>, IStudentsDao
    {

        public StudentsDao(string connectionString) : base((nameof(Student.Id), DbType.AnsiString), "Students", connectionString)
        {
        }

        public Task<Student> GetAsync(string id) => GetAsync<Student>(id);
    }
}
