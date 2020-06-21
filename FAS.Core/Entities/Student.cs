using FAS.Core.Commands.Students;

namespace FAS.Core.Entities
{
    public sealed class Student
    {
        public string Id { get; private set; }
        public string FullName { get; private set; }
        public byte[] FingerprintChecksum { get; private set; }
        public bool IsDeleted { get; private set; }

        public Student(CreateStudent cmd)
        {
            Id = cmd.Id;
            FullName = cmd.FullName;
            FingerprintChecksum = cmd.FingerprintChecksum;
            IsDeleted = false;
        }

        public void Change(ChangeStudent cmd)
        {
            FullName = cmd.FullName;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Restore(string fullName, byte[] fingerprintChecksum)
        {
            FullName = fullName;
            FingerprintChecksum = fingerprintChecksum;
            IsDeleted = false;
        }
    }
}
