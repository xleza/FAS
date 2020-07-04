using System;
using System.Drawing;

namespace FAS.Core
{
    public interface IFingerprintEnroller : IDisposable
    {
        event EventHandler Connect;
        event EventHandler Disconnect;
        event EventHandler<Bitmap> Capture;
        event EventHandler<(byte[] checkSum, Bitmap picture)> Success;
        event EventHandler Fail;
    }
}
