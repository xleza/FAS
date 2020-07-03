using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Models;

namespace FAS.UI.Students
{
    public partial class StudentsForm : Form
    {
        private readonly StudentsDao _studentsDao;

        public StudentsForm(StudentsDao studentsDao)
        {
            _studentsDao = studentsDao;
            InitializeComponent();
            //Task.Run(RefreshTable).Wait();
        }

        private void OnAddStudent(object sender, EventArgs e)
        {
            var addStudentDialog = DependencyResolver.Resolve<StudentAddFrom>();
            addStudentDialog.ShowDialog();
        }

        private async void RefreshTable()
        {
            studentsListItemDtoBindingSource.DataSource = await _studentsDao.ListAsync<StudentsListItemDto>();
            
          //  var data = await _studentsDao.ListAsync<StudentsListItemDto>();
        }
    }
}
