namespace FAS.Core.Commands.Students
{
    public sealed class CreateStudent
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public byte[] FingerprintChecksum { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(FullName, nameof(FullName));
            Ensure.NotNull(FingerprintChecksum, nameof(FingerprintChecksum));
        }
    }
}
