// PAYMENTS
// Jake Petroules
// 2010-09-19
// This program allows the user to calculate monthly payments for a loan by providing the interest rate, number of payments, and principle

using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace jpetroulesPAYMENTScs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Ensures that the user enters a numeric value in the interest rate text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void interestRateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double number;
            bool valid = double.TryParse(this.interestRateTextBox.Text, out number);

            this.interestRateErrorProvider.SetError(this.interestRateTextBox, valid && number >= 0 ? string.Empty : "Please enter a number greater than or equal to 0.");
        }

        /// <summary>
        /// Ensures that the user enters an integer value in the number of payments text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void numberOfPaymentsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double number;
            bool valid = double.TryParse(this.numberOfPaymentsTextBox.Text, out number);

            this.numberOfPaymentsErrorProvider.SetError(this.numberOfPaymentsTextBox, valid && number > 0 ? string.Empty : "Please enter a number greater than 0.");
        }

        /// <summary>
        /// Ensures that the user enters a numeric value in the principle text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void principleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double number;
            bool valid = double.TryParse(this.principleTextBox.Text, out number);

            this.principleErrorProvider.SetError(this.principleTextBox, valid && number > 0 ? string.Empty : "Please enter a number greater than 0.");
        }

        /// <summary>
        /// Calculates the monthly payment and displays the result in the monthly payment text box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            double interestRate = 0;
            int numberOfPayments = 0;
            double principle = 0;

            bool wasNumeric = double.TryParse(this.interestRateTextBox.Text, out interestRate) &&
                              int.TryParse(this.numberOfPaymentsTextBox.Text, out numberOfPayments) &&
                              double.TryParse(this.principleTextBox.Text, out principle);
            if (wasNumeric && interestRate >= 0 && numberOfPayments > 0 && principle > 0)
            {
                if (interestRate > 1)
                {
                    interestRate /= 100;
                }

                this.monthlyPaymentTextBox.Text = Financial.Pmt(interestRate / 12, numberOfPayments, -principle).ToString("N2");
            }
            else
            {
                this.monthlyPaymentTextBox.Text = "Invalid";
            }
        }

        /// <summary>
        /// Resets the form, clearing all input, output and error providers.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void resetButton_Click(object sender, System.EventArgs e)
        {
            this.interestRateTextBox.Clear();
            this.numberOfPaymentsTextBox.Clear();
            this.principleTextBox.Clear();
            this.monthlyPaymentTextBox.Clear();
            this.interestRateErrorProvider.Clear();
            this.numberOfPaymentsErrorProvider.Clear();
            this.principleErrorProvider.Clear();
        }

        private void exitMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void changeFontMenuItem_Click(object sender, System.EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Font = dialog.Font;
            }
        }

        private void changeTextColorMenuItem_Click(object sender, System.EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = dialog.Color;
            }
        }

        private void changeBackgroundColorMenuItem_Click(object sender, System.EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dialog.Color;
            }
        }

        private void resetFontsAndColorsMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Font = Control.DefaultFont;
            this.ForeColor = Control.DefaultForeColor;
            this.BackColor = Control.DefaultBackColor;
        }

        private void aboutMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Monthly Payment Calculator 1.0", "About Monthly Payment Calculator", MessageBoxButtons.OK);
        }
    }
}
