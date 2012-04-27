namespace jpetroulesMIDTERM
{
    using System;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents a molecule, encapsulating its chemical formula and given name.
    /// </summary>
    public sealed class Molecule
    {
        /// <summary>
        /// The collection of chemical elements and atom counts comprising the moecule.
        /// </summary>
        private Collection<ChemicalFormulaComponent> chemicalFormula;

        /// <summary>
        /// Initializes a new instance of the <see cref="Molecule"/> class.
        /// </summary>
        /// <param name="name">The name of the molecule/substance.</param>
        /// <param name="chemicalFormula">The chemical formula of the molecule/substance.</param>
        public Molecule(string name, params ChemicalFormulaComponent[] chemicalFormula)
        {
            this.Name = name;
            this.chemicalFormula = new Collection<ChemicalFormulaComponent>(chemicalFormula);
        }

        /// <summary>
        /// Gets the name of the molecule/substance.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets notes regarding the molecule/substance.
        /// </summary>
        public string Notes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the chemical formula of the molecule/substance.
        /// </summary>
        public ReadOnlyCollection<ChemicalFormulaComponent> ChemicalFormula
        {
            get { return new ReadOnlyCollection<ChemicalFormulaComponent>(this.chemicalFormula); }
        }

        /// <summary>
        /// Returns a string formatted as the molecule's chemical formula.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder formula = new StringBuilder();

            for (int i = 0; i < this.chemicalFormula.Count; i++)
            {
                ChemicalFormulaComponent cfc = this.chemicalFormula[i];
                formula.Append(cfc.Element.Symbol);
                if (cfc.AtomCount > 1)
                {
                    formula.Append(cfc.AtomCount);
                }
            }

            return formula.ToString();
        }

        /// <summary>
        /// Parses a chemical formula from a string.
        /// </summary>
        /// <param name="chemicalFormula">The string to parse.</param>
        /// <exception cref="FormatException">The chemical formula was in an invalid format.</exception>
        public static Collection<ChemicalFormulaComponent> FormulaFromString(string chemicalFormula)
        {
            Collection<ChemicalFormulaComponent> formula = new Collection<ChemicalFormulaComponent>();
            string elementRegex = "([A-Z][a-z]*)([0-9]*)";
            string validateRegex = "^(" + elementRegex + ")+$";

            if (!Regex.IsMatch(chemicalFormula, validateRegex))
            {
                throw new FormatException("Input string was in an incorrect format.");
            }

            foreach (Match match in Regex.Matches(chemicalFormula, elementRegex))
            {
                string name = match.Groups[1].Value;

                int count = match.Groups[2].Value != string.Empty ? int.Parse(match.Groups[2].Value) : 1;

                formula.Add(new ChemicalFormulaComponent(ChemicalElement.ElementFromSymbol(name), count));
            }

            return formula;
        }
    }
}
