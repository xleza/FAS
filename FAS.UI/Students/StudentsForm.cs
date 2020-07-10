using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Persistence;

namespace FAS.UI.Students
{
    public partial class StudentsForm : Form
    {
        private readonly IQueryDao _queryDao;
        private string _selectedStudentId;

        public StudentsForm(IQueryDao queryDao)
        {
            _queryDao = queryDao;

            InitializeComponent();
            RefreshTableAsync();
        }

        private async void OnAddStudent(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<StudentAddFrom>();
            if (addStudentDialog.ShowDialog() == DialogResult.OK)
            {
                await RefreshTableAsync();
            }
        }

        private void OnDetailsStudent(object sender, EventArgs e)
        {
            OpenStudentDetails();
        }

        private async void OnRefresh(object sender, EventArgs e)
        {
            await RefreshTableAsync();
        }

        private async Task RefreshTableAsync()
        {
            var students = await _queryDao.ListAsync<StudentsListItemDto>()
                .OnError(_ => MessageBoxWrapper.Error("Can't fill students"));

            studentsListItemDtoBindingSource.DataSource = students;

            _selectedStudentId = students.FirstOrDefault()?.Id;
            if (_selectedStudentId != null)
                StudentDetailsBtn.Enabled = true;
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
