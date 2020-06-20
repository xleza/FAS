using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var dialog = new EnrollmentForm();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var data = dialog.FingerPrintEnrollmentData;
            }
        }
    }
}
