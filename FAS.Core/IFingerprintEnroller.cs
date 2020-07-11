using System;
using System.Drawing;

namespace FAS.Core
{
    public interface IFingerprintEnroller : IFingerprintCapturer
    {
        event EventHandler<(byte[] checkSum, Bitmap picture)> Success;
        event EventHandler Fail;
    }
}
