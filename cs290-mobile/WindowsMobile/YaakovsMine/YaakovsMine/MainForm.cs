namespace YaakovsMine
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// The main window of the Yaakov's Mine game.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The instance of the Yaakov's Mine game.
        /// </summary>
        private Game game;

        /// <summary>
        /// The back buffer used to prevent flickering.
        /// </summary>
        private Image backBuffer;

        /// <summary>
        /// The graphics object used to paint on the back buffer.
        /// </summary>
        private Graphics bufferGraphics;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Instantiates and initializes the game.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnLoad(EventArgs e)
        {
            this.game = new Game();
            this.game.Initialize(this.ClientSize);
        }

        /// <summary>
        /// Overrides the <see cref="Form.OnPaintBackground"/> to prevent background painting.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // This is intentionally overridden to prevent background painting
        }

        /// <summary>
        /// Creates a loop, updating and drawing the game continually.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Check the back buffer to make sure it's initialized and properly sized
            this.CheckBackBuffer(e.Graphics, this.game.ScreenSize);

            // Update the state of and draw the game
            this.game.Update();
            this.game.Draw(this.bufferGraphics);

            // Present the game's back buffer
            e.Graphics.DrawImage(this.backBuffer, 0, 0);

            // Wait a millisecond and then update and draw the game again
            Thread.Sleep(1);
            this.Invalidate();
        }

        /// <summary>
        /// Check the back buffer to make sure it's initialized and properly sized.
        /// </summary>
        /// <param name="g">The graphics context used to draw the back buffer.</param>
        /// <param name="screen">The size of the game screen.</param>
        private void CheckBackBuffer(Graphics g, Size screen)
        {
            if (this.bufferGraphics == null || this.backBuffer == null || this.backBuffer.Size != screen)
            {
                this.backBuffer = new Bitmap(screen.Width, screen.Height);
                this.bufferGraphics = Graphics.FromImage(this.backBuffer);
            }
        }

        /// <summary>
        /// Cleans up resources when the application is closed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            this.game.Dispose();
        }
    }
}