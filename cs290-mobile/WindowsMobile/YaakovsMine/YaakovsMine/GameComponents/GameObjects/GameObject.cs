namespace YaakovsMine
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Represents a generic game object that is visually represented on the screen.
    /// </summary>
    public abstract class GameObject : GameComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameObject"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        /// <param name="sprite">The image representing the game object.</param>
        protected GameObject(Game game, Image sprite)
            : base(game)
        {
            this.Sprite = sprite;
        }

        /// <summary>
        /// Gets or sets the image representing the game object.
        /// </summary>
        public Image Sprite
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets the bounding collision rectangle of the object. By default it is equal to the object's <see cref="Bounds"/>.
        /// </summary>
        public virtual Rectangle CollisionBounds
        {
            get { return this.Bounds; }
        }

        /// <summary>
        /// Gets the bounding rectangle of the object.
        /// </summary>
        public Rectangle Bounds
        {
            get { return new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height); }
        }

        /// <summary>
        /// Gets or sets the location of the object.
        /// </summary>
        public Point Location
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the size of the object.
        /// </summary>
        public Size Size
        {
            get { return this.Sprite.Size; }
        }

        /// <summary>
        /// Gets a value indicating whether the object is resting on the ground.
        /// </summary>
        public bool IsOnGround
        {
            get { return this.Location.Y >= this.Game.ScreenSize.Height - this.Size.Height - 5; }
        }

        /// <summary>
        /// Moves the object left by the specified number of units.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public virtual void MoveLeft(double amount)
        {
            this.Location = new Point(this.Location.X - (int)amount, this.Location.Y);
        }

        /// <summary>
        /// Moves the object right by the specified number of units.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public virtual void MoveRight(double amount)
        {
            this.Location = new Point(this.Location.X + (int)amount, this.Location.Y);
        }

        /// <summary>
        /// Moves the object up by the specified number of units.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public virtual void MoveUp(double amount)
        {
            this.Location = new Point(this.Location.X, this.Location.Y - (int)amount);
        }

        /// <summary>
        /// Moves the object down by the specified number of units.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public virtual void MoveDown(double amount)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + (int)amount);
        }

        /// <summary>
        /// Sets the object's position so that it is on the ceiling at a random X coordinate on the screen.
        /// </summary>
        public void SetCeilingPosition()
        {
            Random random = new Random();
            this.Location = new Point(random.GenerateNumber(0, this.Game.ScreenSize.Width - this.Size.Width), 0 - this.Size.Height);
        }

        /// <summary>
        /// Sets the object's position so that it is on the floor, leaving its X position unchanged.
        /// </summary>
        public void SetFloorPosition()
        {
            this.Location = new Point(this.Location.X, this.Game.ScreenSize.Height - this.Size.Height - 5);
        }

        /// <summary>
        /// Draws the game component.
        /// </summary>
        /// <param name="g">The graphics context used to draw the component.</param>
        public override void Draw(Graphics g)
        {
            g.DrawImage(this.Sprite, this.Location.X, this.Location.Y);
            if (this.Game.Debug)
            {
                g.DrawRectangle(new Pen(Color.Yellow), this.CollisionBounds);
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Sprite != null)
                {
                    this.Sprite.Dispose();
                }
            }
        }
    }
}
