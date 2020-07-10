﻿namespace FAS.UI.Seminars
{
    partial class AddSeminarForm
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
            this.LecturerLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.LecturersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LecturerLbl
            // 
            this.LecturerLbl.AutoSize = true;
            this.LecturerLbl.Location = new System.Drawing.Point(19, 69);
            this.LecturerLbl.Name = "LecturerLbl";
            this.LecturerLbl.Size = new System.Drawing.Size(61, 17);
            this.LecturerLbl.TabIndex = 22;
            this.LecturerLbl.Text = "Lecturer";
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(12, 22);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(71, 17);
            this.FullNameLbl.TabIndex = 21;
            this.FullNameLbl.Text = "Full Name";
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(104, 22);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(229, 22);
            this.FullNameTxt.TabIndex = 19;
            this.FullNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateFullName);
            // 
            // LecturersCheckedListBox
            // 
            this.LecturersCheckedListBox.CheckOnClick = true;
            this.LecturersCheckedListBox.FormattingEnabled = true;
            this.LecturersCheckedListBox.Location = new System.Drawing.Point(104, 69);
            this.LecturersCheckedListBox.Name = "LecturersCheckedListBox";
            this.LecturersCheckedListBox.Size = new System.Drawing.Size(229, 225);
            this.LecturersCheckedListBox.TabIndex = 24;
            this.LecturersCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnLecturersCheckedListBoxItemCheck);
            this.LecturersCheckedListBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateLecturersCheckedListBox);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(221, 316);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 43);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(127, 316);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 43);
            this.SaveBtn.TabIndex = 25;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.OnSave);
            // 
            // AddSeminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 378);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LecturersCheckedListBox);
            this.Controls.Add(this.LecturerLbl);
            this.Controls.Add(this.FullNameLbl);
            this.Controls.Add(this.FullNameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSeminarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeminarForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LecturerLbl;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.CheckedListBox LecturersCheckedListBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}