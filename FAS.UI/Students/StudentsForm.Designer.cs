namespace FAS.UI.Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.StudentsFilterBox = new System.Windows.Forms.GroupBox();
            this.StudentCommands = new System.Windows.Forms.ToolStrip();
            this.AddStudentBtn = new System.Windows.Forms.ToolStripButton();
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.StudentCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsFilterBox
            // 
            this.StudentsFilterBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentsFilterBox.Location = new System.Drawing.Point(0, 0);
            this.StudentsFilterBox.Name = "StudentsFilterBox";
            this.StudentsFilterBox.Size = new System.Drawing.Size(273, 754);
            this.StudentsFilterBox.TabIndex = 3;
            this.StudentsFilterBox.TabStop = false;
            this.StudentsFilterBox.Text = "Students Filter";
            // 
            // StudentCommands
            // 
            this.StudentCommands.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentCommands.Dock = System.Windows.Forms.DockStyle.None;
            this.StudentCommands.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StudentCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentBtn,
            this.toolStripButton1});
            this.StudentCommands.Location = new System.Drawing.Point(373, 53);
            this.StudentCommands.Name = "StudentCommands";
            this.StudentCommands.Size = new System.Drawing.Size(71, 27);
            this.StudentCommands.TabIndex = 4;
            this.StudentCommands.Text = "toolStrip1";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStudentBtn.Image = global::FAS.UI.Properties.Resources.plus;
            this.AddStudentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(29, 36);
            this.AddStudentBtn.Text = "toolStripButton1";
            this.AddStudentBtn.Click += new System.EventHandler(this.OnAddStudent);
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.AutoGenerateColumns = false;
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.StudentsGrid.DataSource = this.studentsListItemDtoBindingSource;
            this.StudentsGrid.Location = new System.Drawing.Point(273, 142);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.ReadOnly = true;
            this.StudentsGrid.RowHeadersWidth = 51;
            this.StudentsGrid.RowTemplate.Height = 24;
            this.StudentsGrid.Size = new System.Drawing.Size(1121, 612);
            this.StudentsGrid.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsListItemDtoBindingSource
            // 
            this.studentsListItemDtoBindingSource.DataSource = typeof(FAS.UI.Models.StudentsListItemDto);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(904, 32);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(119, 48);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 754);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.StudentsGrid);
            this.Controls.Add(this.StudentCommands);
            this.Controls.Add(this.StudentsFilterBox);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.StudentCommands.ResumeLayout(false);
            this.StudentCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentsFilterBox;
        private System.Windows.Forms.ToolStrip StudentCommands;
        private System.Windows.Forms.ToolStripButton AddStudentBtn;
        private System.Windows.Forms.DataGridView StudentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsListItemDtoBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}