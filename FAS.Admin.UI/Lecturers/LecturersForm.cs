using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.Admin.UI.Lecturers.Models;

namespace FAS.Admin.UI.Lecturers
{
    public partial class LecturersForm : Form
    {
        private readonly IQueryDao _queryDao;
        private string _selectedStudentId;

        public LecturersForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;

            InitializeComponent();
            RefreshTableAsync();
        }

        private async void OnLecturerAdd(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<LecturerAddFrom>();
            if (addStudentDialog.ShowDialog() == DialogResult.OK)
            {
                await RefreshTableAsync();
            }
        }

        private void OnLecturerDetails(object sender, EventArgs e)
        {
            OpenStudentDetails();
        }

        private async void OnRefresh(object sender, EventArgs e)
        {
            await RefreshTableAsync();
        }

        private async Task RefreshTableAsync()
        {
            var lecturers = await _queryDao.ListAsync<LecturersListItemDto>();
            lecturersListItemDtoBindingSource.DataSource = lecturers;

            _selectedStudentId = lecturers.FirstOrDefault()?.Id;
            if (_selectedStudentId != null)
                LecturerDetailsBtn.Enabled = true;
        }

        private void OnLecturersGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _selectedStudentId = LecturersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void OnLecturersGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenStudentDetails();
        }

        private void OpenStudentDetails()
        {
            if (_selectedStudentId == null)
                return;

            new LecturerDetailsForm(_selectedStudentId, DependencyResolver.Resolve<IQueryDao>()).ShowDialog();
        }
    }
}
