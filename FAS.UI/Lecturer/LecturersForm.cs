using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Lecturer.Models;

namespace FAS.UI.Lecturer
{
    public partial class LecturersForm : Form
    {
        private readonly LecturersDao _lecturersDao;
        private string _selectedStudentId;

        public LecturersForm(LecturersDao lecturersDao)
        {
            _lecturersDao = lecturersDao;
            InitializeComponent();
            RefreshTableAsync();
        }

        private async void OnAddLecturer(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<StudentAddFrom>();
            if (addStudentDialog.ShowDialog() == DialogResult.OK)
            {
                await RefreshTableAsync();
            }
        }

        private void OnLecturerDetails(object sender, EventArgs e)
        {
            OpenLecturerDetails();
        }

        private async void OnRefresh(object sender, EventArgs e)
        {
            await RefreshTableAsync();
        }

        private async Task RefreshTableAsync()
        {
            var students = await _lecturersDao.ListAsync<LecturersListItemDto>();
            studentsListItemDtoBindingSource.DataSource = students;

            _selectedStudentId = students.FirstOrDefault()?.Id;
            if (_selectedStudentId != null)
                StudentDetailsBtn.Enabled = true;
        }

        private void OnLecturersGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedStudentId = StudentsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void OnLecturersGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenLecturerDetails();
        }

        private void OpenLecturerDetails()
        {
            if (_selectedStudentId == null)
                return;

            new LecturerDetailsForm(_selectedStudentId, DependencyResolver.Resolve<StudentsDao>()).ShowDialog();
        }
    }
}
