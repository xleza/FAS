using System;

namespace FAS.Core.Entities
{
    public class SeminarAttendee
    {
        public string Id { get; set; }
        public string SeminarId { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
