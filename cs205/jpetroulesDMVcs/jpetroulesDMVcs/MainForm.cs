using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jpetroulesDMVcs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMVDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMVDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dMVDataSet.Customers);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMVDataSet);

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMVDataSet.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter.Fill(this.dMVDataSet.Receipts);
            // TODO: This line of code loads data into the 'dMVDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.dMVDataSet.Vehicles);
            // TODO: This line of code loads data into the 'dMVDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dMVDataSet.Customers);

        }
    }
}
