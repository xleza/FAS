using System;

namespace FAS.Core.Entities
{
    public class SessionAttendee
    {
        public string Id { get; set; }
        public string SessionId { get; set; }
        public DateTime AttendeeStartTime { get; set; }
    }
}
