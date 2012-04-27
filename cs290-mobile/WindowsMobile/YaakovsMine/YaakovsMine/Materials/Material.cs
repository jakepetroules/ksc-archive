namespace YaakovsMine
{
    using System;

    /// <summary>
    /// Represents a material.
    /// </summary>
    /// <typeparam name="T">The object type representing the material's name.</typeparam>
    internal sealed class Material<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Material{T}"/> class.
        /// </summary>
        /// <param name="name">An object representing the material's name.</param>
        /// <param name="meltingPoint">The melting point of the material in Celsius.</param>
        /// <param name="ultimateTensileStrength">The ultimate tensile strength of the material in megapascals.</param>
        /// <param name="density">The density of the material in grams per cubic centimeter.</param>
        /// <param name="alloy">Whether the material is an alloy.</param>
        public Material(T name, decimal meltingPoint, decimal ultimateTensileStrength, decimal density, bool alloy)
        {
            this.Name = name;
            this.MeltingPoint = meltingPoint;
            this.UltimateTensileStrength = ultimateTensileStrength;
            this.Density = density;
            this.IsAlloy = alloy;
        }

        /// <summary>
        /// Gets the object representing the material's name.
        /// </summary>
        public T Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the melting point of the material in Celsius.
        /// </summary>
        public decimal MeltingPoint
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the ultimate tensile strength of the material in megapascals.
        /// </summary>
        public decimal UltimateTensileStrength
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the density of the material in grams per cubic centimeter.
        /// </summary>
        public decimal Density
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value indicating whether the material is an alloy.
        /// </summary>
        public bool IsAlloy
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the level needed to mine this material.
        /// </summary>
        /// <exception cref="InvalidOperationException">This material is an alloy.</exception>
        public int MiningLevel
        {
            get
            {
                if (this.IsAlloy)
                {
                    throw new InvalidOperationException(Properties.Resources.AlloysOnlyCreatedMetalworking);
                }
                
                return (int)decimal.Truncate(0.2m * MathHelper.Sqrt(this.UltimateTensileStrength) * this.Density);
            }
        }

        /// <summary>
        /// Gets the level needed to work this material.
        /// </summary>
        public int MetalworkingLevel
        {
            get
            {
                // TODO: This is irrelevant for this particular game, but... if this material is a gem-type material, an exception should be thrown here

                // Little sanity check for coal...
                if (this.MeltingPoint == decimal.MaxValue)
                {
                    return 0;
                }

                return (int)decimal.Truncate(0.05m * MathHelper.Log10(this.Density) * MathHelper.Sqrt((this.MeltingPoint + 273.15m) * this.UltimateTensileStrength * MathHelper.Log10(this.Density))) + this.AlloyBonus;
            }
        }

        /// <summary>
        /// Gets the number of extra levels needed to work alloys.
        /// </summary>
        private int AlloyBonus
        {
            get
            {
                if (this.IsAlloy)
                {
                    return (int)decimal.Truncate(MathHelper.Pow((0.05m * (1 / this.Density) * MathHelper.Sqrt((this.MeltingPoint + 273.15m) * this.UltimateTensileStrength * (1 / this.Density))), 1.5m));
                }

                return 0;
            }
        }
    }
}
