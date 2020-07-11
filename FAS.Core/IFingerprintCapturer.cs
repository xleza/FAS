using System;
using System.Drawing;

namespace FAS.Core
{
    public interface IFingerprintCapturer : IDisposable
    {
        event EventHandler Connect;
        event EventHandler Disconnect;
        event EventHandler<Bitmap> Capture;
    }
}
