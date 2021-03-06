﻿using System;

namespace FAS.Core.Commands.Students
{
    public sealed class CreateStudent
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] FingerprintChecksum { get; set; }
        public byte[] FingerprintImage { get; set; }
        public byte[] Image { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(FullName, nameof(FullName));
            Ensure.NotNull(FingerprintChecksum, nameof(FingerprintChecksum));
            Ensure.NotNull(FingerprintImage, nameof(FingerprintImage));
            Ensure.NotNull(Image, nameof(Image));
        }
    }
}
