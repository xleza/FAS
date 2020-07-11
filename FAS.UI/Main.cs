using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FAS.Core;
using FAS.UI.Lecturers;
using FAS.UI.Seminars;
using FAS.UI.Students;
using FontAwesome.Sharp;

namespace FAS.UI
{
    public partial class Main : Form
    {
        private IconButton _activeButton;
        private readonly Panel _leftBorder;
        private Form _currentChildForm;

        public Main(SecurityService securityService)
        {
            InitializeComponent();

            var isAuthorized = securityService.IsAuthorized();
            if (!isAuthorized)
                return;

            _leftBorder = new Panel { Size = new Size(7, 60) };
            Menu.Controls.Add(_leftBorder);
            OnStudentsMenuBtnClick(StudentsMenuBtn, null);
        }


        private void OnStudentsMenuBtnClick(object sender, EventArgs e)
        {
            ActiveButton((IconButton)sender);
            OpenChildForm(DependencyResolver.Resolve<StudentsForm>());
        }
        private void OnLecturerMenuBtnClick(object sender, EventArgs e)
        {
            ActiveButton((IconButton)sender);
            OpenChildForm(DependencyResolver.Resolve<LecturersForm>());
        }

        private void OnSeminarMenuBtnClick(object sender, EventArgs e)
        {
            ActiveButton((IconButton)sender);
            OpenChildForm(DependencyResolver.Resolve<SeminarsForm>());
        }

        private void OnHomeMenuBtnClick(object sender, EventArgs e)
        {
            OpenChildForm(DependencyResolver.Resolve<StudentsForm>());
        }

        private void ActiveButton(IconButton button)
        {
            DisableButton();

            _activeButton = button;
            _activeButton.ForeColor = Colors.Primary;
            _leftBorder.BackColor = Colors.Primary;
            _leftBorder.Location = new Point(0, _activeButton.Location.Y);
            _leftBorder.Visible = true;
            _leftBorder.BringToFront();
        }

        private void DisableButton()
        {
            if (_activeButton == null)
                return;

            _activeButton.ForeColor = Colors.Secondary;
        }

        private void OpenChildForm(Form childForm)
        {
            _currentChildForm?.Close();
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Desktop.Controls.Add(childForm);
            Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
