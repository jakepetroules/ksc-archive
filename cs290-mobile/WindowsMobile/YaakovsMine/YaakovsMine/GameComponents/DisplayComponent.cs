namespace YaakovsMine
{
    using System.Drawing;
    using System.Globalization;
    using System.Text;
    using YaakovsMine.Properties;

    /// <summary>
    /// Represents the game's display, providing information to the user.
    /// </summary>
    public sealed class DisplayComponent : GameComponent
    {
        /// <summary>
        /// The font used to draw text.
        /// </summary>
        private Font font;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayComponent"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public DisplayComponent(Game game)
            : base(game)
        {
            this.font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        }

        /// <summary>
        /// Draws the display.
        /// </summary>
        /// <param name="g">The graphics context used to draw the display.</param>
        public override void Draw(Graphics g)
        {
            // Create a string containing the amount of rocks collected
            StringBuilder builderLeft = new StringBuilder();
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Coal, this.Game.RocksCollected[OresAndMetals.Coal]);
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Tin, this.Game.RocksCollected[OresAndMetals.Tin]);
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Copper, this.Game.RocksCollected[OresAndMetals.Copper]);
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Iron, this.Game.RocksCollected[OresAndMetals.Iron]);
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Mithril, this.Game.RocksCollected[OresAndMetals.Mithril]);
            builderLeft.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Densium, this.Game.RocksCollected[OresAndMetals.Densium]);
            builderLeft.AppendLine();

            // Let everyone know that the player's cheating ;)
            if (this.Game.CheatMode)
            {
                builderLeft.Append(Resources.CheatMode);
            }

            // Draw the amount of rocks collected as a shadowed string
            this.DrawDouble(g, builderLeft.ToString(), Color.Yellow, Color.Black, 4, 4);

            // Create a string containing character statistics and score
            StringBuilder builderRight = new StringBuilder();

            // If we're in cheat mode, our HP is INFINITE!
            if (this.Game.CheatMode)
            {
                builderRight.AppendFormat(CultureInfo.CurrentCulture, "{0}: \u221e\n\n", Resources.HP);
            }
            else
            {
                builderRight.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}/{2}\n\n", Resources.HP, this.Game.Character.Hitpoints, this.Game.Character.MaximumHitpoints);
            }

            builderRight.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.PickaxeType, this.Game.Character.PickaxeLevel);
            builderRight.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n\n", Resources.VialsOfNitroglycerin, this.Game.CheatMode ? "\u221e" : this.Game.Character.Nitroglycerin.ToString());
            builderRight.AppendFormat(CultureInfo.CurrentCulture, "{0}: {1}\n", Resources.Score, this.Game.Score);

            // Draw the statistics and score as a right-aligned string
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            format.Alignment = StringAlignment.Far;
            this.DrawDouble(g, builderRight.ToString(), Color.Yellow, Color.Black, new RectangleF(4, 4, this.Game.ScreenSize.Width - 8, 0), format);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.font != null)
                {
                    this.font.Dispose();
                }
            }
        }

        /// <summary>
        /// Draws a shadowed string.
        /// </summary>
        /// <param name="g">The graphics context used to draw the string.</param>
        /// <param name="s">The string to draw.</param>
        /// <param name="primary">The primary text color.</param>
        /// <param name="secondary">The text shadow color.</param>
        /// <param name="x">The X coordinate of the top-left corner of the string.</param>
        /// <param name="y">The Y coordinate of the top-left corner of the string.</param>
        private void DrawDouble(Graphics g, string s, Color primary, Color secondary, float x, float y)
        {
            g.DrawString(s, this.font, new SolidBrush(secondary), x + 1, y + 1);
            g.DrawString(s, this.font, new SolidBrush(primary), x, y);
        }

        /// <summary>
        /// Draws a shadowed string.
        /// </summary>
        /// <param name="g">The graphics context used to draw the string.</param>
        /// <param name="s">The string to draw.</param>
        /// <param name="primary">The primary text color.</param>
        /// <param name="secondary">The text shadow color.</param>
        /// <param name="layout">The layout rectangle representing the bounds of the string.</param>
        /// <param name="format">A <see cref="StringFormat"/> object representing the alignment of the string within <paramref name="layout"/>.</param>
        private void DrawDouble(Graphics g, string s, Color primary, Color secondary, RectangleF layout, StringFormat format)
        {
            RectangleF shadow = new RectangleF(layout.X + 1, layout.Y + 1, layout.Width, layout.Height);
            g.DrawString(s, this.font, new SolidBrush(secondary), shadow, format);
            g.DrawString(s, this.font, new SolidBrush(primary), layout, format);
        }
    }
}
