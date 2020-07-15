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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.Panel();
            this.SessionsMenuBtn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileName = new System.Windows.Forms.Label();
            this.ProfileBtn = new FontAwesome.Sharp.IconButton();
            this.HomeMenuBtn = new FontAwesome.Sharp.IconButton();
            this.Desktop = new System.Windows.Forms.Panel();
            this.studentsListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu.Controls.Add(this.SessionsMenuBtn);
            this.Menu.Controls.Add(this.Logo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(312, 546);
            this.Menu.TabIndex = 2;
            // 
            // SessionsMenuBtn
            // 
            this.SessionsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.SessionsMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SessionsMenuBtn.FlatAppearance.BorderSize = 0;
            this.SessionsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionsMenuBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SessionsMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionsMenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.SessionsMenuBtn.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.SessionsMenuBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SessionsMenuBtn.IconSize = 32;
            this.SessionsMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SessionsMenuBtn.Location = new System.Drawing.Point(0, 203);
            this.SessionsMenuBtn.Name = "SessionsMenuBtn";
            this.SessionsMenuBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SessionsMenuBtn.Rotation = 0D;
            this.SessionsMenuBtn.Size = new System.Drawing.Size(310, 75);
            this.SessionsMenuBtn.TabIndex = 1;
            this.SessionsMenuBtn.Text = "Sessions";
            this.SessionsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SessionsMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SessionsMenuBtn.UseVisualStyleBackColor = false;
            this.SessionsMenuBtn.Click += new System.EventHandler(this.OnSessionsMenuBtnClick);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.LogoBox);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(310, 203);
            this.Logo.TabIndex = 0;
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::FAS.UI.Properties.Resources.logo;
            this.LogoBox.Location = new System.Drawing.Point(21, 22);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(264, 147);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ProfileBtn);
            this.panel1.Controls.Add(this.HomeMenuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(312, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 70);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProfileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(594, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 68);
            this.panel2.TabIndex = 7;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.Location = new System.Drawing.Point(91, 21);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(97, 25);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.Text = "John Doe";
            this.ProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ProfileBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.ProfileBtn.IconSize = 32;
            this.ProfileBtn.Location = new System.Drawing.Point(888, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Rotation = 0D;
            this.ProfileBtn.Size = new System.Drawing.Size(106, 68);
            this.ProfileBtn.TabIndex = 6;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            this.ProfileBtn.Click += new System.EventHandler(this.OnProfileBtnClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource studentsListItemDtoBindingSource;
        private System.Windows.Forms.Panel Menu;
        private FontAwesome.Sharp.IconButton SessionsMenuBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton HomeMenuBtn;
        private System.Windows.Forms.Panel Desktop;
        private FontAwesome.Sharp.IconButton ProfileBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProfileName;
    }
}

