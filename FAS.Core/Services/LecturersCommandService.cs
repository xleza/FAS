using System.Threading.Tasks;
using FAS.Core.Commands.Lecturer;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Core.Services
{
    public sealed class LecturersCommandService
    {
        private readonly ILecturerDao _lecturerDao;

        public LecturersCommandService(ILecturerDao lecturerDao)
        {
            _lecturerDao = lecturerDao;
        }

        public async Task Create(CreateLecturer cmd)
        {
            cmd.Validate();

            if (await _lecturerDao.ExistsAsync(cmd.Id))
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Lecturer));

            await _lecturerDao.AddAsync(new Lecturer(cmd));
        }
    }
}
