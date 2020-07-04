using System;
using System.ComponentModel;
using System.Windows.Forms;
using FAS.Core.Commands.Students;
using FAS.Core.Services;

namespace FAS.UI
{
    public partial class StudentAddFrom : Form
    {
        private readonly StudentsCommandService _studentsService;

        private byte[] _fingerPrintCheckSum;

        public StudentAddFrom(StudentsCommandService studentsService)
        {
            InitializeComponent();
            _studentsService = studentsService;
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

            await _studentsService.CreateAsync(new CreateStudent
            {
                Id = PersonalIdTxt.Text,
                FullName = FullNameTxt.Text,
                FingerprintChecksum = _fingerPrintCheckSum,
                FingerprintImage = FingerprintPicture.Image.ToBytes(),
                Image = ImageBox.Image.ToBytes(),
                BirthDate = DateTime.Now
            })
                .OnSuccess(() => MessageBoxWrapper.Info("Student created successfully"))
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
