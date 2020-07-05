﻿namespace FAS.UI.Lecturers
{
    partial class LecturersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LecturerDetailsBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshLecturerBtn = new FontAwesome.Sharp.IconButton();
            this.LecturerAddBtn = new FontAwesome.Sharp.IconButton();
            this.LecturersGrid = new System.Windows.Forms.DataGridView();
            this.lecturersListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersListItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 754);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LecturerDetailsBtn);
            this.panel2.Controls.Add(this.RefreshLecturerBtn);
            this.panel2.Controls.Add(this.LecturerAddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 65);
            this.panel2.TabIndex = 9;
            // 
            // LecturerDetailsBtn
            // 
            this.LecturerDetailsBtn.Enabled = false;
            this.LecturerDetailsBtn.FlatAppearance.BorderSize = 0;
            this.LecturerDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerDetailsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.LecturerDetailsBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.LecturerDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.LecturerDetailsBtn.IconSize = 48;
            this.LecturerDetailsBtn.Location = new System.Drawing.Point(58, 7);
            this.LecturerDetailsBtn.Name = "LecturerDetailsBtn";
            this.LecturerDetailsBtn.Rotation = 0D;
            this.LecturerDetailsBtn.Size = new System.Drawing.Size(53, 57);
            this.LecturerDetailsBtn.TabIndex = 15;
            this.LecturerDetailsBtn.UseVisualStyleBackColor = true;
            this.LecturerDetailsBtn.Click += new System.EventHandler(this.OnLecturerDetails);
            // 
            // RefreshLecturerBtn
            // 
            this.RefreshLecturerBtn.FlatAppearance.BorderSize = 0;
            this.RefreshLecturerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshLecturerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RefreshLecturerBtn.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.RefreshLecturerBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.RefreshLecturerBtn.IconSize = 48;
            this.RefreshLecturerBtn.Location = new System.Drawing.Point(6, 8);
            this.RefreshLecturerBtn.Name = "RefreshLecturerBtn";
            this.RefreshLecturerBtn.Rotation = 0D;
            this.RefreshLecturerBtn.Size = new System.Drawing.Size(53, 57);
            this.RefreshLecturerBtn.TabIndex = 13;
            this.RefreshLecturerBtn.UseVisualStyleBackColor = true;
            this.RefreshLecturerBtn.Click += new System.EventHandler(this.OnRefresh);
            // 
            // LecturerAddBtn
            // 
            this.LecturerAddBtn.FlatAppearance.BorderSize = 0;
            this.LecturerAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerAddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.LecturerAddBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.LecturerAddBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(134)))));
            this.LecturerAddBtn.IconSize = 48;
            this.LecturerAddBtn.Location = new System.Drawing.Point(114, 8);
            this.LecturerAddBtn.Name = "LecturerAddBtn";
            this.LecturerAddBtn.Rotation = 0D;
            this.LecturerAddBtn.Size = new System.Drawing.Size(53, 57);
            this.LecturerAddBtn.TabIndex = 12;
            this.LecturerAddBtn.UseVisualStyleBackColor = true;
            this.LecturerAddBtn.Click += new System.EventHandler(this.OnLecturerAdd);
            // 
            // LecturersGrid
            // 
            this.LecturersGrid.AllowUserToAddRows = false;
            this.LecturersGrid.AllowUserToDeleteRows = false;
            this.LecturersGrid.AutoGenerateColumns = false;
            this.LecturersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.LecturersGrid.DataSource = this.lecturersListItemDtoBindingSource;
            this.LecturersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturersGrid.Location = new System.Drawing.Point(252, 65);
            this.LecturersGrid.Name = "LecturersGrid";
            this.LecturersGrid.ReadOnly = true;
            this.LecturersGrid.RowHeadersWidth = 51;
            this.LecturersGrid.RowTemplate.Height = 24;
            this.LecturersGrid.Size = new System.Drawing.Size(1121, 689);
            this.LecturersGrid.TabIndex = 10;
            this.LecturersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnLecturersGridCellClick);
            this.LecturersGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnLecturersGridCellDoubleClick);
            // 
            // lecturersListItemDtoBindingSource
            // 
            this.lecturersListItemDtoBindingSource.DataSource = typeof(FAS.UI.Lecturers.Models.LecturersListItemDto);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // LecturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 754);
            this.Controls.Add(this.LecturersGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LecturersForm";
            this.Text = "LecturersForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LecturersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersListItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton LecturerAddBtn;
        private FontAwesome.Sharp.IconButton RefreshLecturerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton LecturerDetailsBtn;
        private System.Windows.Forms.DataGridView LecturersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource lecturersListItemDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}