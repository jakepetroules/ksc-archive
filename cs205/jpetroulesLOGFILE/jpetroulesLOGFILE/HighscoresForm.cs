using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace jpetroulesMIDTERM
{
    public partial class HighscoresForm : Form
    {
        public HighscoresForm()
        {
            InitializeComponent();
        }

        private void HighscoresForm_Load(object sender, EventArgs e)
        {
            using (FileStream stream = File.Open(Path.Combine(Application.StartupPath, "highscores.txt"), FileMode.OpenOrCreate))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    using (CsvReader reader = new CsvReader(streamReader, false))
                    {
                        while (reader.ReadNextRecord())
                        {
                            this.dataGridView.Rows.Add(reader[0], reader[1], reader[2]);
                        }
                    }
                }
            }

            this.dataGridView.Sort(this.ScoreColumn, ListSortDirection.Descending);
        }
    }
}
