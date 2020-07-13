using System;
using System.Collections.Generic;
using FAS.Core.Commands.Sessions;
using FAS.Core.Exceptions;

namespace FAS.Core.Entities
{
    public class SeminarSession
    {
        public string Id { get; set; }
        public string SeminarId { get; set; }
        public List<SessionAttendee> Attendees { get; set; }
        public SessionStatus Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public SeminarSession()
        {

        }

        public SeminarSession(CreateSession cmd)
        {
            Id = cmd.Id;
            SeminarId = cmd.SeminarId;
            Attendees = new List<SessionAttendee>();
            Status = SessionStatus.NotStarted;
            StartTime = null;
            EndTime = null;
        }

        public void StartSession()
        {
            if (Status == SessionStatus.Running)
                throw new DomainException("Seminar status is already Running");

            StartTime = DateTime.Now;
            Status = SessionStatus.Running;
        }

        public void FinishSession()
        {
            if (Status == SessionStatus.Finished)
                throw new DomainException("Seminar status is already finished");

            EndTime = DateTime.Now;
            Status = SessionStatus.Finished;
        }

        public SessionAttendee AddAttendeeSession(AddAttendeeAtSession cmd)
        {
            if (Status == SessionStatus.Finished)
                throw new DomainException("Can't add attendee at finished session");

            var attendeeToAdd = new SessionAttendee
            {
                Id = cmd.Id,
                SessionId = cmd.SessionId,
                AttendeeStartTime = DateTime.Now,
            };

            Attendees.Add(attendeeToAdd);

            return attendeeToAdd;
        }
    }
}
