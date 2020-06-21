using System;
using System.Windows.Forms;

namespace FAS.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = DependencyResolver.Resolve<EnrollmentForm>();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var data = dialog.FingerPrintEnrollmentData;
            }
        }
    }
}
