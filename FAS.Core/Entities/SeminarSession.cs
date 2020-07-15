using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Start()
        {
            if (Status == SessionStatus.Running)
                return;

            if (Status == SessionStatus.Finished)
                throw new DomainException("Session already finished");

            StartTime = DateTime.Now;
            Status = SessionStatus.Running;
        }

        public void FinishSession()
        {
            if (Status == SessionStatus.Finished)
                return;

            if (Status == SessionStatus.NotStarted)
                throw new DomainException("Session not started");

            EndTime = DateTime.Now;
            Status = SessionStatus.Finished;
        }

        public SessionAttendee AddAttendeeSession(AddAttendeeAtSession cmd, Seminar seminar)
        {
            if (Status != SessionStatus.Running)
                throw new DomainException($"Can't add attendee at {Status} session");

            var registered = seminar.RegisteredAttendees.Any(x => x.Id == cmd.Id);
            if (!registered)
                throw new DomainException($"Attendee {cmd.Id} not registered at seminar");

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
