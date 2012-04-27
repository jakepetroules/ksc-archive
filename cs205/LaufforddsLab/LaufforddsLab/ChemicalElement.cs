namespace Petroules.LaufforddsLab
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using LumenWorks.Framework.IO.Csv;
    using Petroules.LaufforddsLab.Properties;

    /// <summary>
    /// Represents a chemical element.
    /// </summary>
    public sealed class ChemicalElement
    {
        /// <summary>
        /// A list of the known chemical elements.
        /// </summary>
        private static Collection<ChemicalElement> elements = new Collection<ChemicalElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChemicalElement"/> class.
        /// </summary>
        /// <param name="atomicNumber">The atomic number of the chemical element.</param>
        /// <param name="name">The official IUPAC name of the chemical element.</param>
        /// <param name="symbol">The symbol representing the element.</param>
        public ChemicalElement(int atomicNumber, string name, string symbol)
        {
            this.AtomicNumber = atomicNumber;
            this.Name = name;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Gets a list of the known chemical elements.
        /// </summary>
        public static ReadOnlyCollection<ChemicalElement> ChemicalElements
        {
            get { return new ReadOnlyCollection<ChemicalElement>(ChemicalElement.elements); }
        }

        /// <summary>
        /// Retrieves a chemical element from its atomic number, or null if no such element exists.
        /// </summary>
        /// <param name="atomicNumber">The atomic number of the chemical element to retrieve.</param>
        public static ChemicalElement ElementFromNumber(int atomicNumber)
        {
            return ChemicalElement.ChemicalElements.FirstOrDefault(p => p.AtomicNumber == atomicNumber);
        }

        /// <summary>
        /// Retrieves a chemical element from its symbol, or null if no such element exists.
        /// </summary>
        /// <param name="symbol">The symbol of the chemical element to retrieve.</param>
        public static ChemicalElement ElementFromSymbol(string symbol)
        {
            return ChemicalElement.ChemicalElements.FirstOrDefault(p => p.Symbol == symbol);
        }

        /// <summary>
        /// Gets the atomic number of the chemical element.
        /// </summary>
        public int AtomicNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the official IUPAC name of the chemical element.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the symbol representing the element.
        /// </summary>
        public string Symbol
        {
            get;
            private set;
        }

        /// <summary>
        /// Reads the list of known chemical elements from the embedded resource file.
        /// </summary>
        static ChemicalElement()
        {
            using (CsvReader reader = new CsvReader(new StringReader(Resources.elements), false))
            {
                while (reader.ReadNextRecord())
                {
                    int atomicNumber = Convert.ToInt32(reader[0]);
                    string name = reader[1];
                    string symbol = reader[2];
                    ChemicalElement.elements.Add(new ChemicalElement(atomicNumber, name, symbol));
                }
            }
        }
    }
}
