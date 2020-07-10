namespace FAS.UI.Students
{
    partial class StudentAddFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAddFrom));
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PersonalIdLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ImageLbl = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.UploadImgBtn = new System.Windows.Forms.Button();
            this.FingerPrintLbl = new System.Windows.Forms.Label();
            this.FingerprintPicture = new System.Windows.Forms.PictureBox();
            this.OpenEnrollerBtn = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PersonalIdTxt = new System.Windows.Forms.MaskedTextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(146, 68);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(187, 22);
            this.FullNameTxt.TabIndex = 2;
            this.FullNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateFullName);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(146, 641);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 43);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.OnSave);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(240, 641);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 43);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // PersonalIdLbl
            // 
            this.PersonalIdLbl.AutoSize = true;
            this.PersonalIdLbl.Location = new System.Drawing.Point(12, 16);
            this.PersonalIdLbl.Name = "PersonalIdLbl";
            this.PersonalIdLbl.Size = new System.Drawing.Size(79, 17);
            this.PersonalIdLbl.TabIndex = 6;
            this.PersonalIdLbl.Text = "Personal Id";
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(12, 68);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(71, 17);
            this.FullNameLbl.TabIndex = 7;
            this.FullNameLbl.Text = "Full Name";
            // 
            // ImageLbl
            // 
            this.ImageLbl.AutoSize = true;
            this.ImageLbl.Location = new System.Drawing.Point(12, 163);
            this.ImageLbl.Name = "ImageLbl";
            this.ImageLbl.Size = new System.Drawing.Size(46, 17);
            this.ImageLbl.TabIndex = 8;
            this.ImageLbl.Text = "Image";
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.ImageBox.Location = new System.Drawing.Point(146, 163);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(187, 143);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 9;
            this.ImageBox.TabStop = false;
            this.ImageBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateImage);
            // 
            // UploadImgBtn
            // 
            this.UploadImgBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UploadImgBtn.Location = new System.Drawing.Point(166, 321);
            this.UploadImgBtn.Name = "UploadImgBtn";
            this.UploadImgBtn.Size = new System.Drawing.Size(146, 43);
            this.UploadImgBtn.TabIndex = 3;
            this.UploadImgBtn.Text = "Upload";
            this.UploadImgBtn.UseVisualStyleBackColor = true;
            this.UploadImgBtn.Click += new System.EventHandler(this.OnImgUpload);
            // 
            // FingerPrintLbl
            // 
            this.FingerPrintLbl.AutoSize = true;
            this.FingerPrintLbl.Location = new System.Drawing.Point(12, 391);
            this.FingerPrintLbl.Name = "FingerPrintLbl";
            this.FingerPrintLbl.Size = new System.Drawing.Size(81, 17);
            this.FingerPrintLbl.TabIndex = 11;
            this.FingerPrintLbl.Text = "Finger Print";
            // 
            // FingerprintPicture
            // 
            this.FingerprintPicture.BackColor = System.Drawing.SystemColors.Window;
            this.FingerprintPicture.Location = new System.Drawing.Point(146, 382);
            this.FingerprintPicture.Name = "FingerprintPicture";
            this.FingerprintPicture.Size = new System.Drawing.Size(187, 143);
            this.FingerprintPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FingerprintPicture.TabIndex = 12;
            this.FingerprintPicture.TabStop = false;
            this.FingerprintPicture.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateFingerPrint);
            // 
            // OpenEnrollerBtn
            // 
            this.OpenEnrollerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenEnrollerBtn.Location = new System.Drawing.Point(166, 546);
            this.OpenEnrollerBtn.Name = "OpenEnrollerBtn";
            this.OpenEnrollerBtn.Size = new System.Drawing.Size(146, 43);
            this.OpenEnrollerBtn.TabIndex = 4;
            this.OpenEnrollerBtn.Text = "Open Enroller";
            this.OpenEnrollerBtn.UseVisualStyleBackColor = true;
            this.OpenEnrollerBtn.Click += new System.EventHandler(this.OnOpenEnroller);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PersonalIdTxt
            // 
            this.PersonalIdTxt.Location = new System.Drawing.Point(146, 16);
            this.PersonalIdTxt.Mask = "00000000000";
            this.PersonalIdTxt.Name = "PersonalIdTxt";
            this.PersonalIdTxt.Size = new System.Drawing.Size(187, 22);
            this.PersonalIdTxt.TabIndex = 1;
            this.PersonalIdTxt.ValidatingType = typeof(System.DateTime);
            this.PersonalIdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatePersonalId);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.CustomFormat = "dd/MM/yyyy";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDatePicker.Location = new System.Drawing.Point(147, 113);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(187, 22);
            this.BirthDatePicker.TabIndex = 17;
            this.BirthDatePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateBirthDate);
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Location = new System.Drawing.Point(12, 115);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(71, 17);
            this.BirthDateLbl.TabIndex = 16;
            this.BirthDateLbl.Text = "Birth Date";
            // 
            // StudentAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(465, 707);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.PersonalIdTxt);
            this.Controls.Add(this.OpenEnrollerBtn);
            this.Controls.Add(this.FingerprintPicture);
            this.Controls.Add(this.FingerPrintLbl);
            this.Controls.Add(this.UploadImgBtn);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.ImageLbl);
            this.Controls.Add(this.FullNameLbl);
            this.Controls.Add(this.PersonalIdLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FullNameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentAddFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label PersonalIdLbl;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label ImageLbl;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button UploadImgBtn;
        private System.Windows.Forms.Label FingerPrintLbl;
        private System.Windows.Forms.PictureBox FingerprintPicture;
        private System.Windows.Forms.Button OpenEnrollerBtn;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.MaskedTextBox PersonalIdTxt;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label BirthDateLbl;
    }
}