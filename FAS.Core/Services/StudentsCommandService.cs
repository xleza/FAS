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

            var student = await _studentsDao.GetAsync(cmd.Id);
            if (student != null)
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Student));

            await _studentsDao.AddAsync(new Student(cmd));
        }

        public async Task ChangeAsync(ChangeStudent cmd)
        {
            var student = await _studentsDao.GetAsync(cmd.Id);
            if (student == null)
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            student.Change(cmd);
            await _studentsDao.UpdateAsync(student);
        }
    }
}
