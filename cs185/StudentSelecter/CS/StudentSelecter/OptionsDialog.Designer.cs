namespace StudentSelecter
{
    partial class OptionsDialog
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
            this.groupBoxDataLocation = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxPass = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxStudents = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxDataLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataLocation
            // 
            this.groupBoxDataLocation.Controls.Add(this.buttonLoad);
            this.groupBoxDataLocation.Controls.Add(this.checkBoxShow);
            this.groupBoxDataLocation.Controls.Add(this.maskedTextBoxPass);
            this.groupBoxDataLocation.Controls.Add(this.labelPassword);
            this.groupBoxDataLocation.Controls.Add(this.textBoxUser);
            this.groupBoxDataLocation.Controls.Add(this.labelUsername);
            this.groupBoxDataLocation.Controls.Add(this.textBoxPath);
            this.groupBoxDataLocation.Controls.Add(this.labelPath);
            this.groupBoxDataLocation.Controls.Add(this.textBoxHost);
            this.groupBoxDataLocation.Controls.Add(this.labelHost);
            this.groupBoxDataLocation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDataLocation.Name = "groupBoxDataLocation";
            this.groupBoxDataLocation.Size = new System.Drawing.Size(300, 175);
            this.groupBoxDataLocation.TabIndex = 0;
            this.groupBoxDataLocation.TabStop = false;
            this.groupBoxDataLocation.Text = "Data location";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(219, 146);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(70, 127);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(106, 17);
            this.checkBoxShow.TabIndex = 8;
            this.checkBoxShow.Text = "Show characters";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.CheckBoxShow_CheckedChanged);
            // 
            // maskedTextBoxPass
            // 
            this.maskedTextBoxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StudentSelecter.Properties.Settings.Default, "DefaultFtpPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maskedTextBoxPass.Location = new System.Drawing.Point(70, 101);
            this.maskedTextBoxPass.Name = "maskedTextBoxPass";
            this.maskedTextBoxPass.PasswordChar = '*';
            this.maskedTextBoxPass.Size = new System.Drawing.Size(150, 20);
            this.maskedTextBoxPass.TabIndex = 7;
            this.maskedTextBoxPass.Text = global::StudentSelecter.Properties.Settings.Default.DefaultFtpPassword;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StudentSelecter.Properties.Settings.Default, "DefaultFtpUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUser.Location = new System.Drawing.Point(70, 74);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 20);
            this.textBoxUser.TabIndex = 5;
            this.textBoxUser.Text = global::StudentSelecter.Properties.Settings.Default.DefaultFtpUserName;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(6, 77);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StudentSelecter.Properties.Settings.Default, "DefaultFtpPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPath.Location = new System.Drawing.Point(70, 47);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(150, 20);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.Text = global::StudentSelecter.Properties.Settings.Default.DefaultFtpPath;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 50);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Path:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StudentSelecter.Properties.Settings.Default, "DefaultFtpHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHost.Location = new System.Drawing.Point(70, 20);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(150, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.Text = global::StudentSelecter.Properties.Settings.Default.DefaultFtpHost;
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(6, 23);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(32, 13);
            this.labelHost.TabIndex = 0;
            this.labelHost.Text = "Host:";
            // 
            // textBoxStudents
            // 
            this.textBoxStudents.Enabled = false;
            this.textBoxStudents.Location = new System.Drawing.Point(318, 12);
            this.textBoxStudents.Multiline = true;
            this.textBoxStudents.Name = "textBoxStudents";
            this.textBoxStudents.Size = new System.Drawing.Size(264, 337);
            this.textBoxStudents.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(93, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxStudents);
            this.Controls.Add(this.groupBoxDataLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.groupBoxDataLocation.ResumeLayout(false);
            this.groupBoxDataLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataLocation;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPass;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxStudents;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}