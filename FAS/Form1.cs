using System;
using System.Drawing;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;

namespace FAS
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private Capture _capturer;
        private Enrollment _enrollment;

        public Form1()
        {
            _capturer = new Capture();
            _capturer.EventHandler = this;
            _capturer.StartCapture();
            _enrollment = new Enrollment();
            InitializeComponent();
        }

        public void OnComplete(object capture, string readerSerialNumber, Sample sample)
        {
            var set = ExtractFeatures(sample, DataPurpose.Enrollment);
            _enrollment.AddFeatures(set);



            var bitMap = ConvertSampleToBitmap(sample);
            pictureBox1.Image = new Bitmap(bitMap, pictureBox1.Size);
        }

        private Bitmap ConvertSampleToBitmap(Sample sample)
        {
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            new SampleConversion().ConvertToPicture(sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        private static FeatureSet ExtractFeatures(Sample sample, DataPurpose purpose)
        {
            var extractor = new FeatureExtraction();  // Create a feature extractor
            var feedback = CaptureFeedback.None;
            var features = new FeatureSet();

            extractor.CreateFeatureSet(sample, purpose, ref feedback, ref features);

            return feedback == CaptureFeedback.Good ? features : null;
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            throw new NotImplementedException();
        }
    }
}
