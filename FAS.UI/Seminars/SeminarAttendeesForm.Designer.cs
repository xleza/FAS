namespace FAS.UI.Seminars
{
    partial class SeminarAttendeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeminarAttendeesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveSeminarAttendeeBtn = new FontAwesome.Sharp.IconButton();
            this.AddSeminarAttendeeBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshSeminarAttendeesBtn = new FontAwesome.Sharp.IconButton();
            this.AttendeesGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seminarAttendeesListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarAttendeesListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveSeminarAttendeeBtn);
            this.panel1.Controls.Add(this.AddSeminarAttendeeBtn);
            this.panel1.Controls.Add(this.RefreshSeminarAttendeesBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 64);
            this.panel1.TabIndex = 0;
            // 
            // RemoveSeminarAttendeeBtn
            // 
            this.RemoveSeminarAttendeeBtn.Enabled = false;
            this.RemoveSeminarAttendeeBtn.FlatAppearance.BorderSize = 0;
            this.RemoveSeminarAttendeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSeminarAttendeeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RemoveSeminarAttendeeBtn.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.RemoveSeminarAttendeeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RemoveSeminarAttendeeBtn.IconSize = 48;
            this.RemoveSeminarAttendeeBtn.Location = new System.Drawing.Point(101, 9);
            this.RemoveSeminarAttendeeBtn.Name = "RemoveSeminarAttendeeBtn";
            this.RemoveSeminarAttendeeBtn.Rotation = 0D;
            this.RemoveSeminarAttendeeBtn.Size = new System.Drawing.Size(53, 57);
            this.RemoveSeminarAttendeeBtn.TabIndex = 20;
            this.RemoveSeminarAttendeeBtn.UseVisualStyleBackColor = true;
            this.RemoveSeminarAttendeeBtn.Click += new System.EventHandler(this.OnRemoveSeminarAttendeeBtnClick);
            // 
            // AddSeminarAttendeeBtn
            // 
            this.AddSeminarAttendeeBtn.FlatAppearance.BorderSize = 0;
            this.AddSeminarAttendeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSeminarAttendeeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddSeminarAttendeeBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.AddSeminarAttendeeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.AddSeminarAttendeeBtn.IconSize = 48;
            this.AddSeminarAttendeeBtn.Location = new System.Drawing.Point(52, 9);
            this.AddSeminarAttendeeBtn.Name = "AddSeminarAttendeeBtn";
            this.AddSeminarAttendeeBtn.Rotation = 0D;
            this.AddSeminarAttendeeBtn.Size = new System.Drawing.Size(53, 57);
            this.AddSeminarAttendeeBtn.TabIndex = 18;
            this.AddSeminarAttendeeBtn.UseVisualStyleBackColor = true;
            this.AddSeminarAttendeeBtn.Click += new System.EventHandler(this.OnAddSeminarAttendeeBtnClick);
            // 
            // RefreshSeminarAttendeesBtn
            // 
            this.RefreshSeminarAttendeesBtn.FlatAppearance.BorderSize = 0;
            this.RefreshSeminarAttendeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshSeminarAttendeesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshSeminarAttendeesBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshSeminarAttendeesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshSeminarAttendeesBtn.IconSize = 48;
            this.RefreshSeminarAttendeesBtn.Location = new System.Drawing.Point(3, 8);
            this.RefreshSeminarAttendeesBtn.Name = "RefreshSeminarAttendeesBtn";
            this.RefreshSeminarAttendeesBtn.Rotation = 0D;
            this.RefreshSeminarAttendeesBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshSeminarAttendeesBtn.TabIndex = 19;
            this.RefreshSeminarAttendeesBtn.UseVisualStyleBackColor = true;
            // 
            // AttendeesGrid
            // 
            this.AttendeesGrid.AllowUserToAddRows = false;
            this.AttendeesGrid.AllowUserToDeleteRows = false;
            this.AttendeesGrid.AutoGenerateColumns = false;
            this.AttendeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendeesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
            this.AttendeesGrid.DataSource = this.seminarAttendeesListItemDtoBindingSource;
            this.AttendeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendeesGrid.Location = new System.Drawing.Point(0, 64);
            this.AttendeesGrid.Name = "AttendeesGrid";
            this.AttendeesGrid.RowHeadersWidth = 51;
            this.AttendeesGrid.RowTemplate.Height = 24;
            this.AttendeesGrid.Size = new System.Drawing.Size(984, 514);
            this.AttendeesGrid.TabIndex = 1;
            this.AttendeesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnAttendeesGridCellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Personal Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationTimeDataGridViewTextBoxColumn
            // 
            this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "RegistrationTime";
            this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "Registration Time";
            this.registrationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
            this.registrationTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // seminarAttendeesListItemDtoBindingSource
            // 
            this.seminarAttendeesListItemDtoBindingSource.DataSource = typeof(FAS.UI.Seminars.Models.SeminarAttendeesListItemDto);
            // 
            // SeminarAttendeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 578);
            this.Controls.Add(this.AttendeesGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeminarAttendeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seminar Attendees";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarAttendeesListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AttendeesGrid;
        private FontAwesome.Sharp.IconButton RemoveSeminarAttendeeBtn;
        private FontAwesome.Sharp.IconButton AddSeminarAttendeeBtn;
        private FontAwesome.Sharp.IconButton RefreshSeminarAttendeesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seminarAttendeesListItemDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
    }
}