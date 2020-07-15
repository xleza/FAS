using System;
using System.Drawing;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Profile;
using FAS.UI.Sessions;
using FontAwesome.Sharp;

namespace FAS.UI
{
    public partial class Main : Form
    {
        private readonly SecurityService _securityService;
        private IconButton _activeButton;
        private readonly Panel _leftBorder;
        private Form _currentChildForm;

        public Main(SecurityService securityService)
        {
            _securityService = securityService;
            InitializeComponent();

            var isAuthorized = securityService.IsAuthorized();
            if (!isAuthorized)
                Environment.Exit(0);

            ProfileName.Text = securityService.CurrentLecturerFullName;


            _leftBorder = new Panel { Size = new Size(7, 60) };
            Menu.Controls.Add(_leftBorder);
            OnSessionsMenuBtnClick(SessionsMenuBtn, null);
        }


        private void OnSessionsMenuBtnClick(object sender, EventArgs e)
        {
            ActiveButton((IconButton)sender);
            OpenChildForm(DependencyResolver.Resolve<SessionsForm>());
        }


        private void OnHomeMenuBtnClick(object sender, EventArgs e)
        {
            OpenChildForm(DependencyResolver.Resolve<SessionsForm>());
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

        private void OnProfileBtnClick(object sender, EventArgs e)
        {
            var lecturerDetailsForm = new ProfileDetailsForm(_securityService.CurrentLecturerId, DependencyResolver.Resolve<IQueryDao>());
            lecturerDetailsForm.ShowDialog();
        }
    }
}
