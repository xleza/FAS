using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAS.Core.Commands.Seminars;
using FAS.Core.Services;
using FAS.Persistence;
using FAS.Admin.UI.Seminars.Models;

namespace FAS.Admin.UI.Seminars
{
    public partial class AddSeminarForm : Form
    {
        private readonly IQueryDao _queryDao;
        private readonly SeminarCommandService _seminarService;

        private (int index, SeminarLecturerDto) _selectedLecture;

        public AddSeminarForm(IQueryDao queryDao, SeminarCommandService seminarService)
        {
            InitializeComponent();

            _queryDao = queryDao;
            _seminarService = seminarService;

#pragma warning disable 4014
            FillLecturersAsync();
#pragma warning restore 4014
        }

        private async Task FillLecturersAsync()
        {
            var lecturers = await _queryDao.ListAsync<SeminarLecturerDto>()
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
