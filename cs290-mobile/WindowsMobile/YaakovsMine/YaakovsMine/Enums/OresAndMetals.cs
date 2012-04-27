namespace YaakovsMine
{
    using System;
    using System.Drawing;
    using YaakovsMine.Properties;

    /// <summary>
    /// Enumerates various ores and metals.
    /// </summary>
    public enum OresAndMetals
    {
        /// <summary>
        /// Represents a boulder.
        /// </summary>
        Boulder,

        /// <summary>
        /// Represents bronze.
        /// </summary>
        Bronze,

        /// <summary>
        /// Represents coal.
        /// </summary>
        Coal,

        /// <summary>
        /// Represents copper.
        /// </summary>
        Copper,

        /// <summary>
        /// Represents densium.
        /// </summary>
        Densium,

        /// <summary>
        /// Represents iron.
        /// </summary>
        Iron,

        /// <summary>
        /// Represents mithril.
        /// </summary>
        Mithril,
        
        /// <summary>
        /// Represents steel.
        /// </summary>
        Steel,
        
        /// <summary>
        /// Represents tin.
        /// </summary>
        Tin
    }

    /// <summary>
    /// Provides extensions to the <see cref="OresAndMetals"/> enumeration.
    /// </summary>
    public static class OresAndMetalsExtensions
    {
        /// <summary>
        /// Gets the sprite for a rock of the specified material.
        /// </summary>
        /// <param name="oreMetal">The ore or metal to get the rock sprite of.</param>
        /// <exception cref="ArgumentException"><paramref name="oreMetal"/> is an alloy (bronze or steel).</exception>
        public static Image GetRockSprite(this OresAndMetals oreMetal)
        {
            switch (oreMetal)
            {
                case OresAndMetals.Boulder:
                    return Resources.boulder;
                case OresAndMetals.Coal:
                    return Resources.coal_rock;
                case OresAndMetals.Copper:
                    return Resources.copper_rock;
                case OresAndMetals.Densium:
                    return Resources.densium_rock;
                case OresAndMetals.Iron:
                    return Resources.iron_rock;
                case OresAndMetals.Mithril:
                    return Resources.mithril_rock;
                case OresAndMetals.Tin:
                    return Resources.tin_rock;
                default:
                    throw new ArgumentException(Resources.RockTypeCannotExist, "oreMetal");
            }
        }

        /// <summary>
        /// Gets the amount of damage a particular type of rock will cause by hitting the player.
        /// These amounts are 1/10th of the rock's density plus 10, as all rocks are roughly of equal volume.
        /// Boulders are fixed at 249 damage.
        /// </summary>
        /// <param name="oreMetal">The ore to find the damage amount of.</param>
        /// <exception cref="ArgumentException"><paramref name="oreMetal"/> is an alloy (bronze or steel).</exception>
        public static int GetRockDamage(this OresAndMetals oreMetal)
        {
            if (oreMetal == OresAndMetals.Boulder)
            {
                return 249;
            }
            else if (MaterialTable.Store.ContainsKey(oreMetal))
            {
                return (int)decimal.Truncate(MathHelper.Pow(MaterialTable.Store[oreMetal].Density, 2) / 2.5m);
            }

            throw new ArgumentException(Resources.RockTypeCannotExist, "oreMetal");
        }

        /// <summary>
        /// Gets the number of points awarded for mining a rock of a particular type.
        /// These amounts are equal to the mining levels associated with each rock type plus 1.
        /// </summary>
        /// <param name="oreMetal">The type of rock to find the points for.</param>
        /// <exception cref="ArgumentException"><paramref name="oreMetal"/> is an alloy (bronze or steel).</exception>
        public static int GetRockPoints(this OresAndMetals oreMetal)
        {
            if (oreMetal == OresAndMetals.Boulder)
            {
                return 0;
            }
            else if (MaterialTable.Store.ContainsKey(oreMetal) && MaterialTable.Store[oreMetal].IsAlloy)
            {
                throw new ArgumentException(Resources.RockTypeCannotExist, "oreMetal");
            }

            return (MaterialTable.Store[oreMetal].MiningLevel + 1) * 100;
        }

        /// <summary>
        /// Gets the number of hitpoints a particular rock has. The hitpoints of any rock
        /// is equal to its award points times 3, except boulder, which is fixed at 3.
        /// </summary>
        /// <param name="oreMetal">The type of rock to find the points for.</param>
        public static int GetRockHitpoints(this OresAndMetals oreMetal)
        {
            if (oreMetal == OresAndMetals.Boulder)
            {
                return 3;
            }

            return (MaterialTable.Store[oreMetal].MiningLevel + 1) * 3;
        }
    }
}
