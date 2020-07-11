using System.Windows.Forms;
using FAS.Persistence;

namespace FAS.UI.Profile
{
    public partial class ProfileDetailsForm : Form
    {
        private readonly string _id;
        private readonly IQueryDao _dao;

        public ProfileDetailsForm(string id, IQueryDao dao)
        {
            InitializeComponent();
            _id = id;
            _dao = dao;

            FillFormAsync();
        }

        private async void FillFormAsync()
        {
            var lecturer = await _dao.GetAsync<ProfileDto>(_id);
            PersonalIdValue.Text = lecturer.Id;
            FullNameValue.Text = lecturer.FullName;
            BirthDateValue.Text = lecturer.BirthDate.ToString("MM/dd/yyyy");
            ImageBox.Image = lecturer.Image.ToBitmap();
        }
    }
}
