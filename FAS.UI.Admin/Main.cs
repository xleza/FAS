﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FAS.UI.Admin.Lecturers;
using FAS.UI.Admin.Seminars;
using FAS.UI.Admin.Students;
using FontAwesome.Sharp;

namespace FAS.UI.Admin
{
    public partial class Main : Form
    {
        private IconButton _activeButton;
        private readonly Panel _leftBorder;
        private Form _currentChildForm;

        public Main()
        {
            InitializeComponent();

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
