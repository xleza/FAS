using System;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using EventHandler = System.EventHandler;

namespace FAS.Scanner.DigitalPersona
{
    public class CaptureEventHandler : DPFP.Capture.EventHandler, IDisposable
    {
        public event EventHandler Connect;
        public event EventHandler Disconnect;
        public event EventHandler<(Sample sample, FeatureSet featureSet, CaptureFeedback feedback)> Capture;
        private readonly DataPurpose _purpose;

        private readonly Capture _capture;

        public CaptureEventHandler(DataPurpose purpose)
        {
            _purpose = purpose;
            _capture = new Capture { EventHandler = this };
            _capture.StartCapture();
        }


        public void OnComplete(object capture, string readerSerialNumber, Sample sample)
        {
            var (featureSet, feedback) = GetFeatureSet(sample);
            Capture?.Invoke(this, (sample, featureSet, feedback));
        }

        private (FeatureSet featureSet, CaptureFeedback feedback) GetFeatureSet(Sample sample)
        {
            var feedback = CaptureFeedback.None;
            var featureSet = new FeatureSet();
            new FeatureExtraction().CreateFeatureSet(sample, _purpose, ref feedback, ref featureSet);

            return (featureSet, feedback);
        }

        public void OnFingerGone(object capture, string readerSerialNumber)
        {
        }

        public void OnFingerTouch(object capture, string readerSerialNumber)
        {
        }

        public void OnReaderConnect(object capture, string readerSerialNumber)
        {
            Connect?.Invoke(this, null);
        }

        public void OnReaderDisconnect(object capture, string readerSerialNumber)
        {
            Disconnect?.Invoke(this, null);
        }

        public void OnSampleQuality(object capture, string readerSerialNumber, CaptureFeedback captureFeedback)
        {
        }

        public void Dispose()
        {
            _capture.StopCapture();
        }
    }
}
