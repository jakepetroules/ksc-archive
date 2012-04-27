namespace YaakovsMine
{
    using YaakovsMine.Properties;

    /// <summary>
    /// Represents a crate carrying a vial of nitroglycerin.
    /// </summary>
    public sealed class NitroglycerinCrate : GameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NitroglycerinCrate"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public NitroglycerinCrate(Game game)
            : base(game, Resources.nitroglycerin_crate)
        {
            this.ContainsVial = true;
        }

        /// <summary>
        /// Gets a value indicating whether the crate contains a vial of nitroglycerin.
        /// </summary>
        public bool ContainsVial
        {
            get;
            private set;
        }

        /// <summary>
        /// Loots the crate, awarding the contents to the player.
        /// </summary>
        /// <param name="player">The player ot award the contents to.</param>
        public void Loot(Dwarf player)
        {
            if (this.ContainsVial)
            {
                player.Nitroglycerin++;
                this.ContainsVial = false;
            }
        }
    }
}
