namespace jpetroulesMIDTERM
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;
    using jpetroulesMIDTERM.Properties;
    using LumenWorks.Framework.IO.Csv;
    using System.Linq;

    public static class SubstanceBank
    {
        private static Collection<Molecule> bank = new Collection<Molecule>();

        public static ReadOnlyCollection<Molecule> Bank
        {
            get { return new ReadOnlyCollection<Molecule>(bank); }
        }

        static SubstanceBank()
        {
            using (CsvReader reader = new CsvReader(new StringReader(Resources.substances), false))
            {
                while (reader.ReadNextRecord())
                {
                    string name = reader[0];
                    Collection<ChemicalFormulaComponent> formula = Molecule.FormulaFromString(reader[1]);
                    string notes = reader[2];

                    SubstanceBank.bank.Add(new Molecule(name, formula.ToArray()) { Notes = notes });
                }
            }
        }
    }
}
