namespace YaakovsMine
{
    using System;

    /// <summary>
    /// Enumerates different grades of pickaxes.
    /// </summary>
    public enum PickaxeType
    {
        /// <summary>
        /// Indicates a bronze pickaxe.
        /// </summary>
        Bronze = 1,

        /// <summary>
        /// Indicates an iron pickaxe.
        /// </summary>
        Iron = 2,

        /// <summary>
        /// Indicates a steel pickaxe.
        /// </summary>
        Steel = 3,

        /// <summary>
        /// Indicates a mithril pickaxe.
        /// </summary>
        Mithril = 4,

        /// <summary>
        /// Indicates a densium pickaxe.
        /// </summary>
        Densium = 5
    }

    /// <summary>
    /// Provides extensions to the <see cref="PickaxeType"/> enumeration.
    /// </summary>
    public static class PickaxeLevelExtensions
    {
        /// <summary>
        /// Gets the maximum damage inflicted by a pickaxe, which is 1/5th of the metal's ultimate tensile strength.
        /// </summary>
        /// <param name="pickaxe">The pickaxe to get the maximum damage of.</param>
        /// <exception cref="ArgumentException"><paramref name="pickaxe"/> is an invalid enum argument.</exception>
        public static int GetMaximumDamage(this PickaxeType pickaxe)
        {
            Material<OresAndMetals> material = null;

            switch (pickaxe)
            {
                case PickaxeType.Bronze:
                    material = MaterialTable.Store[OresAndMetals.Bronze];
                    break;
                case PickaxeType.Iron:
                    material = MaterialTable.Store[OresAndMetals.Iron];
                    break;
                case PickaxeType.Steel:
                    material = MaterialTable.Store[OresAndMetals.Steel];
                    break;
                case PickaxeType.Mithril:
                    material = MaterialTable.Store[OresAndMetals.Mithril];
                    break;
                case PickaxeType.Densium:
                    material = MaterialTable.Store[OresAndMetals.Densium];
                    break;
                default:
                    throw new ArgumentException("Invalid enum argument.");
            }

            return (int)decimal.Truncate(material.UltimateTensileStrength / 3);
        }
    }
}
