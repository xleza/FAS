namespace FAS.UI.Reports
{
    partial class StudentAttendanceReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendanceReportForm));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RefreshReportBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SeminarsComboBox = new System.Windows.Forms.ComboBox();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentsAttendanceReportDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsAttendanceReportDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ButtonsPanel.Controls.Add(this.RefreshReportBtn);
            this.ButtonsPanel.Controls.Add(this.label1);
            this.ButtonsPanel.Controls.Add(this.SeminarsComboBox);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(976, 56);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // RefreshReportBtn
            // 
            this.RefreshReportBtn.FlatAppearance.BorderSize = 0;
            this.RefreshReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshReportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshReportBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshReportBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshReportBtn.IconSize = 48;
            this.RefreshReportBtn.Location = new System.Drawing.Point(293, 5);
            this.RefreshReportBtn.Name = "RefreshReportBtn";
            this.RefreshReportBtn.Rotation = 0D;
            this.RefreshReportBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshReportBtn.TabIndex = 18;
            this.RefreshReportBtn.UseVisualStyleBackColor = true;
            this.RefreshReportBtn.Click += new System.EventHandler(this.OnRefreshReportBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seminar";
            // 
            // SeminarsComboBox
            // 
            this.SeminarsComboBox.FormattingEnabled = true;
            this.SeminarsComboBox.Location = new System.Drawing.Point(113, 16);
            this.SeminarsComboBox.Name = "SeminarsComboBox";
            this.SeminarsComboBox.Size = new System.Drawing.Size(165, 24);
            this.SeminarsComboBox.TabIndex = 0;
            this.SeminarsComboBox.ValueMember = "Name";
            // 
            // ReportViewer
            // 
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentAttendanceDataset";
            reportDataSource1.Value = this.studentsAttendanceReportDtoBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "FAS.UI.Reports.StudentAttendanceReport.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(0, 70);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(1220, 623);
            this.ReportViewer.TabIndex = 1;
            // 
            // studentsAttendanceReportDtoBindingSource
            // 
            this.studentsAttendanceReportDtoBindingSource.DataSource = typeof(FAS.UI.Reports.Models.StudentsAttendanceReportDto);
            // 
            // StudentAttendanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 554);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.ButtonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentAttendanceReportForm";
            this.Text = "Attendance Report";
            this.Load += new System.EventHandler(this.AttendanceReportForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsAttendanceReportDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeminarsComboBox;
        private FontAwesome.Sharp.IconButton RefreshReportBtn;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource studentsAttendanceReportDtoBindingSource;
    }
}