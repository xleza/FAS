using System;
using System.Windows.Forms;

namespace FAS.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = DependencyResolver.Resolve<EnrollmentForm>();
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                var data = dialog.FingerPrintCheckSum;
            }
        }

        private void OnAddStudent(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<StudentAddFrom>();
            addStudentDialog.ShowDialog();
        }
    }
}
