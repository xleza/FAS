using System;

namespace FAS.UI.Lecturers.Models
{
    public sealed class LecturerDetailsDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Image { get; set; }
    }
}
