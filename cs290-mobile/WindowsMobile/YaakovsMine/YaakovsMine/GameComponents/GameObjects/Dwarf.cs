namespace YaakovsMine
{
    using System;
    using System.Drawing;
    using YaakovsMine.Properties;

    /// <summary>
    /// Represents the player character's avatar.
    /// </summary>
    public sealed class Dwarf : GameObject
    {
        /// <summary>
        /// The offset in pixels used to exclude the pickaxe from collision and turning.
        /// </summary>
        private const int PickaxeOffset = 28;

        /// <summary>
        /// Cached to maintain pickaxe color.
        /// </summary>
        private Image dwarfLeft = Resources.yaakov_left4;

        /// <summary>
        /// Cached to maintain pickaxe color.
        /// </summary>
        private Image dwarfRight = Resources.yaakov_right4;

        /// <summary>
        /// The index of the current sprite.
        /// </summary>
        private int spriteIndex = 4;

        /// <summary>
        /// The level of the dwarf's pickaxe.
        /// </summary>
        private PickaxeType pickaxeLevel;

        /// <summary>
        /// The number of nitroglycerin vials the dwarf has.
        /// </summary>
        private int nitroglycerin;

        /// <summary>
        /// The number of hitpoints the dwarf has.
        /// </summary>
        private int hitpoints;

        /// <summary>
        /// The time at which the animation was last updated.
        /// </summary>
        private DateTime lastAnimationUpdate = DateTime.UtcNow;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dwarf"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public Dwarf(Game game)
            : base(game, Resources.yaakov_right4)
        {
            this.Hitpoints = this.MaximumHitpoints;
            this.Nitroglycerin = 3;
            this.PickaxeLevel = PickaxeType.Iron;
            this.FaceDirection = FaceDirection.Right;
        }

        /// <summary>
        /// Gets the direction in which the dwarf is facing.
        /// </summary>
        public FaceDirection FaceDirection
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the bounds of a nitroglycerin explosion for the dwarf's current location.
        /// </summary>
        public Rectangle ExplosionBounds
        {
            get
            {
                // We need to generate an explosion bounds object that's adjacent to the dwarf character, in whatever direction he's facing
                Rectangle explosionBounds = this.CollisionBounds;

                // Change the size to be a little more appropriate
                explosionBounds.Inflate(30, 10);

                // So we'll move the bounds by the width of the character plus the pickaxe offset
                explosionBounds.Offset((this.Size.Width + 25) * (this.FaceDirection == FaceDirection.Right ? 1 : -1), -10);

                return explosionBounds;
            }
        }

        /// <summary>
        /// Gets the bounds of a pickaxe hit for the dwarf's current location.
        /// </summary>
        public Rectangle PickaxeBounds
        {
            get
            {
                // We need to generate pickaxe bounds that are adjacent to the dwarf character, in whatever direction he's facing
                Rectangle pickaxeBounds = this.CollisionBounds;

                // Change the size to be a little more appropriate
                pickaxeBounds.Inflate(20, 10);

                // So we'll move the bounds by the width of the character plus the pickaxe offset
                pickaxeBounds.Offset((this.Size.Width - 20) * (this.FaceDirection == FaceDirection.Right ? 1 : -1), -10);

                return pickaxeBounds;
            }
        }

        /// <summary>
        /// Gets the bounding collision rectangle of the object. This is overridden to exclude the dwarf's pickaxe from the collision bounds.
        /// </summary>
        public override Rectangle CollisionBounds
        {
            get
            {
                Rectangle rectangle = base.CollisionBounds;
                rectangle.Width -= Dwarf.PickaxeOffset;

                if (this.FaceDirection == FaceDirection.Left)
                {
                    rectangle.X = this.Location.X + Dwarf.PickaxeOffset;
                }

                return rectangle;
            }
        }

        /// <summary>
        /// Gets or sets the level of the dwarf's pickaxe.
        /// </summary>
        public PickaxeType PickaxeLevel
        {
            get
            {
                return this.Game.CheatMode ? PickaxeType.Densium : this.pickaxeLevel;
            }

            set
            {
                if (this.Game.CheatMode)
                {
                    return;
                }

                this.pickaxeLevel = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of nitroglycerin vials possessed by the dwarf.
        /// </summary>
        public int Nitroglycerin
        {
            get
            {
                if (this.Game.CheatMode)
                {
                    return int.MaxValue;
                }

                return this.nitroglycerin;
            }

            set
            {
                this.nitroglycerin = MathHelper.Clamp(value, 0, int.MaxValue);
            }
        }

        /// <summary>
        /// Gets the maximum hitpoints of the dwarf.
        /// </summary>
        public int MaximumHitpoints
        {
            get { return 1000; }
        }

        /// <summary>
        /// Gets or sets the current hitpoints of the dwarf, which may be between 0 and <see cref="MaximumHitpoints"/>, inclusive.
        /// </summary>
        public int Hitpoints
        {
            get
            {
                return this.Game.CheatMode ? this.MaximumHitpoints : this.hitpoints;
            }

            set
            {
                if (this.Game.CheatMode)
                {
                    return;
                }

                this.hitpoints = MathHelper.Clamp(value, 0, this.MaximumHitpoints);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the dwarf's pickaxe is currently being swung.
        /// </summary>
        public bool IsSwingingPickaxe
        {
            get;
            private set;
        }

        /// <summary>
        /// Queues the dwarf's pickaxe animation.
        /// </summary>
        public void QueueAnimation()
        {
            if (!this.IsSwingingPickaxe)
            {
                this.IsSwingingPickaxe = true;
                this.spriteIndex = 0;
            }
        }

        /// <summary>
        /// Moves the dwarf left by the specified number of units and updates the sprite accordingly.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public override void MoveLeft(double amount)
        {
            base.MoveLeft(amount);

            // If the image of the dwarf is not facing left, make it so
            if (this.FaceDirection != FaceDirection.Left)
            {
                this.FaceDirection = FaceDirection.Left;
                this.Sprite = this.GetYaakovSprite(this.FaceDirection, this.spriteIndex);

                // We move the dwarf left a bit, so his body turns with his own width rather than with his width plus the pickaxe's
                base.MoveLeft(Dwarf.PickaxeOffset);
            }
        }

        /// <summary>
        /// Moves the dwarf right by the specified number of units and updates the sprite accordingly.
        /// </summary>
        /// <param name="amount">The amount to move by.</param>
        public override void MoveRight(double amount)
        {
            base.MoveRight(amount);

            // If the image of the dwarf is not facing right, make it so
            if (this.FaceDirection != FaceDirection.Right)
            {
                this.FaceDirection = FaceDirection.Right;
                this.Sprite = this.GetYaakovSprite(this.FaceDirection, this.spriteIndex);

                // We move the dwarf right a bit, so his body turns with his own width rather than with his width plus the pickaxe's
                base.MoveRight(Dwarf.PickaxeOffset);
            }
        }

        /// <summary>
        /// Updates the state of the dwarf.
        /// </summary>
        /// <param name="difference">The difference between now and the last time the <see cref="Update"/> method was called.</param>
        public override void Update(TimeSpan difference)
        {
            base.Update(difference);

            if (this.IsSwingingPickaxe)
            {
                if ((DateTime.UtcNow - this.lastAnimationUpdate).TotalMilliseconds >= 50)
                {
                    this.Sprite = this.GetYaakovSprite(this.FaceDirection, this.spriteIndex++);

                    // If we're past the last frame, stop the animation
                    if (this.spriteIndex == 6)
                    {
                        this.spriteIndex = 0;
                        this.IsSwingingPickaxe = false;
                    }

                    this.lastAnimationUpdate = DateTime.UtcNow;
                }
            }
            else
            {
                this.Sprite = this.GetYaakovSprite(this.FaceDirection, this.spriteIndex = 4);
            }
        }

        /// <summary>
        /// Draws the dwarf.
        /// </summary>
        /// <param name="g">The graphics context used to draw the dwarf.</param>
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            if (this.Game.Debug)
            {
                g.DrawRectangle(new Pen(Color.Red), this.ExplosionBounds);
                g.DrawRectangle(new Pen(Color.Blue), this.PickaxeBounds);
            }
        }

        /// <summary>
        /// Gets Gad Yaakov's sprite for the specified face direction and index.
        /// </summary>
        /// <param name="direction">The face direction.</param>
        /// <param name="index">The index.</param>
        private Bitmap GetYaakovSprite(FaceDirection direction, int index)
        {
            if (this.FaceDirection == FaceDirection.Left)
            {
                switch (index)
                {
                    case 0:
                        return Resources.yaakov_left0;
                    case 1:
                        return Resources.yaakov_left1;
                    case 2:
                        return Resources.yaakov_left2;
                    case 3:
                        return Resources.yaakov_left3;
                    case 4:
                        return Resources.yaakov_left4;
                    case 5:
                        return Resources.yaakov_left5;
                }
            }
            else if (this.FaceDirection == FaceDirection.Right)
            {
                switch (index)
                {
                    case 0:
                        return Resources.yaakov_right0;
                    case 1:
                        return Resources.yaakov_right1;
                    case 2:
                        return Resources.yaakov_right2;
                    case 3:
                        return Resources.yaakov_right3;
                    case 4:
                        return Resources.yaakov_right4;
                    case 5:
                        return Resources.yaakov_right5;
                }
            }

            return null;
        }
    }
}
