using System.Collections.Generic;

namespace FAS.Core.Entities
{
    public sealed class Seminar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LecturerId { get; set; }
        public List<RegisteredAttendee> RegisteredAttendees { get; set; }
    }
}
