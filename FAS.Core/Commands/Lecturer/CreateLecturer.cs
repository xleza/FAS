using System;

namespace FAS.Core.Commands.Lecturer
{
    public sealed class CreateLecturer
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] FingerprintChecksum { get; set; }
        public byte[] Image { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(FullName, nameof(FullName));
            Ensure.NotNull(FingerprintChecksum, nameof(FingerprintChecksum));
            Ensure.NotNull(Image, nameof(Image));
        }
    }
}
