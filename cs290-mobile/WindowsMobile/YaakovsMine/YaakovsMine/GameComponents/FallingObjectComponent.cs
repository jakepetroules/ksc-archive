namespace YaakovsMine
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    /// <summary>
    /// Manages creation and movement of falling objects.
    /// </summary>
    public sealed class FallingObjectComponent : GameComponent
    {
        /// <summary>
        /// The standard gravity of Earth in meters per second squared.
        /// </summary>
        private const double GravitationalConstant = 9.812865328;

        /// <summary>
        /// The time the last object was created.
        /// </summary>
        private DateTime lastObjectCreated = DateTime.MinValue;

        /// <summary>
        /// Our falling object probability set.
        /// </summary>
        private ProbabilitySet<FallingObject> fallingObjectSet = new ProbabilitySet<FallingObject>();

        /// <summary>
        /// Our rock type probability set.
        /// </summary>
        private ProbabilitySet<OresAndMetals> oresAndMetalsSet = new ProbabilitySet<OresAndMetals>();

        /// <summary>
        /// The list of objects that are falling from the ceiling.
        /// </summary>
        private List<GameObject> objects = new List<GameObject>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallingObjectComponent"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public FallingObjectComponent(Game game)
            : base(game)
        {
            this.fallingObjectSet.Add(FallingObject.Rock, 0.85m);
            this.fallingObjectSet.Add(FallingObject.MedicalKit, 0.15m);
            this.fallingObjectSet.Add(FallingObject.Nitroglycerin, 0.1m);

            this.oresAndMetalsSet.Add(OresAndMetals.Boulder, 0.3m);
            this.oresAndMetalsSet.Add(OresAndMetals.Coal, 0.3m);
            this.oresAndMetalsSet.Add(OresAndMetals.Tin, 0.2m);
            this.oresAndMetalsSet.Add(OresAndMetals.Copper, 0.2m);
            this.oresAndMetalsSet.Add(OresAndMetals.Iron, 0.15m);
            this.oresAndMetalsSet.Add(OresAndMetals.Mithril, 0.04m);
            this.oresAndMetalsSet.Add(OresAndMetals.Densium, 0.01m);
        }

        /// <summary>
        /// Gets a list of the falling or fallen objects.
        /// </summary>
        public List<GameObject> Objects
        {
            get { return this.objects; }
            private set { this.objects = value; }
        }

        /// <summary>
        /// Updates the state of the falling object component, applying gravity and removing old objects.
        /// </summary>
        /// <param name="difference">The difference between now and the last time the <see cref="Update"/> method was called.</param>
        public override void Update(TimeSpan difference)
        {
            // Do gravity for rocks that are not on the ground, or other objects - move them down a little
            // This results in rocks moving down until they hit the ground, and other objects to "fall off a cliff"
            // forcing the player to catch them if they want them
            this.objects.Where(p => (p is Rock && !p.IsOnGround) || !(p is Rock)).ToList().ForEach(p => p.MoveDown((FallingObjectComponent.GravitationalConstant / 100) * difference.TotalMilliseconds));

            // For any rocks on the ground, snap them to floor position (in case they were a few pixels too far down)
            this.objects.Where(p => (p is Rock && p.IsOnGround)).ToList().ForEach(p => p.SetFloorPosition());

            // Remove any objects that've passed by the bottom of the screen
            this.objects.RemoveAll(p => p.Location.Y > this.Game.ScreenSize.Height);

            // Do we need more objects? No more than 3 FALLING objects at once and no more than one new one per second
            if (this.objects.Where(p => !p.IsOnGround).Count() < 3 && (DateTime.UtcNow - this.lastObjectCreated).TotalSeconds > 1)
            {
                GameObject objectToAdd = null;

                // Decide what type of falling object to create
                FallingObject fallingObject = this.fallingObjectSet.Draw();                
                switch (fallingObject)
                {
                    case FallingObject.Rock:
                        objectToAdd = this.GetRock();
                        break;
                    case FallingObject.Nitroglycerin:
                        objectToAdd = new NitroglycerinCrate(this.Game);
                        break;
                    case FallingObject.MedicalKit:
                        objectToAdd = new MedicalCrate(this.Game);
                        break;
                    case FallingObject.Pickaxe:
                        return;
                }

                // Put the object at the ceiling and add it to our list
                objectToAdd.SetCeilingPosition();
                this.objects.Add(objectToAdd);

                this.lastObjectCreated = DateTime.UtcNow;
            }
        }

        /// <summary>
        /// Draws the falling objects.
        /// </summary>
        /// <param name="g">The graphics context used to draw the falling objects.</param>
        public override void Draw(Graphics g)
        {
            this.objects.ForEach(p => p.Draw(g));
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Objects.ForEach(p => p.Dispose());
            }

            this.Objects.Clear();
            this.Objects = null;

            this.fallingObjectSet.Clear();
            this.fallingObjectSet = null;

            this.oresAndMetalsSet.Clear();
            this.oresAndMetalsSet = null;
        }

        /// <summary>
        /// Gets a rock to add to the falling object component object list.
        /// </summary>
        private Rock GetRock()
        {
            Rock rock = null;
            do
            {
                try
                {
                    rock = new Rock(this.Game, this.oresAndMetalsSet.Draw());
                }
                catch (ArgumentException)
                {
                    // Could not create a rock of this type... our generator landed on steel or something
                }
            }
            while (rock == null);

            return rock;
        }
    }
}
