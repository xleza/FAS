namespace FAS.UI.Admin.Seminars
{
    partial class AddSeminarAttendeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeminarAttendeeForm));
            this.Attendees = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Attendees
            // 
            this.Attendees.CheckBoxes = true;
            this.Attendees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FullName,
            this.BirthDate});
            this.Attendees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Attendees.HideSelection = false;
            this.Attendees.Location = new System.Drawing.Point(0, 0);
            this.Attendees.Name = "Attendees";
            this.Attendees.Size = new System.Drawing.Size(402, 368);
            this.Attendees.TabIndex = 0;
            this.Attendees.UseCompatibleStateImageBehavior = false;
            this.Attendees.View = System.Windows.Forms.View.Details;
            this.Attendees.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnAttendeesItemCheck);
            // 
            // Id
            // 
            this.Id.Text = "Personal Id";
            this.Id.Width = 126;
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.Width = 147;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "BirthDate";
            this.BirthDate.Width = 125;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.White;
            this.Ok.Enabled = false;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(165, 380);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(107, 42);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.OnOkClick);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(283, 380);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(107, 42);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // AddSeminarAttendeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(402, 436);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Attendees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSeminarAttendeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Seminar Attendee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Attendees;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}