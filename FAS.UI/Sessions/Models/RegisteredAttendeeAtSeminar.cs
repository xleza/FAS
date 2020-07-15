using FAS.Persistence;

namespace FAS.UI.Sessions.Models
{
    [TableName("SeminarAttendeesView")]
    public sealed class RegisteredAttendeeAtSeminar : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public byte[] FingerprintChecksum { get; set; }
    }
}
