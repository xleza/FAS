namespace FAS.UI.Admin.Lecturers
{
    partial class LecturerDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerDetailsForm));
            this.PersonalIdLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.PersonalIdValue = new System.Windows.Forms.Label();
            this.FullNameValue = new System.Windows.Forms.Label();
            this.BirthDateValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalIdLbl
            // 
            this.PersonalIdLbl.AutoSize = true;
            this.PersonalIdLbl.Location = new System.Drawing.Point(12, 30);
            this.PersonalIdLbl.Name = "PersonalIdLbl";
            this.PersonalIdLbl.Size = new System.Drawing.Size(91, 17);
            this.PersonalIdLbl.TabIndex = 0;
            this.PersonalIdLbl.Text = "Personal Id : ";
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(20, 70);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(79, 17);
            this.FullNameLbl.TabIndex = 1;
            this.FullNameLbl.Text = "Full Name :";
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Location = new System.Drawing.Point(20, 112);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(79, 17);
            this.BirthDateLbl.TabIndex = 2;
            this.BirthDateLbl.Text = "Birth Date :";
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(250, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(240, 176);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 3;
            this.ImageBox.TabStop = false;
            // 
            // PersonalIdValue
            // 
            this.PersonalIdValue.AutoSize = true;
            this.PersonalIdValue.Location = new System.Drawing.Point(109, 30);
            this.PersonalIdValue.Name = "PersonalIdValue";
            this.PersonalIdValue.Size = new System.Drawing.Size(0, 17);
            this.PersonalIdValue.TabIndex = 5;
            // 
            // FullNameValue
            // 
            this.FullNameValue.AutoSize = true;
            this.FullNameValue.Location = new System.Drawing.Point(109, 70);
            this.FullNameValue.Name = "FullNameValue";
            this.FullNameValue.Size = new System.Drawing.Size(0, 17);
            this.FullNameValue.TabIndex = 6;
            // 
            // BirthDateValue
            // 
            this.BirthDateValue.AutoSize = true;
            this.BirthDateValue.Location = new System.Drawing.Point(109, 112);
            this.BirthDateValue.Name = "BirthDateValue";
            this.BirthDateValue.Size = new System.Drawing.Size(0, 17);
            this.BirthDateValue.TabIndex = 7;
            // 
            // LecturerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 207);
            this.Controls.Add(this.BirthDateValue);
            this.Controls.Add(this.FullNameValue);
            this.Controls.Add(this.PersonalIdValue);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.FullNameLbl);
            this.Controls.Add(this.PersonalIdLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LecturerDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lecturer Details";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonalIdLbl;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label PersonalIdValue;
        private System.Windows.Forms.Label FullNameValue;
        private System.Windows.Forms.Label BirthDateValue;
    }
}