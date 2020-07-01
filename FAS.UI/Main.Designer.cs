namespace FAS.UI
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StudentsTab = new System.Windows.Forms.TabPage();
            this.StudentsFilterBox = new System.Windows.Forms.GroupBox();
            this.StudentCommands = new System.Windows.Forms.ToolStrip();
            this.AddStudentBtn = new System.Windows.Forms.ToolStripButton();
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.PersonaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTab.SuspendLayout();
            this.StudentsTab.SuspendLayout();
            this.StudentCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.StudentsTab);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1277, 736);
            this.MainTab.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1269, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StudentsTab
            // 
            this.StudentsTab.Controls.Add(this.StudentsGrid);
            this.StudentsTab.Controls.Add(this.StudentCommands);
            this.StudentsTab.Controls.Add(this.StudentsFilterBox);
            this.StudentsTab.Location = new System.Drawing.Point(4, 25);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsTab.Size = new System.Drawing.Size(1269, 707);
            this.StudentsTab.TabIndex = 0;
            this.StudentsTab.Text = "Students";
            this.StudentsTab.UseVisualStyleBackColor = true;
            // 
            // StudentsFilterBox
            // 
            this.StudentsFilterBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentsFilterBox.Location = new System.Drawing.Point(3, 3);
            this.StudentsFilterBox.Name = "StudentsFilterBox";
            this.StudentsFilterBox.Size = new System.Drawing.Size(273, 701);
            this.StudentsFilterBox.TabIndex = 2;
            this.StudentsFilterBox.TabStop = false;
            this.StudentsFilterBox.Text = "Students Filter";
            // 
            // StudentCommands
            // 
            this.StudentCommands.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StudentCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentBtn});
            this.StudentCommands.Location = new System.Drawing.Point(276, 3);
            this.StudentCommands.Name = "StudentCommands";
            this.StudentCommands.Size = new System.Drawing.Size(990, 27);
            this.StudentCommands.TabIndex = 3;
            this.StudentCommands.Text = "toolStrip1";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStudentBtn.Image = global::FAS.UI.Properties.Resources.plus;
            this.AddStudentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(29, 24);
            this.AddStudentBtn.Text = "toolStripButton1";
            this.AddStudentBtn.Click += new System.EventHandler(this.OnAddStudent);
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonaId,
            this.FullName,
            this.BirthDate});
            this.StudentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsGrid.Location = new System.Drawing.Point(276, 30);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.ReadOnly = true;
            this.StudentsGrid.RowHeadersWidth = 51;
            this.StudentsGrid.RowTemplate.Height = 24;
            this.StudentsGrid.Size = new System.Drawing.Size(990, 674);
            this.StudentsGrid.TabIndex = 4;
            // 
            // PersonaId
            // 
            this.PersonaId.HeaderText = "PersonalId";
            this.PersonaId.MinimumWidth = 6;
            this.PersonaId.Name = "PersonaId";
            this.PersonaId.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 736);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTab.ResumeLayout(false);
            this.StudentsTab.ResumeLayout(false);
            this.StudentsTab.PerformLayout();
            this.StudentCommands.ResumeLayout(false);
            this.StudentCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage StudentsTab;
        private System.Windows.Forms.DataGridView StudentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.ToolStrip StudentCommands;
        private System.Windows.Forms.ToolStripButton AddStudentBtn;
        private System.Windows.Forms.GroupBox StudentsFilterBox;
    }
}

