using System;
using FAS.Core.Commands.Students;

namespace FAS.Core.Entities
{
    public class Student
    {
        public string Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public byte[] FingerprintChecksum { get; private set; }
        public byte[] Image { get; private set; }

        protected Student()
        {
        }

        public Student(CreateStudent cmd)
        {
            Id = cmd.Id;
            FullName = cmd.FullName;
            BirthDate = cmd.BirthDate;
            FingerprintChecksum = cmd.FingerprintChecksum;
            Image = cmd.Image;
        }

        public void Change(ChangeStudent cmd)
        {
            FullName = cmd.FullName;
            BirthDate = cmd.BirthDate;
            Image = cmd.Image;
        }
    }
}
