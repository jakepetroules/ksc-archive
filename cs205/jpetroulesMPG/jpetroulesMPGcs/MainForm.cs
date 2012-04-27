// MPG
// Jake Petroules
// 2010-09-10
// This program allows the user to calculate a vehicle's fuel efficiency by providing the amount of fuel used and the distance traveled

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace jpetroulesMPGcs
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Ensures that the user enters a numeric value in the distance traveled text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void distanceTraveledTextBox_Validating(object sender, CancelEventArgs e)
        {
            double number;
            bool valid = double.TryParse(this.distanceTraveledTextBox.Text, out number);

            this.distanceTraveledErrorProvider.SetError(this.distanceTraveledTextBox, valid && number > 0 ? string.Empty : "Please enter a number greater than 0.");
        }

        /// <summary>
        /// Ensures that the user enters a numeric value in the fuel used text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void fuelUsedTextBox_Validating(object sender, CancelEventArgs e)
        {
            double number;
            bool valid = double.TryParse(this.fuelUsedTextBox.Text, out number);

            this.fuelUsedErrorProvider.SetError(this.fuelUsedTextBox, valid && number > 0 ? string.Empty : "Please enter a number greater than 0.");
        }

        /// <summary>
        /// Calculates the fuel efficiency and displays the result in the fuel efficiency text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double distanceTraveled = 0;
            double fuelUsed = 0;

            bool wasNumeric = double.TryParse(this.distanceTraveledTextBox.Text, out distanceTraveled) && double.TryParse(this.fuelUsedTextBox.Text, out fuelUsed);
            if (wasNumeric && distanceTraveled > 0 && fuelUsed > 0)
            {
                this.fuelEfficiencyTextBox.Text = (distanceTraveled / fuelUsed).ToString("N2");
            }
            else
            {
                this.fuelEfficiencyTextBox.Text = "Invalid";
            }
        }

        /// <summary>
        /// Resets the form, clearing all input, output and error providers.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            this.distanceTraveledTextBox.Clear();
            this.fuelUsedTextBox.Clear();
            this.fuelEfficiencyTextBox.Clear();
            this.distanceTraveledErrorProvider.Clear();
            this.fuelUsedErrorProvider.Clear();
        }
    }
}
