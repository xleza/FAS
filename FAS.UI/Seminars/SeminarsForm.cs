using System;
using System.Windows.Forms;

namespace FAS.UI.Seminars
{
    public partial class SeminarsForm : Form
    {
        public SeminarsForm()
        {
            InitializeComponent();
        }

        private void OnSeminarAddBtnClick(object sender, EventArgs e)
        {
            var addForm = DependencyResolver.Resolve<AddSeminarForm>();
            addForm.ShowDialog();
        }
    }
}
