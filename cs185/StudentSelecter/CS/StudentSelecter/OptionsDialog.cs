namespace StudentSelecter
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using EnterpriseDT.Net.Ftp;

    /// <summary>
    /// The options dialog of the student selecter.
    /// </summary>
    public partial class OptionsDialog : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsDialog"/> class.
        /// </summary>
        public OptionsDialog()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the student names from the FTP server.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// Loads the student names from the FTP server.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// Saves the student names to the FTP server.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        /// <summary>
        /// Shows or hides the characters in the password box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CheckBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedTextBoxPass.PasswordChar = this.checkBoxShow.Checked ? '\0' : '*';
        }

        /// <summary>
        /// Loads data from the server into the text box.
        /// </summary>
        private void LoadData()
        {
            try
            {
                FTPClient client = new FTPClient();
                client.RemoteHost = this.textBoxHost.Text;
                client.Connect();
                client.Login(this.textBoxUser.Text, this.maskedTextBoxPass.Text);
                this.textBoxStudents.Text = Encoding.UTF8.GetString(client.Get(this.textBoxPath.Text));
                this.textBoxStudents.Enabled = true;
                client.Quit();
            }
            catch (Exception ex)
            {
                this.textBoxStudents.Enabled = false;
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Saves data from the text box onto the server.
        /// </summary>
        private void SaveData()
        {
            try
            {
                FTPClient client = new FTPClient();
                client.RemoteHost = this.textBoxHost.Text;
                client.Connect();
                client.Login(this.textBoxUser.Text, this.maskedTextBoxPass.Text);
                client.Put(Encoding.UTF8.GetBytes(this.textBoxStudents.Text), this.textBoxPath.Text);
                client.Quit();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.textBoxStudents.Enabled = false;
                if (MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
