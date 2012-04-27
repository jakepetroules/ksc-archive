namespace jpetroulesMIDTERM
{
    /// <summary>
    /// Represents a component in a chemical formula by encapsulating a chemical element
    /// and the number of atoms it contributes in a particular molecule. For example,
    /// the "Al2" in "Al2O3" is represented as a chemical formula component.
    /// </summary>
    public sealed class ChemicalFormulaComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChemicalFormulaComponent"/> class.
        /// </summary>
        /// <param name="element">The chemical element that is part of the molecule.</param>
        /// <param name="atomCount">The number of atoms contributed to the molecule.</param>
        public ChemicalFormulaComponent(ChemicalElement element, int atomCount = 1)
        {
            this.Element = element;
            this.AtomCount = atomCount;
        }

        /// <summary>
        /// Gets the chemical element that is part of the molecule.
        /// </summary>
        public ChemicalElement Element
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of atoms contributed to the molecule.
        /// </summary>
        public int AtomCount
        {
            get;
            private set;
        }
    }
}
