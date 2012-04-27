namespace StudentSelecter
{
    using System;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.Drawing.Text;
    using OpenTK.Audio.OpenAL;

    /// <summary>
    /// Represents the animation shown when selecting a student name.
    /// </summary>
    public sealed class SelectionAnimation
    {
        /// <summary>
        /// The random object used to generate random numbers.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// The collection of circles that will be drawn.
        /// </summary>
        private Collection<Rectangle> circleRects = new Collection<Rectangle>();

        /// <summary>
        /// The font used to draw background characters.
        /// </summary>
        private Font backgroundCharacterFont = new Font(FontFamily.GenericSerif, 13);

        /// <summary>
        /// The font used to draw student names.
        /// </summary>
        private Font studentNameFont = new Font(FontFamily.GenericSerif, 72);

        /// <summary>
        /// The number of characters of a student's name to draw for the current paint operation.
        /// </summary>
        private int nameCharacterCount = 0;

        /// <summary>
        /// The last point at which we added another character of the student's name to the screen.
        /// </summary>
        private DateTime lastDraw = DateTime.UtcNow;

        /// <summary>
        /// The location of the question mark.
        /// </summary>
        private Point questionMarkLocation;

        /// <summary>
        /// The last point at which the location of the question mark was changed.
        /// </summary>
        private DateTime lastQuestionMarkChange = DateTime.UtcNow;

        /// <summary>
        /// The name of the student who has been selected to answer a question.
        /// </summary>
        private string currentUser = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionAnimation"/> class.
        /// </summary>
        public SelectionAnimation()
        {
            // Add 10 circle rectangles to our collection
            for (int i = 0; i < 10; i++)
            {
                this.circleRects.Add(Rectangle.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the name of the student who has been selected to answer a question;
        /// <see cref="string.Empty"/> if no one is currently selected.
        /// </summary>
        public string CurrentUser
        {
            get
            {
                return this.currentUser;
            }

            set
            {
                this.currentUser = value;
                this.nameCharacterCount = 0;
            }
        }

        /// <summary>
        /// Gets or sets the state of the audio source; whether it is playing, paused or stopped.
        /// </summary>
        public ALSourceState SourceState
        {
            get;
            set;
        }

        /// <summary>
        /// Paints the animation.
        /// </summary>
        /// <param name="g">The graphics context used to draw the animation.</param>
        /// <param name="clientRectangle">The client rectangle of the drawing surface.</param>
        public void Paint(Graphics g, Rectangle clientRectangle)
        {
            // Clear the background color to black
            g.Clear(Color.Black);

            // Draw the background artifacts and circles
            this.ResetCircles(clientRectangle);
            this.DrawCircles(g);
            this.DrawBackgroundCharacters(g, clientRectangle);
            this.DrawQuestionMark(g, clientRectangle);

            // Use crisp antialiased text rendering
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            // We draw a character every 0.05 seconds
            string studentName = this.currentUser.Substring(0, Math.Min(this.nameCharacterCount, this.currentUser.Length));

            // By default, the student name font is the one we have saved
            Font studentNameFont = this.studentNameFont;

            // If we're still playing the song, though, it should vibrate between the size of the name font and that value plus 3 ems
            if (this.SourceState == ALSourceState.Playing)
            {
                studentNameFont = new Font(FontFamily.GenericSerif, this.random.GenerateNumber((int)this.studentNameFont.Size, (int)this.studentNameFont.Size + 3));
            }

            // By default, the student name font is drawn in white.
            Color studentNameColor = Color.White;

            // If we're still playing the song, though, it should be a random color
            if (this.SourceState == ALSourceState.Playing)
            {
                studentNameColor = this.random.GenerateColor();
            }

            // Draw the student's name in the center of the form with a random color
            g.DrawString(studentName, studentNameFont, new SolidBrush(studentNameColor), clientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

            // If 0.05 seconds have passed, we can draw an additional character next time
            if ((DateTime.UtcNow - this.lastDraw).TotalSeconds > 0.05)
            {
                // The last time we added a character was NOW
                this.lastDraw = DateTime.UtcNow;

                // Draw an additional character next time
                this.nameCharacterCount++;
            }
        }

        /// <summary>
        /// Draws a question mark at a random location on the screen.
        /// </summary>
        /// <param name="g">The graphics context to draw the characters with.</param>
        /// <param name="clientRectangle">The client rectangle of the drawing surface.</param>
        private void DrawQuestionMark(Graphics g, Rectangle clientRectangle)
        {
            if ((DateTime.UtcNow - this.lastQuestionMarkChange).TotalSeconds > 0.5)
            {
                this.questionMarkLocation = new Point(this.random.GenerateNumber(100, clientRectangle.Width - 100), this.random.GenerateNumber(100, clientRectangle.Height - 100));
                this.lastQuestionMarkChange = DateTime.UtcNow;
            }

            // Only draw the question mark if the music is playing and we don't have a name yet
            if (this.SourceState == ALSourceState.Playing && string.IsNullOrEmpty(this.currentUser))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.DrawString("?", this.studentNameFont, new SolidBrush(Color.White), this.questionMarkLocation);
            }
        }

        /// <summary>
        /// Draws 50 random capital letters from the Latin alphabet in various colors and at various positions on the screen.
        /// </summary>
        /// <param name="g">The graphics context to draw the characters with.</param>
        /// <param name="clientRectangle">The client rectangle of the drawing surface.</param>
        private void DrawBackgroundCharacters(Graphics g, Rectangle clientRectangle)
        {
            // Only draw the background characters if the music is playing
            if (this.SourceState == ALSourceState.Playing)
            {
                for (int i = 0; i < 50; i++)
                {
                    g.DrawString(this.random.GenerateCharacterString('A', 'Z'), this.backgroundCharacterFont, new SolidBrush(this.random.GenerateColor()), this.random.GenerateNumber(0, clientRectangle.Width), this.random.GenerateNumber(0, clientRectangle.Height));
                }
            }
        }

        /// <summary>
        /// Goes through all the circle rectangles, checking whether any of them need to be reset to minimum size.
        /// </summary>
        /// <param name="clientRectangle">The client rectangle of the drawing surface.</param>
        private void ResetCircles(Rectangle clientRectangle)
        {
            for (int i = 0; i < this.circleRects.Count; i++)
            {
                // If the circles' bounding rectangles are empty or they are too big and thus off-screen...
                if (this.circleRects[i] == Rectangle.Empty || this.circleRects[i].Width > clientRectangle.Width || this.circleRects[i].Height > clientRectangle.Height)
                {
                    // ...then regenerate an empty bounding rectangle for the circle at a random point on the screen
                    this.circleRects[i] = new Rectangle(this.random.GenerateNumber(0, clientRectangle.Width), this.random.GenerateNumber(0, clientRectangle.Height), 0, 0);
                }
            }
        }

        /// <summary>
        /// Draws each circle on the screen, but only if the music is playing.
        /// </summary>
        /// <param name="g">The graphics context to draw the circles with.</param>
        private void DrawCircles(Graphics g)
        {
            // Only draw the expanding circles if the music is playing
            if (this.SourceState == ALSourceState.Playing)
            {
                for (int i = 0; i < this.circleRects.Count; i++)
                {
                    // Draw each of our circles with a random color
                    g.DrawEllipse(new Pen(new SolidBrush(this.random.GenerateColor())), this.circleRects[i]);

                    // Inflate each circle by 3 pixels on each axis
                    this.circleRects[i] = Rectangle.Inflate(this.circleRects[i], 3, 3);
                }
            }
        }
    }
}
