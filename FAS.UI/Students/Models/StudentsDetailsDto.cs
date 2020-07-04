using System;

namespace FAS.UI.Students.Models
{
    public sealed class StudentsDetailsDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] FingerprintChecksum { get; set; }
        public byte[] FingerprintImage { get; set; }
        public byte[] Image { get; set; }
    }
}
