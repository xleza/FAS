using System;
using FAS.Persistence;

namespace FAS.UI.Admin.Students.Models
{
    [TableName("Students")]
    public sealed class StudentsDetailsDto : IQueryable
    {
        [Pk]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] FingerprintImage { get; set; }
        public byte[] Image { get; set; }
    }
}
