namespace StudentSelecter
{
    using System;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using EnterpriseDT.Net.Ftp;
    using OpenTK.Audio.OpenAL;
    using StudentSelecter.Properties;

    /// <summary>
    /// The main window of the student selecter application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The names of the students who may be called upon.
        /// </summary>
        private StringCollection names = new StringCollection();

        /// <summary>
        /// The thread used to display the user's name in a delayed manner.
        /// </summary>
        private Thread delayThread;

        /// <summary>
        /// Our custom wave player used to play the wave file and keep track of events.
        /// </summary>
        private WavePlayer player = new WavePlayer(Resources.SongClip);

        /// <summary>
        /// The animation controller.
        /// </summary>
        private SelectionAnimation animation = new SelectionAnimation();

        /// <summary>
        /// The get name button.
        /// </summary>
        private ButtonControl getNameButton = new ButtonControl("Get a name");

        /// <summary>
        /// The configure button.
        /// </summary>
        private ButtonControl configureButton = new ButtonControl("Configure");

        /// <summary>
        /// Whether to show the UI buttons.
        /// </summary>
        private bool showUI;

        /// <summary>
        /// The last student name that was displayed, used to prevent the same name appearing twice in a row.
        /// </summary>
        private string lastName = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.names.Add("NO NAMES LOADED");

            this.InitializeComponent();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                new ThreadExceptionDialog(e).ShowDialog();
            }
        }

        /// <summary>
        /// Performs initialization operations.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Listen for play state change events
            this.player.SourceStateChanged += this.Player_SourceStateChanged;

            // Load the student names into the program
            this.LoadNames();

            this.getNameButton.Location = new Point(12, 12);
        }

        /// <summary>
        /// Paints the animation onto the GUI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            this.animation.Paint(e.Graphics, this.ClientRectangle);

            this.configureButton.Location = new Point(this.ClientSize.Width - this.configureButton.Size.Width - 12, 12);

            if (this.showUI)
            {
                this.getNameButton.Draw(e.Graphics);
                this.configureButton.Draw(e.Graphics);
            }

            Thread.Sleep(1);
            this.Invalidate();
        }

        /// <summary>
        /// Performs actions for the button clicks.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.showUI)
            {
                // Begins the process of generating a new student name
                if (this.getNameButton.Rectangle.Contains(e.Location) && this.getNameButton.Enabled)
                {
                    if (this.names.Count > 0)
                    {
                        // Disable the buttons and play the song
                        this.getNameButton.Enabled = false;
                        this.configureButton.Enabled = false;
                        this.player.Play();
                    }
                    else
                    {
                        MessageBox.Show("There are no names to select from. Please make sure you have an active Internet connection and FTP server configured.");
                    }
                }

                // Launches the configuration dialog
                if (this.configureButton.Rectangle.Contains(e.Location) && this.configureButton.Enabled)
                {
                    OptionsDialog dialog = new OptionsDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.LoadNames();
                    }
                }
            }
        }

        /// <summary>
        /// Shows the buttons when the mouse enters the window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            this.showUI = true;
        }

        /// <summary>
        /// Hides the buttons when the mouse leaves the window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            this.showUI = false;
        }

        /// <summary>
        /// Performs cleanup operations.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kill the delay thread if it's running
            if (this.delayThread != null && this.delayThread.IsAlive)
            {
                this.delayThread.Abort();
            }

            this.player.Dispose();
        }

        /// <summary>
        /// Notifies the animation controller and updates the UI on player source state changes.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Player_SourceStateChanged(object sender, EventArgs e)
        {
            this.animation.SourceState = this.player.SourceState;

            switch (this.player.SourceState)
            {
                case ALSourceState.Playing:
                    // Set the current user to nothing and invoke the delay thread
                    this.animation.CurrentUser = string.Empty;
                    this.delayThread = new Thread(new ThreadStart(this.GenerateNameWithDelay));
                    this.delayThread.Start();
                    break;
                case ALSourceState.Stopped:
                    // Enable the buttons for another try
                    this.getNameButton.Enabled = true;
                    this.configureButton.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Loads the student names from the remote server into the program.
        /// </summary>
        private void LoadNames()
        {
            try
            {
                FTPClient client = new FTPClient();
                client.RemoteHost = Settings.Default.DefaultFtpHost;
                client.Connect();
                client.Login(Settings.Default.DefaultFtpUserName, Settings.Default.DefaultFtpPassword);

                this.names.Clear();
                this.names.AddRange(Encoding.UTF8.GetString(client.Get(Settings.Default.DefaultFtpPath)).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
            }
            catch (Exception e)
            {
                new ThreadExceptionDialog(e).ShowDialog();
            }
        }

        /// <summary>
        /// Waits 8 seconds and then generates a student name.
        /// </summary>
        private void GenerateNameWithDelay()
        {
            try
            {
                Thread.Sleep(500);
                string name = string.Empty;
                do
                {
                    name = this.names[new Random().GenerateIndex(this.names)];
                }
                while (name == this.lastName);

                this.animation.CurrentUser = name;
                this.lastName = name;
            }
            catch (ThreadAbortException)
            {
            }
        }
    }
}
