using System.Windows.Forms;
using FAS.Persistence;
using FAS.UI.Students.Models;

namespace FAS.UI.Students
{
    public partial class StudentDetailsForm : Form
    {
        private readonly string _id;
        private readonly StudentsDao _dao;

        public StudentDetailsForm(string id, StudentsDao dao)
        {
            InitializeComponent();
            _id = id;
            _dao = dao;

            FillFormAsync();
        }

        private async void FillFormAsync()
        {
            var student = await _dao.GetAsync<StudentsDetailsDto>(_id);
            PersonalIdValue.Text = student.Id;
            FullNameValue.Text = student.FullName;
            BirthDateValue.Text = student.BirthDate.ToShortDateString();
            ImageBox.Image = student.Image.ToBitmap();
            FingerprintBox.Image = student.FingerprintImage.ToBitmap();
        }
    }
}
