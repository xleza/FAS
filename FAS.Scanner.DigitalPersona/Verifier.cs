using System;
using System.Drawing;
using System.IO;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using DPFP.Verification;
using FAS.Core;
using EventHandler = System.EventHandler;

namespace FAS.Scanner.DigitalPersona
{
    public sealed class Verifier : IFingerprintVerifier
    {
        public event EventHandler Connect;
        public event EventHandler Disconnect;
        public event EventHandler<Bitmap> Capture;

        private readonly CaptureEventHandler _capturer;
        private readonly Verification _verification;
        private FeatureSet _lastCaptured;

        public Verifier()
        {
            _capturer = new CaptureEventHandler(DataPurpose.Verification);
            _capturer.Connect += OnConnect;
            _capturer.Capture += Captured;
            _capturer.Disconnect += OnDisconnect;

            _verification = new Verification();
        }

        private void OnConnect(object sender, EventArgs e) => Connect?.Invoke(this, e);

        private void Captured(object sender, (Sample sample, FeatureSet featureSet, CaptureFeedback feedback) e)
        {
            Bitmap bitmap = null;
            new SampleConversion().ConvertToPicture(e.sample, ref bitmap);
            _lastCaptured = e.featureSet;

            Capture?.Invoke(this, bitmap);
        }

        public bool Verify(byte[] checkSum)
        {
            if (_lastCaptured == null)
                throw new Exception("FeatureSet not found");

            using (var stream = new MemoryStream(checkSum))
            {
                var result = new Verification.Result();
                _verification.Verify(_lastCaptured, new Template(stream), ref result);

                return result.Verified;
            }
        }

        private void OnDisconnect(object sender, EventArgs e) => Disconnect?.Invoke(this, e);


        public void Dispose()
        {
            _capturer.Connect -= Connect;
            _capturer.Disconnect -= Disconnect;
            _capturer.Capture -= Captured;

            _capturer.Dispose();
        }

    }
}
