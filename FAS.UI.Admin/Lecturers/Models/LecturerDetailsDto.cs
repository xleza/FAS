using System;
using FAS.Persistence;

namespace FAS.UI.Admin.Lecturers.Models
{
    [TableName("Lecturers")]
    public sealed class LecturerDetailsDto : IQueryable
    {
        [Pk]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Image { get; set; }
    }
}
