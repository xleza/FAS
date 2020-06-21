﻿using System;
using System.Drawing;

namespace FAS.Core
{
    public interface IEnroller : IDisposable
    {
        event EventHandler Connect;
        event EventHandler Disconnect;
        event EventHandler<Bitmap> Capture;
        event EventHandler<byte[]> Success;
        event EventHandler Fail;
    }
}
