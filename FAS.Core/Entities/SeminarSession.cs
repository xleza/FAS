using System;
using System.Collections.Generic;
using System.Linq;
using FAS.Core.Commands.Seminars;
using FAS.Core.Exceptions;

namespace FAS.Core.Entities
{
    public class SeminarSession
    {
        public string Id { get; private set; }
        public string SeminarId { get; private set; }
        public List<SessionAttendee> Attendees { get; private set; }
        public SessionStatus Status { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }

        public SeminarSession(CreateSession cmd)
        {
            Id = cmd.Id;
            SeminarId = cmd.SeminarId;
            Attendees = new List<SessionAttendee>();
            Status = SessionStatus.Current;
            StartTime = DateTime.Now;
            EndTime = null;
        }

        public void FinishSession()
        {
            if (Status == SessionStatus.Finished)
                throw new DomainException("Seminar status is already finished");

            EndTime = DateTime.Now;
            Status = SessionStatus.Finished;
        }

        public void AddAttendeeSession(AddAttendeeAtSession cmd, IEnumerable<Student> registeredStudents, IFingerprintVerifier verifier)
        {
            if (Status == SessionStatus.Finished)
                throw new DomainException("Can't add attendee at finished session");

            //var verifiedStudent = registeredStudents.FirstOrDefault(student => verifier.Verify(student.FingerprintChecksum, cmd.FingerprintChecksum));

            //if (verifiedStudent == null)
            //    throw new DomainException("Fingerprint does not match to any registered student fingerprint");

            //Attendees.Add(new SessionAttendee
            //{
            //    Id = verifiedStudent.Id,
            //    AttendeeStartTime = DateTime.Now
            //});
        }
    }
}
