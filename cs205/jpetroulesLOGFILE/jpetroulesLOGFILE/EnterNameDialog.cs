using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jpetroulesMIDTERM
{
    public partial class EnterNameDialog : Form
    {
        public EnterNameDialog()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            get { return this.nameTextBox.Text; }
            set { this.nameTextBox.Text = value; }
        }
    }
}
