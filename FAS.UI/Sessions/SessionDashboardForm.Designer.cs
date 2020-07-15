namespace FAS.UI.Sessions
{
    partial class SessionDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionDashboardForm));
            this.RegisteredNum = new System.Windows.Forms.Panel();
            this.RegisteredCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttendingCountLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotAttendingCountLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StopSessionBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ElapsedMinutesLbl = new System.Windows.Forms.Label();
            this.SeminarNameLbl = new System.Windows.Forms.Label();
            this.SeminarLbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.LogList = new System.Windows.Forms.ListView();
            this.FingerprintBox = new System.Windows.Forms.PictureBox();
            this.AttendanceChart = new LiveCharts.WinForms.PieChart();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisteredNum.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisteredNum
            // 
            this.RegisteredNum.BackColor = System.Drawing.Color.White;
            this.RegisteredNum.Controls.Add(this.RegisteredCountLbl);
            this.RegisteredNum.Controls.Add(this.label1);
            this.RegisteredNum.Location = new System.Drawing.Point(9, 64);
            this.RegisteredNum.Name = "RegisteredNum";
            this.RegisteredNum.Size = new System.Drawing.Size(270, 209);
            this.RegisteredNum.TabIndex = 1;
            // 
            // RegisteredCountLbl
            // 
            this.RegisteredCountLbl.AutoSize = true;
            this.RegisteredCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisteredCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RegisteredCountLbl.Location = new System.Drawing.Point(111, 89);
            this.RegisteredCountLbl.Name = "RegisteredCountLbl";
            this.RegisteredCountLbl.Size = new System.Drawing.Size(47, 51);
            this.RegisteredCountLbl.TabIndex = 1;
            this.RegisteredCountLbl.Text = "0";
            this.RegisteredCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisteredCountLbl.MouseLeave += new System.EventHandler(this.OnRegisteredCountLblMouseLeave);
            this.RegisteredCountLbl.MouseHover += new System.EventHandler(this.OnRegisteredCountLblMouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AttendingCountLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(285, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 209);
            this.panel1.TabIndex = 2;
            // 
            // AttendingCountLbl
            // 
            this.AttendingCountLbl.AutoSize = true;
            this.AttendingCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.AttendingCountLbl.Location = new System.Drawing.Point(105, 89);
            this.AttendingCountLbl.Name = "AttendingCountLbl";
            this.AttendingCountLbl.Size = new System.Drawing.Size(47, 51);
            this.AttendingCountLbl.TabIndex = 1;
            this.AttendingCountLbl.Text = "0";
            this.AttendingCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AttendingCountLbl.MouseLeave += new System.EventHandler(this.OnAttendingCountLblMouseLeave);
            this.AttendingCountLbl.MouseHover += new System.EventHandler(this.OnAttendingCountLblMouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.label4.Location = new System.Drawing.Point(82, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attending";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.NotAttendingCountLbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(561, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 209);
            this.panel2.TabIndex = 3;
            // 
            // NotAttendingCountLbl
            // 
            this.NotAttendingCountLbl.AutoSize = true;
            this.NotAttendingCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAttendingCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.NotAttendingCountLbl.Location = new System.Drawing.Point(111, 89);
            this.NotAttendingCountLbl.Name = "NotAttendingCountLbl";
            this.NotAttendingCountLbl.Size = new System.Drawing.Size(47, 51);
            this.NotAttendingCountLbl.TabIndex = 1;
            this.NotAttendingCountLbl.Text = "0";
            this.NotAttendingCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NotAttendingCountLbl.MouseLeave += new System.EventHandler(this.OnNotAttendingCountLblMouseLeave);
            this.NotAttendingCountLbl.MouseHover += new System.EventHandler(this.OnNotAttendingCountLblMouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.label6.Location = new System.Drawing.Point(70, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Not Attending";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.StopSessionBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ElapsedMinutesLbl);
            this.panel3.Controls.Add(this.SeminarNameLbl);
            this.panel3.Controls.Add(this.SeminarLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 58);
            this.panel3.TabIndex = 4;
            // 
            // StopSessionBtn
            // 
            this.StopSessionBtn.FlatAppearance.BorderSize = 0;
            this.StopSessionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopSessionBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.StopSessionBtn.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.StopSessionBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.StopSessionBtn.IconSize = 37;
            this.StopSessionBtn.Location = new System.Drawing.Point(516, 11);
            this.StopSessionBtn.Name = "StopSessionBtn";
            this.StopSessionBtn.Rotation = 0D;
            this.StopSessionBtn.Size = new System.Drawing.Size(53, 48);
            this.StopSessionBtn.TabIndex = 20;
            this.StopSessionBtn.UseVisualStyleBackColor = true;
            this.StopSessionBtn.Click += new System.EventHandler(this.OnStopSessionBtnClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.label7.Location = new System.Drawing.Point(293, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Elapsed Minutes:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ElapsedMinutesLbl
            // 
            this.ElapsedMinutesLbl.AutoSize = true;
            this.ElapsedMinutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElapsedMinutesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.ElapsedMinutesLbl.Location = new System.Drawing.Point(450, 20);
            this.ElapsedMinutesLbl.Name = "ElapsedMinutesLbl";
            this.ElapsedMinutesLbl.Size = new System.Drawing.Size(19, 20);
            this.ElapsedMinutesLbl.TabIndex = 4;
            this.ElapsedMinutesLbl.Text = "0";
            // 
            // SeminarNameLbl
            // 
            this.SeminarNameLbl.AutoSize = true;
            this.SeminarNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeminarNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SeminarNameLbl.Location = new System.Drawing.Point(10, 19);
            this.SeminarNameLbl.Name = "SeminarNameLbl";
            this.SeminarNameLbl.Size = new System.Drawing.Size(84, 20);
            this.SeminarNameLbl.TabIndex = 1;
            this.SeminarNameLbl.Text = "Seminar:";
            this.SeminarNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SeminarLbl
            // 
            this.SeminarLbl.AutoSize = true;
            this.SeminarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeminarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SeminarLbl.Location = new System.Drawing.Point(94, 19);
            this.SeminarLbl.Name = "SeminarLbl";
            this.SeminarLbl.Size = new System.Drawing.Size(132, 20);
            this.SeminarLbl.TabIndex = 0;
            this.SeminarLbl.Text = "Linear Algebra";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LogList);
            this.panel4.Controls.Add(this.FingerprintBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 165);
            this.panel4.TabIndex = 5;
            // 
            // LogList
            // 
            this.LogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogList.HideSelection = false;
            this.LogList.Location = new System.Drawing.Point(0, 0);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(603, 165);
            this.LogList.TabIndex = 1;
            this.LogList.UseCompatibleStateImageBehavior = false;
            this.LogList.View = System.Windows.Forms.View.Details;
            // 
            // FingerprintBox
            // 
            this.FingerprintBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FingerprintBox.Location = new System.Drawing.Point(603, 0);
            this.FingerprintBox.Name = "FingerprintBox";
            this.FingerprintBox.Size = new System.Drawing.Size(231, 165);
            this.FingerprintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FingerprintBox.TabIndex = 0;
            this.FingerprintBox.TabStop = false;
            // 
            // AttendanceChart
            // 
            this.AttendanceChart.Location = new System.Drawing.Point(215, 279);
            this.AttendanceChart.Name = "AttendanceChart";
            this.AttendanceChart.Size = new System.Drawing.Size(393, 250);
            this.AttendanceChart.TabIndex = 6;
            this.AttendanceChart.Text = "pieChart1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 550;
            // 
            // SessionDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 700);
            this.Controls.Add(this.AttendanceChart);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisteredNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.RegisteredNum.ResumeLayout(false);
            this.RegisteredNum.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel RegisteredNum;
        private System.Windows.Forms.Label RegisteredCountLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AttendingCountLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NotAttendingCountLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ElapsedMinutesLbl;
        private System.Windows.Forms.Label SeminarNameLbl;
        private System.Windows.Forms.Label SeminarLbl;
        private FontAwesome.Sharp.IconButton StopSessionBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox FingerprintBox;
        private System.Windows.Forms.ListView LogList;
        private LiveCharts.WinForms.PieChart AttendanceChart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}