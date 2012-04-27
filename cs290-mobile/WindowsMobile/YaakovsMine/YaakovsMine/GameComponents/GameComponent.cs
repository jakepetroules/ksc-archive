namespace YaakovsMine
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Represents a game component that can be updated and/or drawn to the screen.
    /// </summary>
    public abstract class GameComponent : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameComponent"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        protected GameComponent(Game game)
        {
            this.Game = game;
        }

        /// <summary>
        /// Gets a reference to the <see cref="Game"/> instance.
        /// </summary>
        public Game Game
        {
            get;
            private set;
        }

        /// <summary>
        /// Updates the state of the game component.
        /// </summary>
        /// <param name="difference">The difference between now and the last time the <see cref="Update"/> method was called.</param>
        public virtual void Update(TimeSpan difference)
        {
        }

        /// <summary>
        /// Draws the game component.
        /// </summary>
        /// <param name="g">The graphics context used to draw the component.</param>
        public virtual void Draw(Graphics g)
        {
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
        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
