using System;
using System.Drawing;
using System.Windows.Forms;
using FAS.Scanner.DigitalPersona;

namespace FAS.UI
{
    public partial class EnrollmentForm : Form
    {
        private Enroller _enroller;
        public byte[] FingerPrintEnrollmentData { get; private set; }

        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            _enroller = new Enroller();
            _enroller.Connect += OnConnect;
            _enroller.Disconnect += OnDisconnect;
            _enroller.Capture += OnCapture;
            _enroller.Success += OnSuccess;
            _enroller.Fail += OnFail;

            Log("Ready to enroll fingerprint");
        }

        private void OnConnect(object sender, EventArgs e)
        {
            Log("Fingerprint scanner connected");
        }
        private void OnDisconnect(object sender, EventArgs e)
        {
            Log("Fingerprint scanner disconnected");
        }

        private void OnCapture(object sender, Bitmap e)
        {
            picture.Image = new Bitmap(e, picture.Size);

            Log("Fingerprint captured");
        }

        private void OnSuccess(object sender, byte[] e)
        {
            Log("Fingerprint enrollment succeed");
            
            Invoke(new Action(() =>
            {
                FingerPrintEnrollmentData = e;
                DialogResult = DialogResult.OK;
                Close();
            }));
        }

        private void OnFail(object sender, EventArgs e)
        {
            Log("Fingerprint enrollment failed. Try again");
        }

        private void Log(string message)
        {
            Invoke(new Action(() => log.AppendText($"{message} \n")));
        }

        private void EnrollmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _enroller.Connect -= OnConnect;
            _enroller.Disconnect -= OnDisconnect;
            _enroller.Capture -= OnCapture;
            _enroller.Success -= OnSuccess;
            _enroller.Fail -= OnFail;

            _enroller.Dispose();
        }
    }
}
