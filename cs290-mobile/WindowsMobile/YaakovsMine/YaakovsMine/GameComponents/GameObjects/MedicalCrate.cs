namespace YaakovsMine
{
    using System;
    using YaakovsMine.Properties;

    /// <summary>
    /// Represents a crate carrying medical supplies that can heal the player.
    /// </summary>
    public sealed class MedicalCrate : GameObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCrate"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public MedicalCrate(Game game)
            : base(game, Resources.medical_crate)
        {
            Random random = new Random();
            this.Healing = random.GenerateNumber(50, 200);
        }

        /// <summary>
        /// Gets the amount of health this medical crate heals.
        /// </summary>
        public int Healing
        {
            get;
            private set;
        }

        /// <summary>
        /// Heals the player using this medical crate.
        /// </summary>
        /// <param name="player">The player to heal.</param>
        public void Heal(Dwarf player)
        {
            player.Hitpoints += this.Healing;
            this.Healing = 0;
        }
    }
}
