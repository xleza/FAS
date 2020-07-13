namespace FAS.UI.Sessions
{
    partial class AddSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSessionForm));
            this.Sessions = new System.Windows.Forms.ComboBox();
            this.sessionsDropDownListItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddSessionBtn = new System.Windows.Forms.Button();
            this.CancelSessionBtn = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDropDownListItemDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Sessions
            // 
            this.Sessions.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sessionsDropDownListItemDtoBindingSource, "Id", true));
            this.Sessions.DataSource = this.sessionsDropDownListItemDtoBindingSource;
            this.Sessions.DisplayMember = "Name";
            this.Sessions.FormattingEnabled = true;
            this.Sessions.Location = new System.Drawing.Point(32, 26);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(204, 24);
            this.Sessions.TabIndex = 0;
            this.Sessions.ValueMember = "Id";
            this.Sessions.Validating += new System.ComponentModel.CancelEventHandler(this.SessionsValidating);
            // 
            // sessionsDropDownListItemDtoBindingSource
            // 
            this.sessionsDropDownListItemDtoBindingSource.DataSource = typeof(FAS.UI.Sessions.Models.SessionsDropDownListItemDto);
            // 
            // AddSessionBtn
            // 
            this.AddSessionBtn.Location = new System.Drawing.Point(32, 70);
            this.AddSessionBtn.Name = "AddSessionBtn";
            this.AddSessionBtn.Size = new System.Drawing.Size(93, 30);
            this.AddSessionBtn.TabIndex = 1;
            this.AddSessionBtn.Text = "OK";
            this.AddSessionBtn.UseVisualStyleBackColor = true;
            this.AddSessionBtn.Click += new System.EventHandler(this.OnAddSessionBtnClick);
            // 
            // CancelSessionBtn
            // 
            this.CancelSessionBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSessionBtn.Location = new System.Drawing.Point(143, 70);
            this.CancelSessionBtn.Name = "CancelSessionBtn";
            this.CancelSessionBtn.Size = new System.Drawing.Size(93, 30);
            this.CancelSessionBtn.TabIndex = 2;
            this.CancelSessionBtn.Text = "Cancel";
            this.CancelSessionBtn.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelSessionBtn;
            this.ClientSize = new System.Drawing.Size(266, 123);
            this.Controls.Add(this.CancelSessionBtn);
            this.Controls.Add(this.AddSessionBtn);
            this.Controls.Add(this.Sessions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Session";
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDropDownListItemDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Sessions;
        private System.Windows.Forms.Button AddSessionBtn;
        private System.Windows.Forms.Button CancelSessionBtn;
        private System.Windows.Forms.BindingSource sessionsDropDownListItemDtoBindingSource;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}