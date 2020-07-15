using System;
using System.Linq;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Admin.Lecturers.Models;

namespace FAS.UI.Admin.Lecturers
{
    public partial class LecturersForm : Form
    {
        private readonly IQueryDao _queryDao;
        private string _selectedStudentId;

        public LecturersForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;

            InitializeComponent();
            RefreshTable();
        }

        private void OnLecturerAdd(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<LecturerAddFrom>();
            if (addStudentDialog.ShowDialog() == DialogResult.OK)
            {
                RefreshTable();
            }
        }

        private void OnLecturerDetails(object sender, EventArgs e)
        {
            OpenStudentDetails();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            var lecturers = _queryDao.List<LecturersListItemDto>();
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
