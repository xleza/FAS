using System.Threading.Tasks;
using FAS.Core.Commands.Seminars;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Core.Services
{
    public sealed class SeminarCommandService
    {
        private readonly ISeminarDao _seminarDao;

        public SeminarCommandService(ISeminarDao seminarDao)
        {
            _seminarDao = seminarDao;
        }

        public async Task CreateAsync(CreateSeminar cmd)
        {
            cmd.Validate();
            var exists = await _seminarDao.ExistsAsync(cmd.Id);
            if (exists)
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Seminar));

            await _seminarDao.AddAsync(new Seminar(cmd));
        }

        public async Task RegisterAttendeeAsync(RegisterAttendeeAtSeminar cmd)
        {
            cmd.Validate();
            var seminar = await _seminarDao.GetAsync(cmd.Id);
            if (seminar == null)
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Seminar));

            await _seminarDao.AddAttendeeAsync(seminar.RegisterAttendee(cmd));
        }

        public async Task UnRegisterAttendeeAsync(UnRegisterAttendeeAtSeminar cmd)
        {
            cmd.Validate();
            var seminar = await _seminarDao.GetAsync(cmd.Id);
            if (seminar == null)
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(Seminar));

            await _seminarDao.RemoveAttendeeAsync(seminar.UnRegisterAttendee(cmd));
        }
    }
}
