namespace FAS.Core.Commands.Seminars
{
    public sealed class AddAttendeeAtSession
    {
        public int Id { get; set; }
        public string Session { get; set; }
        public byte[] FingerprintChecksum { get; set; }

        public void Validate()
        {
            Ensure.IsPositive(Id, nameof(Id));
            Ensure.NotEmpty(Session, nameof(Session));
            Ensure.NotNull(FingerprintChecksum, nameof(FingerprintChecksum));
        }
    }
}
