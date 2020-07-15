namespace FAS.UI.Admin.Seminars
{
    partial class SeminarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeminarsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeminarAddBtn = new FontAwesome.Sharp.IconButton();
            this.SeminarAttendeesBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshSeminarsBtn = new FontAwesome.Sharp.IconButton();
            this.SeminarsGrid = new System.Windows.Forms.DataGridView();
            this.seminarsListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeminarsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarsListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.SeminarAddBtn);
            this.panel1.Controls.Add(this.SeminarAttendeesBtn);
            this.panel1.Controls.Add(this.RefreshSeminarsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 64);
            this.panel1.TabIndex = 0;
            // 
            // SeminarAddBtn
            // 
            this.SeminarAddBtn.FlatAppearance.BorderSize = 0;
            this.SeminarAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeminarAddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeminarAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.SeminarAddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SeminarAddBtn.IconSize = 48;
            this.SeminarAddBtn.Location = new System.Drawing.Point(52, 8);
            this.SeminarAddBtn.Name = "SeminarAddBtn";
            this.SeminarAddBtn.Rotation = 0D;
            this.SeminarAddBtn.Size = new System.Drawing.Size(53, 57);
            this.SeminarAddBtn.TabIndex = 16;
            this.SeminarAddBtn.UseVisualStyleBackColor = true;
            this.SeminarAddBtn.Click += new System.EventHandler(this.OnSeminarAddBtnClick);
            // 
            // SeminarAttendeesBtn
            // 
            this.SeminarAttendeesBtn.Enabled = false;
            this.SeminarAttendeesBtn.FlatAppearance.BorderSize = 0;
            this.SeminarAttendeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeminarAttendeesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeminarAttendeesBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.SeminarAttendeesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SeminarAttendeesBtn.IconSize = 48;
            this.SeminarAttendeesBtn.Location = new System.Drawing.Point(102, 8);
            this.SeminarAttendeesBtn.Name = "SeminarAttendeesBtn";
            this.SeminarAttendeesBtn.Rotation = 0D;
            this.SeminarAttendeesBtn.Size = new System.Drawing.Size(53, 57);
            this.SeminarAttendeesBtn.TabIndex = 19;
            this.SeminarAttendeesBtn.UseVisualStyleBackColor = true;
            this.SeminarAttendeesBtn.Click += new System.EventHandler(this.OnSeminarAttendeesBtnClick);
            // 
            // RefreshSeminarsBtn
            // 
            this.RefreshSeminarsBtn.FlatAppearance.BorderSize = 0;
            this.RefreshSeminarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshSeminarsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshSeminarsBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshSeminarsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshSeminarsBtn.IconSize = 48;
            this.RefreshSeminarsBtn.Location = new System.Drawing.Point(3, 8);
            this.RefreshSeminarsBtn.Name = "RefreshSeminarsBtn";
            this.RefreshSeminarsBtn.Rotation = 0D;
            this.RefreshSeminarsBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshSeminarsBtn.TabIndex = 17;
            this.RefreshSeminarsBtn.UseVisualStyleBackColor = true;
            this.RefreshSeminarsBtn.Click += new System.EventHandler(this.OnRefreshSeminarsBtnClick);
            // 
            // SeminarsGrid
            // 
            this.SeminarsGrid.AllowUserToAddRows = false;
            this.SeminarsGrid.AllowUserToDeleteRows = false;
            this.SeminarsGrid.AutoGenerateColumns = false;
            this.SeminarsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeminarsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lecturerIdDataGridViewTextBoxColumn,
            this.lecturerNameDataGridViewTextBoxColumn});
            this.SeminarsGrid.DataSource = this.seminarsListItemDtoBindingSource;
            this.SeminarsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeminarsGrid.Location = new System.Drawing.Point(0, 64);
            this.SeminarsGrid.Name = "SeminarsGrid";
            this.SeminarsGrid.RowHeadersWidth = 51;
            this.SeminarsGrid.RowTemplate.Height = 24;
            this.SeminarsGrid.Size = new System.Drawing.Size(1005, 609);
            this.SeminarsGrid.TabIndex = 1;
            this.SeminarsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnSeminarsGridCellClick);
            // 
            // seminarsListItemDtoBindingSource
            // 
            this.seminarsListItemDtoBindingSource.DataSource = typeof(FAS.UI.Admin.Seminars.Models.SeminarsListItemDto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecturerIdDataGridViewTextBoxColumn
            // 
            this.lecturerIdDataGridViewTextBoxColumn.DataPropertyName = "LecturerId";
            this.lecturerIdDataGridViewTextBoxColumn.HeaderText = "Personal Id";
            this.lecturerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecturerIdDataGridViewTextBoxColumn.Name = "lecturerIdDataGridViewTextBoxColumn";
            this.lecturerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecturerNameDataGridViewTextBoxColumn
            // 
            this.lecturerNameDataGridViewTextBoxColumn.DataPropertyName = "LecturerName";
            this.lecturerNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.lecturerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecturerNameDataGridViewTextBoxColumn.Name = "lecturerNameDataGridViewTextBoxColumn";
            this.lecturerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // SeminarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 673);
            this.Controls.Add(this.SeminarsGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeminarsForm";
            this.Text = "Seminars";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeminarsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarsListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SeminarsGrid;
        private System.Windows.Forms.BindingSource seminarsListItemDtoBindingSource;
        private FontAwesome.Sharp.IconButton RefreshSeminarsBtn;
        private FontAwesome.Sharp.IconButton SeminarAddBtn;
        private FontAwesome.Sharp.IconButton SeminarAttendeesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerNameDataGridViewTextBoxColumn;
    }
}