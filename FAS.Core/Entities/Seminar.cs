using System;
using System.Collections.Generic;
using System.Linq;
using FAS.Core.Commands.Seminars;
using FAS.Core.Exceptions;

namespace FAS.Core.Entities
{
    public sealed class Seminar
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string LecturerId { get; private set; }
        public List<SeminarAttendee> RegisteredAttendees { get; private set; }

        public Seminar(CreateSeminar cmd)
        {
            Id = cmd.Id;
            Name = cmd.Name;
            LecturerId = cmd.LecturerId;
            RegisteredAttendees = new List<SeminarAttendee>();
        }

        public SeminarAttendee RegisterAttendee(RegisterAttendeeAtSeminar cmd)
        {
            var exist = RegisteredAttendees.Any(attendee => attendee.Id == cmd.AttendeeId);
            if (exist)
                throw new ObjectAlreadyExitsException(cmd.AttendeeId, typeof(SeminarAttendee));

            var registeredAttendee = new SeminarAttendee
            {
                Id = cmd.AttendeeId,
                RegistrationTime = DateTime.Now
            };

            RegisteredAttendees.Add(registeredAttendee);
            return registeredAttendee;
        }

        public SeminarAttendee UnRegisterAttendee(UnRegisterAttendeeAtSeminar cmd)
        {
            var attendeeToRemove = RegisteredAttendees.FirstOrDefault(attendee => attendee.Id == cmd.AttendeeId);
            if (attendeeToRemove == null)
                throw new ObjectNotFoundException(cmd.AttendeeId, typeof(SeminarAttendee));
            
            RegisteredAttendees.Remove(attendeeToRemove);
            return attendeeToRemove;
        }
    }
}
