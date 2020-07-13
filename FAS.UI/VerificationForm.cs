using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core;

namespace FAS.UI
{
    public partial class VerificationForm : Form
    {
        private readonly IFingerprintVerifier _verifier;
        private readonly IReadOnlyCollection<byte[]> _checksum;
        private bool listen = true;

        public byte[] VerifiedChecksum { get; private set; }

        public VerificationForm(IFingerprintVerifier verifier, IReadOnlyCollection<byte[]> checksum)
        {
            _verifier = verifier;
            _checksum = checksum;

            InitializeComponent();

            _verifier.Connect += OnConnect;
            _verifier.Disconnect += OnDisconnect;
            _verifier.Capture += OnCapture;
        }

        private void OnCapture(object sender, System.Drawing.Bitmap e)
        {
            if (!listen)
                return;
            listen = false;
            Invoke(new Action(async () =>
            {
                FingerprintBox.Image = e;

                await Task.Delay(500);

                foreach (var item in _checksum)
                {
                    if (!_verifier.Verify(item)) continue;

                    VerifiedChecksum = item;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var tryAgain = MessageBoxWrapper.Confirmation("Verification failed! Do you want to try again?") == DialogResult.Yes;
                if (!tryAgain)
                {
                    DialogResult = DialogResult.No;
                    Close();
                }

                FingerprintBox.Image = null;
                listen = true;
            }));
        }

        private void OnConnect(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                MessageBoxWrapper.Info("Fingerprint scanner disconnected");
            }));
        }

        private void OnDisconnect(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                MessageBoxWrapper.Info("Fingerprint scanner disconnected");
                DialogResult = DialogResult.No;
                Close();
            }));
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            _verifier.Connect -= OnConnect;
            _verifier.Disconnect -= OnDisconnect;
            _verifier.Capture -= OnCapture;
            _verifier.Dispose();
        }
    }
}
