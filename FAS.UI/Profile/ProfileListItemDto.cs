using System;
using FAS.Persistence;

namespace FAS.UI.Profile
{
    [TableName("Lecturers")]
    public sealed class ProfileListItemDto : IQueryable
    {
        [Pk]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] FingerprintChecksum { get; set; }
    }
}
