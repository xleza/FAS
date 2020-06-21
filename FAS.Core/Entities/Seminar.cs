using System;
using System.Collections.Generic;
using System.Linq;
using FAS.Core.Commands.Seminars;
using FAS.Core.Exceptions;

namespace FAS.Core.Entities
{
    public sealed class Seminar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LecturerId { get; set; }
        public List<RegisteredAttendee> RegisteredAttendees { get; set; }

        public Seminar(CreateSeminar cmd)
        {
            Name = cmd.Name;
            LecturerId = cmd.LecturerId;
            RegisteredAttendees = new List<RegisteredAttendee>();
        }

        public void Change(ChangeSeminar cmd, SeminarSession lastSession)
        {
            if (lastSession.Status == SessionStatus.Current)
                throw new DomainException("Can't change seminar during it session");

            Name = cmd.Name;
            LecturerId = cmd.LecturerId;
        }

        public void RegisterAttendee(RegisterAttendeeAtSeminar cmd)
        {
            var exist = RegisteredAttendees.Any(attendee => attendee.Id == cmd.AttendeeId);
            if (exist)
                throw new ObjectAlreadyExitsException(cmd.AttendeeId, typeof(RegisteredAttendee));

            RegisteredAttendees.Add(new RegisteredAttendee
            {
                Id = cmd.AttendeeId,
                Time = DateTime.Now
            });
        }
    }
}
