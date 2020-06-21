using System;
using System.Collections.Generic;

namespace FAS.Core.Entities
{
    public class SeminarSessions
    {
        public int Id { get; set; }
        public int SeminarId { get; set; }
        public List<SessionAttendee> Attendees { get; set; }
        public SessionStatus Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
