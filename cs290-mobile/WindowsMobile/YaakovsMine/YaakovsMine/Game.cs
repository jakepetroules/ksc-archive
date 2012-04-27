namespace YaakovsMine
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using YaakovsMine.Properties;

    /// <summary>
    /// The main class of the Yaakov's Mine game.
    /// </summary>
    public sealed class Game : IDisposable
    {
        /// <summary>
        /// The last time the game state was updated, to maintain consistent timing.
        /// </summary>
        private DateTime lastUpdate = DateTime.MinValue;

        /// <summary>
        /// Whether the game is in cheat mode.
        /// </summary>
        private bool cheatMode = false;

        /// <summary>
        /// The current state of the game.
        /// </summary>
        private GameState gameState = GameState.NotStarted;

        /// <summary>
        /// The bounds of a nitroglycerin explosion.
        /// </summary>
        private Rectangle explosionBounds;

        /// <summary>
        /// An instance of our input class used for keyboard input.
        /// </summary>
        private InputHelper input = new InputHelper();

        /// <summary>
        /// A list of the game components that are part of the game.
        /// </summary>
        private List<GameComponent> gameComponents = new List<GameComponent>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            this.GameState = GameState.NotStarted;
        }

        /// <summary>
        /// Gets the game's object manager.
        /// </summary>
        public FallingObjectComponent ObjectManager
        {
            get { return (FallingObjectComponent)this.Components.FirstOrDefault(p => p is FallingObjectComponent); }
        }

        /// <summary>
        /// Gets the game's display manager.
        /// </summary>
        public DisplayComponent Display
        {
            get { return (DisplayComponent)this.Components.FirstOrDefault(p => p is DisplayComponent); }
        }

        /// <summary>
        /// Gets the game's physics manager.
        /// </summary>
        public PhysicsComponent Physics
        {
            get { return (PhysicsComponent)this.Components.FirstOrDefault(p => p is PhysicsComponent); }
        }

        /// <summary>
        /// Gets the game's sound manager.
        /// </summary>
        public SoundComponent Sound
        {
            get { return (SoundComponent)this.Components.FirstOrDefault(p => p is SoundComponent); }
        }

        /// <summary>
        /// Gets a value indicating whether the game is running.
        /// <c>true</c> indicates that the game is running; <c>false</c> indicates that it is paused.
        /// </summary>
        public bool Running
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display debug information.
        /// </summary>
        public bool Debug
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the game is in cheat mode.
        /// </summary>
        /// <remarks>
        /// This mode prevents the character from dying, losing HP, and grants the highest
        /// level pickaxe and infinite nitroglycerin. Entering cheat mode also drops the
        /// player's score to 0. Exiting cheat mode erases the player's score, pickaxe and
        /// nitroglycerin.
        /// </remarks>
        public bool CheatMode
        {
            get
            {
                return this.cheatMode;
            }

            set
            {
                if (this.RocksCollected != null)
                {
                    List<OresAndMetals> rocks = this.RocksCollected.Select(p => p.Key).ToList();

                    // Clear all the rocks the player's collected, thus clearing their score
                    for (int i = 0; i < rocks.Count; i++)
                    {
                        this.RocksCollected[rocks[i]] = 0;
                    }
                }

                if (this.Character != null)
                {
                    // Give them the lowest level pickaxe
                    this.Character.PickaxeLevel = PickaxeType.Bronze;

                    // Take away their nitroglycerin
                    this.Character.Nitroglycerin = 0;
                }

                this.cheatMode = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the game has been initialized.
        /// </summary>
        public bool Initialized
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the size of the game screen.
        /// </summary>
        public Size ScreenSize
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a dictionary of the type of each rock collected so far.
        /// </summary>
        public Dictionary<OresAndMetals, int> RocksCollected
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the player's current score.
        /// </summary>
        public int Score
        {
            get { return this.RocksCollected.Sum(p => p.Value * p.Key.GetRockPoints()); }
        }

        /// <summary>
        /// Gets the dwarf character.
        /// </summary>
        public Dwarf Character
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the current state of the game.
        /// </summary>
        public GameState GameState
        {
            get
            {
                return this.gameState;
            }

            set
            {
                // Only change if the value's different
                if (this.gameState != value)
                {
                    if (value == GameState.NotStarted || value == GameState.Ended)
                    {
                        this.Running = false;
                    }
                    else if (value == GameState.Playing)
                    {
                        this.CheatMode = false;
                        this.Debug = false;

                        if (this.RocksCollected != null)
                        {
                            List<OresAndMetals> rocks = this.RocksCollected.Select(p => p.Key).ToList();

                            // Clear all the rocks the player's collected, thus clearing their score
                            for (int i = 0; i < rocks.Count; i++)
                            {
                                this.RocksCollected[rocks[i]] = 0;
                            }
                        }

                        if (this.Character != null)
                        {
                            // Give them the lowest level pickaxe
                            this.Character.PickaxeLevel = PickaxeType.Bronze;

                            // Take away their nitroglycerin
                            this.Character.Nitroglycerin = 3;

                            // Heal them up!
                            this.Character.Hitpoints = this.Character.MaximumHitpoints;

                            this.Character.Location = Point.Empty;
                            this.Character.SetFloorPosition();
                            this.Character.MoveRight(0);
                        }

                        if (this.ObjectManager != null)
                        {
                            this.ObjectManager.Objects.Clear();
                        }

                        this.Running = true;
                    }

                    this.gameState = value;
                }
            }
        }

        /// <summary>
        /// Gets a list of the game's components.
        /// </summary>
        private ReadOnlyCollection<GameComponent> Components
        {
            get { return new ReadOnlyCollection<GameComponent>(this.gameComponents); }
        }

        /// <summary>
        /// Initializes the game with the specified screen size.
        /// </summary>
        /// <param name="screenSize">The size of the game screen.</param>
        public void Initialize(Size screenSize)
        {
            if (!this.Initialized)
            {
                this.Running = false;
                this.CheatMode = false;
                this.Debug = false;

                this.RocksCollected = new Dictionary<OresAndMetals, int>();
                this.RocksCollected.Add(OresAndMetals.Coal, 0);
                this.RocksCollected.Add(OresAndMetals.Tin, 0);
                this.RocksCollected.Add(OresAndMetals.Copper, 0);
                this.RocksCollected.Add(OresAndMetals.Iron, 0);
                this.RocksCollected.Add(OresAndMetals.Mithril, 0);
                this.RocksCollected.Add(OresAndMetals.Densium, 0);

                this.ScreenSize = screenSize;

                this.Character = new Dwarf(this);
                this.Character.SetFloorPosition();
                this.gameComponents.Add(this.Character);

                this.gameComponents.Add(new FallingObjectComponent(this));
                this.gameComponents.Add(new DisplayComponent(this));
                this.gameComponents.Add(new PhysicsComponent(this));
                this.gameComponents.Add(new SoundComponent(this));

                this.Initialized = true;
            }
        }

        /// <summary>
        /// Updates the state of the game.
        /// </summary>
        /// <exception cref="InvalidOperationException">The game has not been initialized.</exception>
        public void Update()
        {
            if (!this.Initialized)
            {
                throw new InvalidOperationException(Resources.GameNotInitialized);
            }

            TimeSpan difference = DateTime.UtcNow - this.lastUpdate;

            this.input.Update();
            this.CheckInput(difference);

            if (this.Running)
            {
                this.gameComponents.ForEach(p => p.Update(difference));

                if (this.Character.Hitpoints <= 0)
                {
                    this.GameState = GameState.Ended;
                }
            }

            this.lastUpdate = DateTime.UtcNow;
        }

        /// <summary>
        /// Draws the game.
        /// </summary>
        /// <param name="g">The graphics context used to draw the game.</param>
        /// <exception cref="InvalidOperationException">The game has not been initialized.</exception>
        public void Draw(Graphics g)
        {
            if (!this.Initialized)
            {
                throw new InvalidOperationException(Resources.GameNotInitialized);
            }

            // Clear the scene
            g.Clear(Color.Black);

            switch (this.GameState)
            {
                case GameState.NotStarted:
                    {
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        g.DrawString(Resources.YaakovsMine, new Font(FontFamily.GenericSerif, 20, FontStyle.Bold), new SolidBrush(Color.Yellow), new RectangleF(10, 10, this.ScreenSize.Width - 20, 30), format);
                        g.DrawString(Resources.IntroductionMessage, new Font(FontFamily.GenericSerif, 10, FontStyle.Regular), new SolidBrush(Color.Yellow), new RectangleF(4, 30 + 10 + 4, this.ScreenSize.Width - 8, this.ScreenSize.Height - 8));
                    }

                    break;
                case GameState.Playing:
                    {
                        // Draw the mine background
                        g.DrawImage(Resources.mine_background, (this.ScreenSize.Width - Resources.mine_background.Width) / 2, (this.ScreenSize.Height - Resources.mine_background.Height) / 2);

                        // Draw our components
                        this.gameComponents.ForEach(p => p.Draw(g));

                        if (this.explosionBounds != Rectangle.Empty)
                        {
                            this.explosionBounds.Inflate(1, 1);
                            g.FillEllipse(new SolidBrush(Color.Yellow), this.explosionBounds);
                            if (this.explosionBounds.Width > 40 || this.explosionBounds.Height > 40)
                            {
                                this.explosionBounds = Rectangle.Empty;
                            }
                        }
                    }

                    break;
                case GameState.Ended:
                    {
                        g.DrawString(Resources.EndingMessage, new Font(FontFamily.GenericSerif, 10, FontStyle.Regular), new SolidBrush(Color.Yellow), new RectangleF(4, 4, this.ScreenSize.Width - 8, this.ScreenSize.Height - 8));
                    }

                    break;
            }
        }

        /// <summary>
        /// Queues a nitroglycerin explosion animation.
        /// </summary>
        public void AnimateNitroglycerin()
        {
            this.explosionBounds = this.Character.ExplosionBounds;
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
                this.gameComponents.ForEach(p => p.Dispose());
            }

            this.gameComponents.Clear();
            this.gameComponents = null;

            this.RocksCollected.Clear();
            this.RocksCollected = null;
        }

        /// <summary>
        /// Checks for input to the game and processes it accordingly.
        /// </summary>
        /// <param name="difference">The elapsed time since the last input check.</param>
        private void CheckInput(TimeSpan difference)
        {
            switch (this.GameState)
            {
                case GameState.NotStarted:
                case GameState.Ended:
                    if (this.input.IsNewlyPressed(Keys.Enter))
                    {
                        this.GameState = GameState.Playing;
                    }

                    break;
                case GameState.Playing:
                    {
                        // This will pause the game
                        if (this.input.IsNewlyPressed(Keys.P))
                        {
                            this.Running = !this.Running;
                            this.Sound.Play(SoundComponent.Sound.Pause);
                        }

                        // This will turn on debug mode, which shows bounding boxes for objects, and other information
                        if (this.input.IsNewlyPressed(Keys.D))
                        {
                            this.Debug = !this.Debug;
                        }

                        // Toogles cheat mode
                        if (this.input.IsNewlyPressed(Keys.C))
                        {
                            this.CheatMode = !this.CheatMode;
                        }

                        // We only do anything else if the game's running (not paused)
                        if (this.Running)
                        {
                            // The left and right keys move the dwarf character
                            if (this.input.IsKeyPressed(Keys.Left))
                            {
                                this.Character.MoveLeft(0.15 * difference.TotalMilliseconds);
                            }
                            else if (this.input.IsKeyPressed(Keys.Right))
                            {
                                this.Character.MoveRight(0.15 * difference.TotalMilliseconds);
                            }

                            // The up key uses a vial of nitroglycerin
                            if (this.input.IsNewlyPressed(Keys.Up))
                            {
                                if (this.Character.Nitroglycerin > 0)
                                {
                                    this.Physics.UseNitroglycerin();

                                    // Take away a vial
                                    this.Character.Nitroglycerin--;
                                }
                            }

                            // The down key swings the dwarf's pickaxe
                            if (this.input.IsNewlyPressed(Keys.Down))
                            {
                                if (!this.Character.IsSwingingPickaxe)
                                {
                                    this.Physics.UsePickaxe();
                                    this.Character.QueueAnimation();
                                }
                            }

                            // If the character is off the left of the screen, snap his position back to the left side of the screen
                            if (this.Character.Location.X < 0)
                            {
                                this.Character.Location = new Point(0, this.Character.Location.Y);
                            }

                            // If the character is off the right of the screen, snap his position back to the right side of the screen
                            if (this.Character.Location.X > this.ScreenSize.Width - this.Character.Size.Width)
                            {
                                this.Character.Location = new Point(this.ScreenSize.Width - this.Character.Size.Width, this.Character.Location.Y);
                            }
                        }
                    }

                    break;
            }
        }
    }
}
