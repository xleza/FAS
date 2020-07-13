using System.Threading.Tasks;
using FAS.Core.Commands.Sessions;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Core.Services
{
    public sealed class SessionsCommandService
    {
        private readonly ISeminarSessionDao _sessionsDao;
        private readonly ISeminarDao _seminarDao;
        private readonly IStudentsDao _studentsDao;

        public SessionsCommandService(ISeminarSessionDao sessionsDao, ISeminarDao seminarDao, IStudentsDao studentsDao)
        {
            _sessionsDao = sessionsDao;
            _seminarDao = seminarDao;
            _studentsDao = studentsDao;
        }

        public async Task CreateAsync(CreateSession cmd)
        {
            cmd.Validate();

            if (await _sessionsDao.ExistsByIdAsync(cmd.Id))
                throw new ObjectAlreadyExitsException(cmd.Id, typeof(SeminarSession));

            if (await _sessionsDao.ExistsByWhereAsync($"SeminarId = '{cmd.SeminarId}' AND Status != '{SessionStatus.Finished}'"))
                throw new DomainException($"Can't create a seminar: {cmd.SeminarId} session until all sessions have finished");

            if (await _seminarDao.ExistsAsync(cmd.Id))
                throw new ObjectNotFoundException(cmd.SeminarId, typeof(Seminar));

            await _sessionsDao.AddAsync(new SeminarSession(cmd));
        }

        public async Task AddAttendeeAsync(AddAttendeeAtSession cmd)
        {
            cmd.Validate();

            if (await _studentsDao.ExistsAsync(cmd.Id))
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            var session = await _sessionsDao.GetAsync(cmd.SessionId);
            if (session == null)
                throw new ObjectAlreadyExitsException(cmd.SessionId, typeof(SeminarSession));

            var seminar = await _seminarDao.GetAsync(session.SeminarId);

            var attendee = session.AddAttendeeSession(cmd);

            await _sessionsDao.AddAttendeeAsync(attendee);
        }
    }
}
