namespace FAS.UI.Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.Panel();
            this.SeminarMenuBtn = new FontAwesome.Sharp.IconButton();
            this.LecturerMenuBtn = new FontAwesome.Sharp.IconButton();
            this.StudentsMenuBtn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeMenuBtn = new FontAwesome.Sharp.IconButton();
            this.Desktop = new System.Windows.Forms.Panel();
            this.studentsListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu.Controls.Add(this.SeminarMenuBtn);
            this.Menu.Controls.Add(this.LecturerMenuBtn);
            this.Menu.Controls.Add(this.StudentsMenuBtn);
            this.Menu.Controls.Add(this.Logo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(312, 546);
            this.Menu.TabIndex = 2;
            // 
            // SeminarMenuBtn
            // 
            this.SeminarMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.SeminarMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeminarMenuBtn.FlatAppearance.BorderSize = 0;
            this.SeminarMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeminarMenuBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeminarMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeminarMenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.SeminarMenuBtn.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.SeminarMenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SeminarMenuBtn.IconSize = 32;
            this.SeminarMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeminarMenuBtn.Location = new System.Drawing.Point(0, 353);
            this.SeminarMenuBtn.Name = "SeminarMenuBtn";
            this.SeminarMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SeminarMenuBtn.Rotation = 0D;
            this.SeminarMenuBtn.Size = new System.Drawing.Size(310, 75);
            this.SeminarMenuBtn.TabIndex = 4;
            this.SeminarMenuBtn.Text = "Seminars";
            this.SeminarMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeminarMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeminarMenuBtn.UseVisualStyleBackColor = false;
            this.SeminarMenuBtn.Click += new System.EventHandler(this.OnSeminarMenuBtnClick);
            // 
            // LecturerMenuBtn
            // 
            this.LecturerMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.LecturerMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LecturerMenuBtn.FlatAppearance.BorderSize = 0;
            this.LecturerMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerMenuBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.LecturerMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerMenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.LecturerMenuBtn.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.LecturerMenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.LecturerMenuBtn.IconSize = 32;
            this.LecturerMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LecturerMenuBtn.Location = new System.Drawing.Point(0, 278);
            this.LecturerMenuBtn.Name = "LecturerMenuBtn";
            this.LecturerMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LecturerMenuBtn.Rotation = 0D;
            this.LecturerMenuBtn.Size = new System.Drawing.Size(310, 75);
            this.LecturerMenuBtn.TabIndex = 3;
            this.LecturerMenuBtn.Text = "Lecturers";
            this.LecturerMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LecturerMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LecturerMenuBtn.UseVisualStyleBackColor = false;
            this.LecturerMenuBtn.Click += new System.EventHandler(this.OnLecturerMenuBtnClick);
            // 
            // StudentsMenuBtn
            // 
            this.StudentsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.StudentsMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsMenuBtn.FlatAppearance.BorderSize = 0;
            this.StudentsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsMenuBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.StudentsMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsMenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.StudentsMenuBtn.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.StudentsMenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.StudentsMenuBtn.IconSize = 32;
            this.StudentsMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsMenuBtn.Location = new System.Drawing.Point(0, 203);
            this.StudentsMenuBtn.Name = "StudentsMenuBtn";
            this.StudentsMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StudentsMenuBtn.Rotation = 0D;
            this.StudentsMenuBtn.Size = new System.Drawing.Size(310, 75);
            this.StudentsMenuBtn.TabIndex = 1;
            this.StudentsMenuBtn.Text = "Students";
            this.StudentsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudentsMenuBtn.UseVisualStyleBackColor = false;
            this.StudentsMenuBtn.Click += new System.EventHandler(this.OnStudentsMenuBtnClick);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(310, 203);
            this.Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FAS.UI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.HomeMenuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(312, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 70);
            this.panel1.TabIndex = 3;
            // 
            // HomeMenuBtn
            // 
            this.HomeMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.HomeMenuBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeMenuBtn.FlatAppearance.BorderSize = 0;
            this.HomeMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeMenuBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HomeMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeMenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.HomeMenuBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeMenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.HomeMenuBtn.IconSize = 32;
            this.HomeMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuBtn.Name = "HomeMenuBtn";
            this.HomeMenuBtn.Rotation = 0D;
            this.HomeMenuBtn.Size = new System.Drawing.Size(108, 68);
            this.HomeMenuBtn.TabIndex = 0;
            this.HomeMenuBtn.Text = "Home";
            this.HomeMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeMenuBtn.UseVisualStyleBackColor = false;
            this.HomeMenuBtn.Click += new System.EventHandler(this.OnHomeMenuBtnClick);
            // 
            // Desktop
            // 
            this.Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktop.Location = new System.Drawing.Point(312, 70);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(996, 476);
            this.Desktop.TabIndex = 4;
            // 
            // studentsListItemDtoBindingSource
            // 
            this.studentsListItemDtoBindingSource.DataSource = typeof(FAS.UI.Admin.Students.StudentsListItemDto);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1308, 546);
            this.Controls.Add(this.Desktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Fingerprint Attendance System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource studentsListItemDtoBindingSource;
        private System.Windows.Forms.Panel Menu;
        private FontAwesome.Sharp.IconButton StudentsMenuBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton HomeMenuBtn;
        private System.Windows.Forms.Panel Desktop;
        private FontAwesome.Sharp.IconButton SeminarMenuBtn;
        private FontAwesome.Sharp.IconButton LecturerMenuBtn;
    }
}

