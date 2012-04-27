namespace YaakovsMine
{
    using System;
    using System.Linq;

    /// <summary>
    /// Provides management of physics/collision operations in the game.
    /// </summary>
    public sealed class PhysicsComponent : GameComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicsComponent"/> class.
        /// </summary>
        /// <param name="game">Reference to the <see cref="Game"/> instance.</param>
        public PhysicsComponent(Game game)
            : base(game)
        {
        }

        /// <summary>
        /// Uses a vial of nitroglycerin, adding the blasted rocks to the inventory and destroying any other objects (such as crates) in the explosion vicinity.
        /// </summary>
        public void UseNitroglycerin()
        {
            foreach (Rock rock in this.Game.ObjectManager.Objects.Where(p => p is Rock))
            {
                if (rock.CollisionBounds.IntersectsWith(this.Game.Character.ExplosionBounds))
                {
                    rock.Hitpoints = 0;

                    if (rock.Ore != OresAndMetals.Boulder)
                    {
                        this.Game.RocksCollected[rock.Ore]++;
                    }
                }
            }

            this.Game.Sound.Play(SoundComponent.Sound.Nitroglycerin);
            this.Game.AnimateNitroglycerin();
            this.Game.ObjectManager.Objects.RemoveAll(p => p is Rock && ((Rock)p).IsDestroyed);

            // Remove all non-rock intersecting objects also
            this.Game.ObjectManager.Objects.RemoveAll(p => p.CollisionBounds.IntersectsWith(this.Game.Character.ExplosionBounds));
        }

        /// <summary>
        /// Uses the dwarf's pickaxe to mine the nearest rock.
        /// </summary>
        public void UsePickaxe()
        {
            foreach (Rock rock in this.Game.ObjectManager.Objects.Where(p => p is Rock))
            {
                if (rock.CollisionBounds.IntersectsWith(this.Game.Character.PickaxeBounds))
                {
                    Random random = new Random();
                    rock.Hitpoints -= random.GenerateNumber(0, this.Game.Character.PickaxeLevel.GetMaximumDamage());

                    if (rock.Hitpoints == 0 && rock.Ore != OresAndMetals.Boulder)
                    {
                        this.Game.RocksCollected[rock.Ore]++;
                    }

                    this.Game.Sound.Play(SoundComponent.Sound.Pickaxe);

                    break;
                }
            }

            this.Game.ObjectManager.Objects.RemoveAll(p => p is Rock && ((Rock)p).IsDestroyed);
        }

        /// <summary>
        /// Updates the state of the physics component.
        /// </summary>
        /// <param name="difference">The difference between now and the last time the <see cref="Update"/> method was called.</param>
        public override void Update(TimeSpan difference)
        {
            this.HandleRocks(this.Game.ObjectManager);
            this.HandleHealingCrates(this.Game.ObjectManager);
            this.HandleNitroglycerinCrates(this.Game.ObjectManager);
        }

        /// <summary>
        /// Handles rock collisions and damages the player appropriately.
        /// </summary>
        /// <param name="fallingObjectComponent">The <see cref="FallingObjectComponent"/> that manages creation and movement of falling objects.</param>
        private void HandleRocks(FallingObjectComponent fallingObjectComponent)
        {
            // Handle rocks that may hit the player
            foreach (Rock rock in fallingObjectComponent.Objects.Where(p => p is Rock))
            {
                if (!rock.IsOnGround && !rock.HasHit && rock.CollisionBounds.IntersectsWith(this.Game.Character.CollisionBounds))
                {
                    this.Game.Character.Hitpoints -= rock.Ore.GetRockDamage();
                    rock.HasHit = true;

                    this.Game.Sound.Play(SoundComponent.Sound.Hurt);
                }
            }
        }

        /// <summary>
        /// Handles healing crates and restores the player's health appropriately.
        /// </summary>
        /// <param name="fallingObjectComponent">The <see cref="FallingObjectComponent"/> that manages creation and movement of falling objects.</param>
        private void HandleHealingCrates(FallingObjectComponent fallingObjectComponent)
        {
            // For each crate, check if it collided with the player, and if so, heal them
            foreach (MedicalCrate crate in fallingObjectComponent.Objects.Where(p => p is MedicalCrate))
            {
                if (crate.CollisionBounds.IntersectsWith(this.Game.Character.CollisionBounds))
                {
                    // Heal the dwarf!
                    crate.Heal(this.Game.Character);
                }
            }

            // Remove the ones we crashed into
            fallingObjectComponent.Objects.RemoveAll(p => p is MedicalCrate && ((MedicalCrate)p).Healing <= 0);
        }

        /// <summary>
        /// Handles nitroglycerin crates and awards the player vials of nitroglycerin appropriately.
        /// </summary>
        /// <param name="fallingObjectComponent">The <see cref="FallingObjectComponent"/> that manages creation and movement of falling objects.</param>
        private void HandleNitroglycerinCrates(FallingObjectComponent fallingObjectComponent)
        {
            // For each crate, check if it collided with the player, and if so, give them another vial of nitroglycerin
            foreach (NitroglycerinCrate nitroCrates in fallingObjectComponent.Objects.Where(p => p is NitroglycerinCrate))
            {
                if (nitroCrates.CollisionBounds.IntersectsWith(this.Game.Character.CollisionBounds) && nitroCrates.ContainsVial)
                {
                    nitroCrates.Loot(this.Game.Character);
                }
            }

            // Remove the ones we crashed into
            fallingObjectComponent.Objects.RemoveAll(p => p is NitroglycerinCrate && !((NitroglycerinCrate)p).ContainsVial);
        }
    }
}
