using System.Threading.Tasks;
using FAS.Core.Commands.Students;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Core.Services
{
    public sealed class StudentsCommandService
    {
        private readonly IStudentsDao _studentsDao;

        public StudentsCommandService(IStudentsDao studentsDao)
        {
            _studentsDao = studentsDao;
        }

        public async Task CreateAsync(CreateStudent cmd)
        {
            cmd.Validate();

            if (await _studentsDao.ExistsAsync(cmd.Id))
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Student));

            await _studentsDao.AddAsync(new Student(cmd));
        }
    }
}
