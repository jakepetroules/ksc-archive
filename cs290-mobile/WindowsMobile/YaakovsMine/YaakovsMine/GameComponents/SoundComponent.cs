namespace YaakovsMine
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using YaakovsMine.Properties;

    /// <summary>
    /// Provides methods for playing game sounds.
    /// </summary>
    public sealed class SoundComponent : GameComponent
    {
        /// <summary>
        /// The OpenAL wave player.
        /// </summary>
        private WavePlayer player;

        /// <summary>
        /// Dictionary of the sounds to indexes in the <see cref="WavePlayer"/> internal array.
        /// </summary>
        private Dictionary<Sound, int> indexDictionary = new Dictionary<Sound, int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoundComponent"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public SoundComponent(Game game)
            : base(game)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                this.player = new WavePlayer();
                this.indexDictionary.Add(Sound.Hurt, this.player.Load(new MemoryStream(Resources.hurt)));
                this.indexDictionary.Add(Sound.Pause, this.player.Load(new MemoryStream(Resources.pause)));
                this.indexDictionary.Add(Sound.Pickaxe, this.player.Load(new MemoryStream(Resources.pickaxe)));
                this.indexDictionary.Add(Sound.Nitroglycerin, this.player.Load(new MemoryStream(Resources.nitroglycerin)));
            }
        }

        /// <summary>
        /// Enumerates the sounds available in the game.
        /// </summary>
        public enum Sound
        {
            /// <summary>
            /// Indicates the 'hurt' sound, played when the character is hit by a falling rock.
            /// </summary>
            Hurt,

            /// <summary>
            /// Indicates the 'pause' sound, played when the game is paused or unpaused.
            /// </summary>
            Pause,

            /// <summary>
            /// Indicates the 'pickaxe' sound, played when the dwarf character swings his pickaxe.
            /// </summary>
            Pickaxe,

            /// <summary>
            /// Indicates the 'nitroglycerin' sound, played when the dwarf character throws a vial of nitroglycerin.
            /// </summary>
            Nitroglycerin
        }

        /// <summary>
        /// Plays the specified sound.
        /// </summary>
        /// <param name="sound">The sound to play.</param>
        public void Play(Sound sound)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                this.player.Current = this.indexDictionary[sound];
                this.player.Play();
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
                if (this.player != null)
                {
                    this.player.Dispose();
                }
            }

            this.indexDictionary.Clear();
            this.indexDictionary = null;
        }
    }
}
