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

        public async Task StartAsync(StartSession cmd)
        {
            cmd.Validate();

            var session = await _sessionsDao.GetAsync(cmd.Id);
            if (session == null)
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            session.Start();
            await _sessionsDao.UpdateAsync(session);
        }

        public async Task FinishAsync(FinishSession cmd)
        {
            cmd.Validate();

            var session = await _sessionsDao.GetAsync(cmd.Id);
            if (session == null)
                throw new ObjectNotFoundException(cmd.Id, typeof(Student));

            session.FinishSession();
            await _sessionsDao.UpdateAsync(session);
        }

        public async Task AddAttendeeAsync(AddAttendeeAtSession cmd)
        {
            cmd.Validate();

            var session = await _sessionsDao.GetAsync(cmd.SessionId);
            if (session == null)
                throw new ObjectAlreadyExitsException(cmd.SessionId, typeof(SeminarSession));

            var seminar = await _seminarDao.GetAsync(session.SeminarId);
            if (seminar == null)
                throw new ObjectNotFoundException(session.SeminarId, typeof(SeminarSession));

            var attendee = session.AddAttendeeSession(cmd, seminar);
            await _sessionsDao.AddAttendeeAsync(attendee);
        }
    }
}
