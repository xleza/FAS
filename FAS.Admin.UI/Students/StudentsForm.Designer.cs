namespace FAS.Admin.UI.Students
{
    partial class StudentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudentDetailsBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshStudentBtn = new FontAwesome.Sharp.IconButton();
            this.StudentAddBtn = new FontAwesome.Sharp.IconButton();
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.studentsListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.StudentDetailsBtn);
            this.panel2.Controls.Add(this.RefreshStudentBtn);
            this.panel2.Controls.Add(this.StudentAddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 64);
            this.panel2.TabIndex = 9;
            // 
            // StudentDetailsBtn
            // 
            this.StudentDetailsBtn.Enabled = false;
            this.StudentDetailsBtn.FlatAppearance.BorderSize = 0;
            this.StudentDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentDetailsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.StudentDetailsBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.StudentDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.StudentDetailsBtn.IconSize = 48;
            this.StudentDetailsBtn.Location = new System.Drawing.Point(58, 7);
            this.StudentDetailsBtn.Name = "StudentDetailsBtn";
            this.StudentDetailsBtn.Rotation = 0D;
            this.StudentDetailsBtn.Size = new System.Drawing.Size(53, 57);
            this.StudentDetailsBtn.TabIndex = 15;
            this.StudentDetailsBtn.UseVisualStyleBackColor = true;
            this.StudentDetailsBtn.Click += new System.EventHandler(this.OnDetailsStudent);
            // 
            // RefreshStudentBtn
            // 
            this.RefreshStudentBtn.FlatAppearance.BorderSize = 0;
            this.RefreshStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshStudentBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshStudentBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshStudentBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshStudentBtn.IconSize = 48;
            this.RefreshStudentBtn.Location = new System.Drawing.Point(6, 8);
            this.RefreshStudentBtn.Name = "RefreshStudentBtn";
            this.RefreshStudentBtn.Rotation = 0D;
            this.RefreshStudentBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshStudentBtn.TabIndex = 13;
            this.RefreshStudentBtn.UseVisualStyleBackColor = true;
            this.RefreshStudentBtn.Click += new System.EventHandler(this.OnRefresh);
            // 
            // StudentAddBtn
            // 
            this.StudentAddBtn.FlatAppearance.BorderSize = 0;
            this.StudentAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentAddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.StudentAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.StudentAddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.StudentAddBtn.IconSize = 48;
            this.StudentAddBtn.Location = new System.Drawing.Point(114, 8);
            this.StudentAddBtn.Name = "StudentAddBtn";
            this.StudentAddBtn.Rotation = 0D;
            this.StudentAddBtn.Size = new System.Drawing.Size(53, 57);
            this.StudentAddBtn.TabIndex = 12;
            this.StudentAddBtn.UseVisualStyleBackColor = true;
            this.StudentAddBtn.Click += new System.EventHandler(this.OnAddStudent);
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.AllowUserToAddRows = false;
            this.StudentsGrid.AllowUserToDeleteRows = false;
            this.StudentsGrid.AutoGenerateColumns = false;
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.StudentsGrid.DataSource = this.studentsListItemDtoBindingSource;
            this.StudentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsGrid.Location = new System.Drawing.Point(0, 64);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.ReadOnly = true;
            this.StudentsGrid.RowHeadersWidth = 51;
            this.StudentsGrid.RowTemplate.Height = 24;
            this.StudentsGrid.Size = new System.Drawing.Size(1365, 690);
            this.StudentsGrid.TabIndex = 10;
            this.StudentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnStudentsGridCellClick);
            this.StudentsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnStudentsGridCellDoubleClick);
            // 
            // studentsListItemDtoBindingSource
            // 
            this.studentsListItemDtoBindingSource.DataSource = typeof(FAS.Admin.UI.Students.StudentsListItemDto);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Personal Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Birth Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 754);
            this.Controls.Add(this.StudentsGrid);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton StudentAddBtn;
        private FontAwesome.Sharp.IconButton RefreshStudentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton StudentDetailsBtn;
        private System.Windows.Forms.DataGridView StudentsGrid;
        private System.Windows.Forms.BindingSource studentsListItemDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}