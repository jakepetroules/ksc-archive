namespace YaakovsMine
{
    /// <summary>
    /// Represents a rock that the player may mine.
    /// </summary>
    public sealed class Rock : GameObject
    {
        /// <summary>
        /// The rock's hitpoints.
        /// </summary>
        private int hitpoints;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rock"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        /// <param name="ore">The ore of the rock.</param>
        public Rock(Game game, OresAndMetals ore)
            : base(game, ore.GetRockSprite())
        {
            this.Ore = ore;
            this.Hitpoints = this.MaximumHitpoints;
        }

        /// <summary>
        /// Gets the ore this rock is made of.
        /// </summary>
        public OresAndMetals Ore
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the rock's maximum hitpoints.
        /// </summary>
        public int MaximumHitpoints
        {
            get { return this.Ore.GetRockHitpoints(); }
        }

        /// <summary>
        /// Gets or sets the rock's hitpoints.
        /// </summary>
        public int Hitpoints
        {
            get { return this.hitpoints; }
            set { this.hitpoints = MathHelper.Clamp(value, 0, this.MaximumHitpoints); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the rock has hit the player.
        /// If the rock has already hit the player, it will not deal further damage.
        /// </summary>
        public bool HasHit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the rock has been destroyed.
        /// </summary>
        public bool IsDestroyed
        {
            get { return this.Hitpoints == 0; }
        }
    }
}
