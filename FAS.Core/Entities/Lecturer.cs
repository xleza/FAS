using System;
using FAS.Core.Commands.Lecturer;

namespace FAS.Core.Entities
{
    public sealed class Lecturer
    {
        public string Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public byte[] Image { get; private set; }
        public byte[] FingerprintChecksum { get; private set; }

        public Lecturer(CreateLecturer cmd)
        {
            Id = cmd.Id;
            FullName = cmd.FullName;
            BirthDate = cmd.BirthDate;
            Image = cmd.Image;
            FingerprintChecksum = cmd.FingerprintChecksum;
        }
    }
}
