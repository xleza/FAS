namespace FAS.UI.Sessions
{
    partial class SessionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SessionDetailsBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshSessionBtn = new FontAwesome.Sharp.IconButton();
            this.SessionAddBtn = new FontAwesome.Sharp.IconButton();
            this.SessionsGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.SessionDetailsBtn);
            this.panel1.Controls.Add(this.RefreshSessionBtn);
            this.panel1.Controls.Add(this.SessionAddBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 63);
            this.panel1.TabIndex = 0;
            // 
            // SessionDetailsBtn
            // 
            this.SessionDetailsBtn.Enabled = false;
            this.SessionDetailsBtn.FlatAppearance.BorderSize = 0;
            this.SessionDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionDetailsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SessionDetailsBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.SessionDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SessionDetailsBtn.IconSize = 48;
            this.SessionDetailsBtn.Location = new System.Drawing.Point(55, 6);
            this.SessionDetailsBtn.Name = "SessionDetailsBtn";
            this.SessionDetailsBtn.Rotation = 0D;
            this.SessionDetailsBtn.Size = new System.Drawing.Size(53, 57);
            this.SessionDetailsBtn.TabIndex = 18;
            this.SessionDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshSessionBtn
            // 
            this.RefreshSessionBtn.FlatAppearance.BorderSize = 0;
            this.RefreshSessionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshSessionBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshSessionBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshSessionBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshSessionBtn.IconSize = 48;
            this.RefreshSessionBtn.Location = new System.Drawing.Point(3, 7);
            this.RefreshSessionBtn.Name = "RefreshSessionBtn";
            this.RefreshSessionBtn.Rotation = 0D;
            this.RefreshSessionBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshSessionBtn.TabIndex = 17;
            this.RefreshSessionBtn.UseVisualStyleBackColor = true;
            this.RefreshSessionBtn.Click += new System.EventHandler(this.OnRefreshSessionBtnClick);
            // 
            // SessionAddBtn
            // 
            this.SessionAddBtn.FlatAppearance.BorderSize = 0;
            this.SessionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionAddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SessionAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.SessionAddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.SessionAddBtn.IconSize = 48;
            this.SessionAddBtn.Location = new System.Drawing.Point(110, 7);
            this.SessionAddBtn.Name = "SessionAddBtn";
            this.SessionAddBtn.Rotation = 0D;
            this.SessionAddBtn.Size = new System.Drawing.Size(53, 57);
            this.SessionAddBtn.TabIndex = 16;
            this.SessionAddBtn.UseVisualStyleBackColor = true;
            this.SessionAddBtn.Click += new System.EventHandler(this.OnSessionAddBtnClick);
            // 
            // SessionsGrid
            // 
            this.SessionsGrid.AllowUserToAddRows = false;
            this.SessionsGrid.AllowUserToDeleteRows = false;
            this.SessionsGrid.AutoGenerateColumns = false;
            this.SessionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lecturerFullNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.SessionsGrid.DataSource = this.sessionListItemDtoBindingSource;
            this.SessionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessionsGrid.Location = new System.Drawing.Point(0, 63);
            this.SessionsGrid.Name = "SessionsGrid";
            this.SessionsGrid.RowHeadersWidth = 51;
            this.SessionsGrid.RowTemplate.Height = 24;
            this.SessionsGrid.Size = new System.Drawing.Size(902, 421);
            this.SessionsGrid.TabIndex = 1;
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
            // lecturerFullNameDataGridViewTextBoxColumn
            // 
            this.lecturerFullNameDataGridViewTextBoxColumn.DataPropertyName = "LecturerFullName";
            this.lecturerFullNameDataGridViewTextBoxColumn.HeaderText = "LecturerFullName";
            this.lecturerFullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecturerFullNameDataGridViewTextBoxColumn.Name = "lecturerFullNameDataGridViewTextBoxColumn";
            this.lecturerFullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessionListItemDtoBindingSource
            // 
            this.sessionListItemDtoBindingSource.DataSource = typeof(FAS.UI.Sessions.Models.SessionsListItemDto);
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 484);
            this.Controls.Add(this.SessionsGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionsForm";
            this.Text = "Sessions";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SessionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SessionsGrid;
        private FontAwesome.Sharp.IconButton SessionDetailsBtn;
        private FontAwesome.Sharp.IconButton RefreshSessionBtn;
        private FontAwesome.Sharp.IconButton SessionAddBtn;
        private System.Windows.Forms.BindingSource sessionListItemDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}