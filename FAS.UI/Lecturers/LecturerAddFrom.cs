using System;
using System.ComponentModel;
using System.Windows.Forms;
using FAS.Core.Commands.Lecturer;
using FAS.Core.Services;

namespace FAS.UI.Lecturers
{
    public partial class LecturerAddFrom : Form
    {
        private readonly LecturersCommandService _lecturersService;

        private byte[] _fingerPrintCheckSum;

        public LecturerAddFrom(LecturersCommandService lecturersService)
        {
            InitializeComponent();
            _lecturersService = lecturersService;
        }

        private void OnImgUpload(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = openFileDialog.FileName;
            }

            DialogResult = DialogResult.None;
        }

        private void OnOpenEnroller(object sender, EventArgs e)
        {
            var openEnrollmentDialog = DependencyResolver.Resolve<EnrollmentForm>();
            if (openEnrollmentDialog.ShowDialog() == DialogResult.OK)
            {
                _fingerPrintCheckSum = openEnrollmentDialog.FingerPrintCheckSum;
                FingerprintPicture.Image = openEnrollmentDialog.FingerPrintPicture;
            }

            DialogResult = DialogResult.None;
        }

        private async void OnSave(object sender, EventArgs e)
        {
            var valid = ValidateChildren(ValidationConstraints.Enabled);
            if (!valid)
                return;
            SaveBtn.Enabled = false;

            await _lecturersService.Create(new CreateLecturer
            {
                Id = PersonalIdTxt.Text,
                FullName = FullNameTxt.Text,
                FingerprintChecksum = _fingerPrintCheckSum,
                Image = ImageBox.Image.ToBytes(),
                BirthDate = BirthDatePicker.Value
            })
                .OnSuccess(() => MessageBoxWrapper.Info("Lecturer created successfully"))
                .OnError(MessageBoxWrapper.Error);

            SaveBtn.Enabled = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnValidatePersonalId(object sender, CancelEventArgs e)
            => ValidateControl(
                PersonalIdTxt,
                !string.IsNullOrEmpty(PersonalIdTxt.Text),
                $"{PersonalIdLbl.Name} Is Required",
                e);

        private void OnValidateFullName(object sender, CancelEventArgs e)
            => ValidateControl(
                FullNameTxt,
                !string.IsNullOrEmpty(FullNameTxt.Text),
                $"{FullNameLbl.Name} Is Required",
                e);

        private void OnValidateBirthDate(object sender, CancelEventArgs e)
            => ValidateControl(
                BirthDatePicker,
                BirthDatePicker.Value != default,
                $"{BirthDateLbl.Name} Is Required",
                e);

        private void OnValidateImage(object sender, CancelEventArgs e)
            => ValidateControl(
                ImageBox,
                ImageBox.Image != null,
                $"{ImageLbl.Name} Is Required",
                e);

        private void OnValidateFingerPrint(object sender, CancelEventArgs e)
            => ValidateControl(
                FingerprintPicture,
                FingerprintPicture.Image != null,
                $"{FingerPrintLbl.Name} Is Required",
                e);

        private void ValidateControl(Control ctrl, bool valid, string errorTxt, CancelEventArgs e)
        {
            if (valid)
            {
                e.Cancel = false;
                ErrorProvider.SetError(ctrl, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ctrl.Focus();
                ErrorProvider.SetError(ctrl, errorTxt);
            }
        }

    }
}
