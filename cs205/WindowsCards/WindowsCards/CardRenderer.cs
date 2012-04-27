namespace Petroules.WindowsCards
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Petroules.WindowsCards.Properties;

    /// <summary>
    /// Provides a .NET-friendy API to Windows' cards.dll used in Windows card games.
    /// </summary>
    public sealed class CardRenderer
    {
        /// <summary>
        /// Initializes the cards.dll library for the application.
        /// </summary>
        /// <param name="width">[out] Returns the width (in pixels) of the cards.</param>
        /// <param name="height">[out] Returns the height (in pixels) of the cards.</param>
        /// <returns>Whether the library was successfully initialized.</returns>
        [DllImport("cards.dll")]
        private static extern bool cdtInit(ref int width, ref int height);

        /// <summary>
        /// This function differs from <c>cdtDrawExt</c> only in that cdtDrawExt provides width and height parameters used to stretch the destination bitmap from its initialized size.
        /// <see cref="cdtDrawExt"/>
        /// </summary>
        [DllImport("cards.dll")]
        private static extern bool cdtDraw(IntPtr hdc, int x, int y, int card, CardType type, int color);

        /// <summary>
        /// Draws a card at position <paramref name="x"/>, <paramref name="y"/> on the device context <paramref name="hdc"/>.
        /// </summary>
        /// <param name="hdc">The device context to draw on.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="dx">The width of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="dy">The height of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="card">
        /// The card to draw. This value is dependent on the value of <paramref name="type"/>.
        /// If a card face is to be drawn (<paramref name="type"/> is 0 or 2), then <paramref name="card"/> must be an integer from 0 to 51 (a combination of the face and suit).
        /// If a card back is to be drawn (<paramref name="type"/> is 1), then <paramref name="card"/> must be an integer from 53 to 68 (inclusive) to represent one of the possible card backs.
        /// The card faces are organized in increasing order, identified by an integer from 0 to 12 (inclusive) where Ace is 0 and King is 12.
        /// </param>
        /// <param name="type">Controls the type of card to draw, which determines the applicable values of <paramref name="card"/>.</param>
        /// <param name="color">The background color for the crosshatch background. Has no effect with other background types.</param>
        /// <returns>Whether the card was drawn.</returns>
        [DllImport("cards.dll")]
        private static extern bool cdtDrawExt(IntPtr hdc, int x, int y, int dx, int dy, int card, CardType type, int color);

        /// <summary>
        /// Animates the backs of cards by overlaying part of the card back with an alternative bitmap.
        /// It creates effects: blinking lights on the robot, the sun donning sunglasses,
        /// bats flying across the castle, and a card sliding out of a sleeve.
        /// 
        /// The function works only for cards of normal size drawn with <see cref="cdtDraw"/>.
        /// To draw each state, start with <paramref name="frame"/> set to 0 and increment
        /// through until this function returns <c>false</c>.
        /// </summary>
        /// <param name="hdc">The device context to draw on.</param>
        /// <param name="cardback">The background of the card.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="frame">The frame index.</param>
        /// <returns>Whether the animation should draw another frame.</returns>
        [DllImport("cards.dll")]
        private static extern bool cdtAnimate(IntPtr hdc, int cardback, int x, int y, int frame);

        /// <summary>
        /// Cleans up the card resources from the application.
        /// </summary>
        [DllImport("cards.dll")]
        private static extern void cdtTerm();

        /// <summary>
        /// The singleton instance.
        /// </summary>
        private static CardRenderer singleton;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardRenderer"/> class.
        /// </summary>
        /// <exception cref="InvalidOperationException">An instance of CardRenderer already exists. -or- Failed to initialize the cards.dll library.</exception>
        public CardRenderer()
        {
            if (singleton != null)
            {
                throw new InvalidOperationException("An instance of WindowsCards already exists.");
            }

            string path = Path.Combine(Application.StartupPath, "cards.dll");
            if (!File.Exists(path))
            {
                File.WriteAllBytes(path, Resources.cards);
            }

            int width = 0;
            int height = 0;

            if (!CardRenderer.cdtInit(ref width, ref height))
            {
                throw new InvalidOperationException("Failed to initialize the cards.dll library.");
            }

            this.Width = width;
            this.Height = height;
            CardRenderer.singleton = this;
        }

        /// <summary>
        /// Gets the actual width of the cards, in pixels. The default is 71.
        /// </summary>
        public int Width
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the actual height of the cards, in pixels. The default is 96.
        /// </summary>
        public int Height
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the actual size of the cards, in pixels. The default is 71 by 96.
        /// </summary>
        public Size Size
        {
            get { return new Size(this.Width, this.Height); }
        }

        /// <summary>
        /// Gets the card index for the card with the specified suit and face.
        /// </summary>
        /// <param name="suit">The suit of the card.</param>
        /// <param name="face">The face of the card.</param>
        public static int GetCardIndex(CardSuit suit, CardFace face)
        {
            return (int)suit + ((int)face * Enum.GetValues(typeof(CardSuit)).Length);
        }

        /// <summary>
        /// Gets the suit for the card with the specified index.
        /// </summary>
        /// <param name="index">The index of the card.</param>
        public static CardSuit GetCardSuit(int index)
        {
            return (CardSuit)(index % 4);
        }

        /// <summary>
        /// Gets the face for the card with the specified index.
        /// </summary>
        /// <param name="index">The index of the card.</param>
        public static CardFace GetCardFace(int index)
        {
            return (CardFace)(index / 4);
        }

        public Bitmap FrontToBitmap(CardSuit suit, CardFace face)
        {
            return this.FrontToBitmap(this.Size, suit, face);
        }

        public Bitmap FrontToBitmap(CardSuit suit, CardFace face, Color color)
        {
            return this.FrontToBitmap(this.Size, suit, face, color);
        }

        public Bitmap FrontToBitmap(Size size, CardSuit suit, CardFace face)
        {
            return this.FrontToBitmap(size.Width, size.Height, suit, face);
        }

        public Bitmap FrontToBitmap(Size size, CardSuit suit, CardFace face, Color color)
        {
            return this.FrontToBitmap(size.Width, size.Height, suit, face, color);
        }

        public Bitmap FrontToBitmap(int width, int height, CardSuit suit, CardFace face)
        {
            return this.ToBitmap(width, height, CardRenderer.GetCardIndex(suit, face), CardType.Front, Color.FromArgb(0));
        }

        public Bitmap FrontToBitmap(int width, int height, CardSuit suit, CardFace face, Color color)
        {
            return this.ToBitmap(width, height, CardRenderer.GetCardIndex(suit, face), CardType.InvertedFront, color);
        }

        public Bitmap BackToBitmap(CardBackground background, Color color)
        {
            return this.BackToBitmap(this.Size, background, color);
        }

        public Bitmap BackToBitmap(Size size, CardBackground background, Color color)
        {
            return this.BackToBitmap(size.Width, size.Height, background, color);
        }

        public Bitmap BackToBitmap(int width, int height, CardBackground background, Color color)
        {
            return this.ToBitmap(width, height, (int)background, CardType.Back, color);
        }

        public Bitmap ToBitmap(int card, CardType cardType, Color color)
        {
            return this.ToBitmap(this.Size, card, cardType, color);
        }

        public Bitmap ToBitmap(Size size, int card, CardType cardType, Color color)
        {
            return this.ToBitmap(size.Width, size.Height, card, cardType, color);
        }

        /// <summary>
        /// Draws the specified card to a new bitmap image and returns it.
        /// </summary>
        /// <param name="width">The width of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="height">The height of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="card">
        /// The card to draw. This value is dependent on the value of <paramref name="type"/>.
        /// If a card face is to be drawn (<paramref name="type"/> is 0 or 2), then <paramref name="card"/> must be an integer from 0 to 51 (a combination of the face and suit).
        /// If a card back is to be drawn (<paramref name="type"/> is 1), then <paramref name="card"/> must be an integer from 53 to 68 (inclusive) to represent one of the possible card backs.
        /// The card faces are organized in increasing order, identified by an integer from 0 to 12 (inclusive) where Ace is 0 and King is 12.
        /// </param>
        /// <param name="cardType">Controls the type of card to draw, which determines the applicable values of <paramref name="card"/>.</param>
        /// <param name="color">The background color for the crosshatch background. Has no effect with other background types.</param>
        public Bitmap ToBitmap(int width, int height, int card, CardType cardType, Color color)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                this.Draw(g, 0, 0, width, height, card, cardType, color);
            }

            return bitmap;
        }

        /// <summary>
        /// Draws the animation for the specified card background to a new bitmap image and returns it.
        /// </summary>
        /// <param name="background">The background of the card.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="frame">The frame index.</param>
        /// <returns>Whether the animation should draw another frame.</returns>
        public Bitmap AnimationToBitmap(CardBackground background, int x, int y, int frame)
        {
            bool dnf;
            return this.AnimationToBitmap(background, x, y, frame, out dnf);
        }

        /// <summary>
        /// Draws the animation for the specified card background to a new bitmap image and returns it.
        /// </summary>
        /// <param name="background">The background of the card.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="frame">The frame index.</param>
        /// <param name="drawNextFrame">Whether the animation should draw another frame.</param>
        public Bitmap AnimationToBitmap(CardBackground background, int x, int y, int frame, out bool drawNextFrame)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                drawNextFrame = this.DrawAnimation(g, background, x, y, frame);
            }

            return bitmap;
        }

        public void DrawFront(Graphics g, Point point, CardSuit suit, CardFace face, bool inverted = false)
        {
            this.DrawFront(g, point.X, point.Y, suit, face, inverted);
        }

        public void DrawFront(Graphics g, int x, int y, CardSuit suit, CardFace face, bool inverted = false)
        {
            this.DrawFront(g, x, y, this.Width, this.Height, suit, face, inverted);
        }

        public void DrawFront(Graphics g, Rectangle rectangle, CardSuit suit, CardFace face, bool inverted = false)
        {
            this.DrawFront(g, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, suit, face, inverted);
        }

        public void DrawFront(Graphics g, int x, int y, int width, int height, CardSuit suit, CardFace face, bool inverted = false)
        {
            this.Draw(g, x, y, width, height, CardRenderer.GetCardIndex(suit, face), inverted ? CardType.InvertedFront : CardType.Front, Color.FromArgb(0));
        }

        public void DrawBack(Graphics g, Point point, CardBackground background, Color color)
        {
            this.DrawBack(g, point.X, point.Y, background, color);
        }

        public void DrawBack(Graphics g, int x, int y, CardBackground background, Color color)
        {
            this.DrawBack(g, x, y, this.Width, this.Height, background, color);
        }

        public void DrawBack(Graphics g, Rectangle rectangle, CardBackground background, Color color)
        {
            this.DrawBack(g, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, background, color);
        }

        public void DrawBack(Graphics g, int x, int y, int width, int height, CardBackground background, Color color)
        {
            this.Draw(g, x, y, width, height, (int)background, CardType.Back, color);
        }

        /// <summary>
        /// Draws the specified card using the graphics context <paramref name="g"/>.
        /// </summary>
        /// <param name="g">The graphics context to draw the card with.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="width">The width of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="height">The height of the card, in pixels. The card may be stretched to fit this value.</param>
        /// <param name="card">
        /// The card to draw. This value is dependent on the value of <paramref name="type"/>.
        /// If a card face is to be drawn (<paramref name="type"/> is 0 or 2), then <paramref name="card"/> must be an integer from 0 to 51 (a combination of the face and suit).
        /// If a card back is to be drawn (<paramref name="type"/> is 1), then <paramref name="card"/> must be an integer from 53 to 68 (inclusive) to represent one of the possible card backs.
        /// The card faces are organized in increasing order, identified by an integer from 0 to 12 (inclusive) where Ace is 0 and King is 12.
        /// </param>
        /// <param name="cardType">Controls the type of card to draw, which determines the applicable values of <paramref name="card"/>.</param>
        /// <param name="color">The background color for the crosshatch background. Has no effect with other background types.</param>
        public void Draw(Graphics g, int x, int y, int width, int height, int card, CardType cardType, Color color)
        {
            IntPtr hdc = g.GetHdc();

            try
            {
                // If our desired dimensions are the same as the defaults, we'll just use cdtDraw, not cdtDrawExt which takes a width and height
                if (width == this.Width && height == this.Height)
                {
                    // Windows is BGR internally, not RGB, so convert
                    if (!CardRenderer.cdtDraw(hdc, x, y, card, cardType, Color.FromArgb(0, color.B, color.G, color.R).ToArgb()))
                    {
                        throw new InvalidOperationException("cdtDraw failed to draw card.");
                    }
                }
                else
                {
                    // Windows is BGR internally, not RGB, so convert
                    if (!CardRenderer.cdtDrawExt(hdc, x, y, width, height, card, cardType, Color.FromArgb(0, color.B, color.G, color.R).ToArgb()))
                    {
                        throw new InvalidOperationException("cdtDrawExt failed to draw card.");
                    }
                }
            }
            finally
            {
                g.ReleaseHdc(hdc);
            }
        }

        /// <summary>
        /// Draws the animation for the specified card background.
        /// </summary>
        /// <param name="g">The graphics context to draw on.</param>
        /// <param name="background">The background of the card.</param>
        /// <param name="x">The X position of the card, in pixels.</param>
        /// <param name="y">The Y position of the card, in pixels.</param>
        /// <param name="frame">The frame index.</param>
        /// <returns>Whether the animation should draw another frame.</returns>
        public bool DrawAnimation(Graphics g, CardBackground background, int x, int y, int frame)
        {
            IntPtr hdc = g.GetHdc();

            try
            {
                return CardRenderer.cdtAnimate(hdc, (int)background, x, y, frame);
            }
            finally
            {
                g.ReleaseHdc(hdc);
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TODO: Call Dispose() on members of this class
            }

            CardRenderer.cdtTerm();
            CardRenderer.singleton = null;
        }
    }
}
