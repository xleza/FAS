using System;
using System.Drawing;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using EventHandler = System.EventHandler;

namespace FAS.Scanner.DigitalPersona
{
    public sealed class Enroller : IDisposable
    {
        public event EventHandler Connect;
        public event EventHandler Disconnect;
        public event EventHandler<Bitmap> Capture;
        public event EventHandler<byte[]> Success;
        public event EventHandler Fail;


        private readonly CaptureEventHandler _capturer;
        private readonly Enrollment _enroller;

        public Enroller()
        {
            _capturer = new CaptureEventHandler(DataPurpose.Enrollment);
            _capturer.Connect += OnConnect;
            _capturer.Capture += Captured;
            _capturer.Disconnect += OnDisconnect;

            Success += OnSuccess;
            Fail += OnFail;

            _enroller = new Enrollment();
        }

        private void OnConnect(object sender, EventArgs e) => Connect?.Invoke(this, e);

        private void Captured(object sender, (Sample sample, FeatureSet featureSet, CaptureFeedback feedback) e)
        {
            Bitmap bitmap = null;
            new SampleConversion().ConvertToPicture(e.sample, ref bitmap);
            Capture?.Invoke(this, bitmap);

            try
            {
                _enroller.AddFeatures(e.featureSet);
            }
            catch
            {
                Fail?.Invoke(this, null);
                return;
            }

            if (_enroller.TemplateStatus == Enrollment.Status.Ready)
                Success?.Invoke(this, _enroller.Template.Bytes);
            else if (_enroller.TemplateStatus == Enrollment.Status.Failed)
                Fail?.Invoke(this, null);
        }

        private void OnDisconnect(object sender, EventArgs e) => Disconnect?.Invoke(this, e);

        private void OnSuccess(object sender, byte[] e)
        {
            _enroller.Clear();
        }

        private void OnFail(object sender, EventArgs e)
        {
            _enroller.Clear();
        }

        public void Dispose()
        {
            _capturer.Connect -= Connect;
            _capturer.Disconnect -= Disconnect;
            _capturer.Capture -= Captured;

            _capturer.Dispose();
        }
    }
}
