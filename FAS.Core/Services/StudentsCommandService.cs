using System.Threading.Tasks;
using FAS.Core.Commands.Students;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Core.Services
{
    public sealed class StudentsCommandService
    {
        private readonly IUsersRepository _usersRepository;

        public StudentsCommandService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task CreateAsync(CreateStudent cmd)
        {
            var student = await _usersRepository.GetByIdAsync(cmd.Id);
            if (student == null)
            {
                await _usersRepository.AddAsync(new Student(cmd));
                return;
            }

            if (!student.IsDeleted)
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Student));

            student.Restore(cmd.FullName, cmd.FingerprintChecksum);
            await _usersRepository.UpdateAsync(student);
        }

        public async Task ChangeAsync(ChangeStudent cmd)
        {
            var student = await _usersRepository.GetByIdAsync(cmd.Id);
            if (student == null || student.IsDeleted)
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            student.Change(cmd);
            await _usersRepository.UpdateAsync(student);
        }

        public async Task DeleteAsync(DeleteStudent cmd)
        {
            var student = await _usersRepository.GetByIdAsync(cmd.Id);
            if (student == null || student.IsDeleted)
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            student.Delete();

            await _usersRepository.UpdateAsync(student);
        }
    }
}
