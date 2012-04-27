namespace YaakovsMine
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides access to material data.
    /// </summary>
    internal static class MaterialTable
    {
        /// <summary>
        /// The dictionary of materials.
        /// </summary>
        private static Dictionary<OresAndMetals, Material<OresAndMetals>> store = new Dictionary<OresAndMetals, Material<OresAndMetals>>();

        /// <summary>
        /// Initializes static members of the <see cref="MaterialTable"/> class.
        /// </summary>
        static MaterialTable()
        {
            MaterialTable.store.Add(OresAndMetals.Bronze, new Material<OresAndMetals>(OresAndMetals.Bronze, 1010, 498, 8.39m, true));
            MaterialTable.store.Add(OresAndMetals.Coal, new Material<OresAndMetals>(OresAndMetals.Coal, decimal.MaxValue, 6.5m, 1.6m, false));
            MaterialTable.store.Add(OresAndMetals.Copper, new Material<OresAndMetals>(OresAndMetals.Copper, 1083.4m, 344, 7.94m, false));
            MaterialTable.store.Add(OresAndMetals.Densium, new Material<OresAndMetals>(OresAndMetals.Densium, 2377, 1307, 21.87m, false));
            MaterialTable.store.Add(OresAndMetals.Iron, new Material<OresAndMetals>(OresAndMetals.Iron, 1535, 540, 7.87m, false));
            MaterialTable.store.Add(OresAndMetals.Mithril, new Material<OresAndMetals>(OresAndMetals.Mithril, 2142, 1196, 11.1m, false));
            MaterialTable.store.Add(OresAndMetals.Steel, new Material<OresAndMetals>(OresAndMetals.Steel, 1440, 785, 7.86m, true));
            MaterialTable.store.Add(OresAndMetals.Tin, new Material<OresAndMetals>(OresAndMetals.Tin, 231.698m, 220, 5.765m, false));
            MaterialTable.Store = new ReadOnlyDictionary<OresAndMetals, Material<OresAndMetals>>(MaterialTable.store);
        }

        /// <summary>
        /// Gets the dictionary of materials in the table.
        /// </summary>
        public static ReadOnlyDictionary<OresAndMetals, Material<OresAndMetals>> Store
        {
            get;
            private set;
        }
    }
}
