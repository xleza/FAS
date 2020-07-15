using System;
using System.Linq;
using System.Windows.Forms;
using FAS.Persistence;

namespace FAS.UI.Admin.Students
{
    public partial class StudentsForm : Form
    {
        private readonly IQueryDao _queryDao;
        private string _selectedStudentId;

        public StudentsForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;

            InitializeComponent();
            RefreshTable();
        }

        private void OnAddStudent(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<StudentAddFrom>();
            if (addStudentDialog.ShowDialog() == DialogResult.OK)
            {
                RefreshTable();
            }
        }

        private void OnDetailsStudent(object sender, EventArgs e)
        {
            OpenStudentDetails();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            try
            {
                var students = _queryDao.List<StudentsListItemDto>();
                studentsListItemDtoBindingSource.DataSource = students;

                _selectedStudentId = students.FirstOrDefault()?.Id;
                if (_selectedStudentId != null)
                    StudentDetailsBtn.Enabled = true;
            }
            catch (Exception)
            {
                MessageBoxWrapper.Error("Can't fill students");
            }
        }

        private void OnStudentsGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            _selectedStudentId = StudentsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void OnStudentsGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenStudentDetails();
        }

        private void OpenStudentDetails()
        {
            if (_selectedStudentId == null)
                return;

            new StudentDetailsForm(_selectedStudentId, DependencyResolver.Resolve<IQueryDao>()).ShowDialog();
        }
    }
}
