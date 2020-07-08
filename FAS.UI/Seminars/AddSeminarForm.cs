using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core.Commands.Seminars;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.UI.Seminars.Models;

namespace FAS.UI.Seminars
{
    public partial class AddSeminarForm : Form
    {
        private readonly SeminarsDao _seminarsDao;
        private readonly LecturersDao _lecturersDao;
        private readonly SeminarCommandService _seminarService;

        private (int index, SeminarLecturerDto) _selectedLecture;

        public AddSeminarForm(SeminarsDao seminarsDao, LecturersDao lecturersDao, SeminarCommandService seminarService)
        {
            InitializeComponent();

            _seminarsDao = seminarsDao;
            _lecturersDao = lecturersDao;
            _seminarService = seminarService;

            FillLecturersAsync();
        }

        private async Task FillLecturersAsync()
        {
            var lecturers = await _lecturersDao.ListAsync<SeminarLecturerDto>()
                .OnError(_ => MessageBoxWrapper.Error("Can't fill lecturers"));

            LecturersCheckedListBox.DataSource = lecturers;
        }

        private async void OnSave(object sender, EventArgs e)
        {
            var valid = ValidateChildren(ValidationConstraints.Enabled);
            if (!valid)
                return;
            SaveBtn.Enabled = false;

            await _seminarService.CreateAsync(new CreateSeminar
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = FullNameTxt.Text,
                    LecturerId = _selectedLecture.Item2.Id
                })
                .OnSuccess(() => MessageBoxWrapper.Info("Seminar created successfully"))
                .OnError(MessageBoxWrapper.Error);

            SaveBtn.Enabled = true;
            DialogResult = DialogResult.OK;
            Close();
        }


        private void OnLecturersCheckedListBoxItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_selectedLecture != default)
            {
                LecturersCheckedListBox.ItemCheck -= OnLecturersCheckedListBoxItemCheck;
                LecturersCheckedListBox.SetItemChecked(_selectedLecture.index, false);
                LecturersCheckedListBox.ItemCheck += OnLecturersCheckedListBoxItemCheck;
            }

            _selectedLecture = (e.Index, (SeminarLecturerDto)LecturersCheckedListBox.Items[e.Index]);
        }

        private void OnValidateFullName(object sender, CancelEventArgs e)
            => ValidateControl(
                FullNameTxt,
                !string.IsNullOrEmpty(FullNameTxt.Text),
                "Full Name Id Is Required",
                e);

        private void OnValidateLecturersCheckedListBox(object sender, CancelEventArgs e)
            => ValidateControl(
                LecturersCheckedListBox,
                _selectedLecture != default,
                "Lecturer Is Required",
                e);

        private void ValidateControl(Control ctrl, bool valid, string errorTxt, CancelEventArgs e)
        {
            if (valid)
            {
                e.Cancel = false;
                errorProvider.SetError(ctrl, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ctrl.Focus();
                errorProvider.SetError(ctrl, errorTxt);
            }
        }
    }
}
