namespace StudentSelecter
{
    using System.Drawing;
    using System.Drawing.Text;

    /// <summary>
    /// Represents a simple GDI+ button control.
    /// </summary>
    public sealed class ButtonControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonControl"/> class with the specified label.
        /// </summary>
        /// <param name="label">The text on the button.</param>
        public ButtonControl(string label)
        {
            this.Label = label;
            this.Enabled = true;
            this.Size = new Size(125, 25);
        }

        /// <summary>
        /// Gets or sets the location of the button on the screen.
        /// </summary>
        public Point Location
        {
            get { return this.Rectangle.Location; }
            set { this.Rectangle = new Rectangle(value, this.Rectangle.Size); }
        }

        /// <summary>
        /// Gets or sets the size of the button in pixels.
        /// </summary>
        public Size Size
        {
            get { return this.Rectangle.Size; }
            set { this.Rectangle = new Rectangle(this.Rectangle.Location, value); }
        }

        /// <summary>
        /// Gets or sets the bounding rectangle of the button.
        /// </summary>
        public Rectangle Rectangle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text on the button.
        /// </summary>
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the button is enabled.
        /// </summary>
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the button.
        /// </summary>
        /// <param name="g">The graphics context used to draw the button.</param>
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), this.Rectangle);
            g.DrawRectangle(new Pen(Color.White), this.Rectangle);

            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.DrawString(this.Label, new Font(FontFamily.GenericSansSerif, 13), new SolidBrush(this.Enabled ? Color.White : Color.Gray), this.Rectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
    }
}
