using System;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace jpetroulesCONDOcs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Generates a receipt containing customer information, rental unit, rental period,
        /// optional services and payment information and returns the result as a string.
        /// </summary>
        private string GenerateReceipt()
        {
            StringBuilder builder = new StringBuilder();

            // Add the customer information
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "{0} {1} {2}", this.firstNameTextBox.Text, this.middleNameTextBox.Text, this.lastNameTextBox.Text));
            builder.AppendLine(this.streetAddressTextBox.Text);
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "{0}, {1} {2}", this.cityTextBox.Text, this.stateComboBox.Text, this.zipCodeMaskedTextBox.MaskedTextProvider.ToString()));
            builder.AppendLine(this.phoneMaskedTextBox.MaskedTextProvider.ToString());
            builder.AppendLine(this.emailAddressTextBox.Text);
            builder.AppendLine();

            // Add the rental unit information
            if (this.studioRadioButton.Checked)
            {
                builder.AppendLine(this.studioRadioButton.Text);
            }
            else if (this.suite2RadioButton.Checked)
            {
                builder.AppendLine(this.suite2RadioButton.Text);
            }
            else if (this.suite3RadioButton.Checked)
            {
                builder.AppendLine(this.suite3RadioButton.Text);
            }
            else if (this.penthouseRadioButton.Checked)
            {
                builder.AppendLine(this.penthouseRadioButton.Text);
            }

            // Add the rental period information (check-in/check-out times)
            TimeSpan rentalPeriod = this.checkOutDateTimePicker.Value.Date - this.checkInDateTimePicker.Value.Date;
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Check in: {0}", this.checkInDateTimePicker.Value.Date));
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Check out: {0}", this.checkOutDateTimePicker.Value.Date));
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Rental period: {0} days", rentalPeriod.Days));
            builder.AppendLine();

            // Add the optional services if they were selected
            if (this.maidServiceCheckBox.Checked || this.linenServiceCheckBox.Checked || this.limoServiceCheckBox.Checked)
            {
                builder.AppendLine("Optional services:");
            }

            if (this.maidServiceCheckBox.Checked)
            {
                builder.AppendLine(this.maidServiceCheckBox.Text);
            }

            if (this.linenServiceCheckBox.Checked)
            {
                builder.AppendLine(this.linenServiceCheckBox.Text);
            }

            if (this.limoServiceCheckBox.Checked)
            {
                builder.AppendLine(this.limoServiceCheckBox.Text);
            }

            // Add the customer's total bill
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture, "Grand total: {0:C}", this.CalculateTotal()));

            return builder.ToString();
        }

        /// <summary>
        /// Calculates the customer's total bill and returns the result as a decimal.
        /// </summary>
        private decimal CalculateTotal()
        {
            TimeSpan rentalPeriod = this.checkOutDateTimePicker.Value.Date - this.checkInDateTimePicker.Value.Date;

            // The total cost of the customer's condo rental
            decimal totalCost = 0;

            // Determine the weekly price of the selected rental unit
            decimal weeklyUnitPrice = 0;
            if (this.studioRadioButton.Checked)
            {
                weeklyUnitPrice = 1000;
            }
            else if (this.suite2RadioButton.Checked)
            {
                weeklyUnitPrice = 2000;
            }
            else if (this.suite3RadioButton.Checked)
            {
                weeklyUnitPrice = 3000;
            }
            else if (this.penthouseRadioButton.Checked)
            {
                weeklyUnitPrice = 15000;
            }

            // Add the cost of the unit for the amount of days in the rental period
            totalCost += (weeklyUnitPrice / 7) * rentalPeriod.Days;

            // If they're renting for 3 months or more, give them a 20% discount
            if (rentalPeriod.Days >= 90)
            {
                totalCost *= 0.8m;
            }

            // Maid service is $100/day
            if (this.maidServiceCheckBox.Checked)
            {
                totalCost += 100 * rentalPeriod.Days;
            }

            // The penthouse has 4 bedrooms; the cost is $20/day per bedroom, so we multiply by 4 bedrooms
            // if the penthouse was selected, otherwise just multiply by 1 bedroom
            if (this.linenServiceCheckBox.Checked)
            {
                totalCost += 20 * rentalPeriod.Days * (this.penthouseRadioButton.Checked ? 4 : 1);
            }

            // Limo service is $75/day
            if (this.limoServiceCheckBox.Checked)
            {
                totalCost += 75 * rentalPeriod.Days;
            }

            // Vermont has a 5% rooms and meals tax
            return totalCost * 1.05m;
        }

        /// <summary>
        /// Determines whether the user has entered complete and valid input in all fields.
        /// </summary>
        private bool IsInputValid()
        {
            return
                this.ValidateForControl(this.firstNameTextBox) &
                this.ValidateForControl(this.middleNameTextBox) &
                this.ValidateForControl(this.lastNameTextBox) &
                this.ValidateForControl(this.streetAddressTextBox) &
                this.ValidateForControl(this.cityTextBox) &
                this.ValidateForControl(this.stateComboBox) &
                this.ValidateForControl(this.zipCodeMaskedTextBox) &
                this.ValidateForControl(this.phoneMaskedTextBox) &
                this.ValidateForControl(this.emailAddressTextBox) &
                this.ValidateForControl(this.checkInDateTimePicker) &
                this.ValidateForControl(this.checkOutDateTimePicker) &
                this.ValidateForControl(this.rentalUnitsGroupBox);
        }

        /// <summary>
        /// Runs validation for the specified control and returns whether its corresponding input is valid.
        /// </summary>
        /// <param name="control">The control to validate.</param>
        private bool ValidateForControl(Control control)
        {
            TextBox firstNameTextBox = control as TextBox;
            if (firstNameTextBox == this.firstNameTextBox)
            {
                if (string.IsNullOrWhiteSpace(this.firstNameTextBox.Text))
                {
                    this.firstNameErrorProvider.SetError(this.firstNameTextBox, "Please enter a first name.");
                    return false;
                }
                else
                {
                    this.firstNameErrorProvider.Clear();
                    return true;
                }
            }

            TextBox middleNameTextBox = control as TextBox;
            if (middleNameTextBox == this.middleNameTextBox)
            {
                if (string.IsNullOrWhiteSpace(this.middleNameTextBox.Text))
                {
                    this.middleNameErrorProvider.SetError(this.middleNameTextBox, "Please enter a middle name.");
                    return false;
                }
                else
                {
                    this.middleNameErrorProvider.Clear();
                    return true;
                }
            }

            TextBox lastNameTextBox = control as TextBox;
            if (lastNameTextBox == this.lastNameTextBox)
            {
                if (String.IsNullOrWhiteSpace(this.lastNameTextBox.Text))
                {
                    this.lastNameErrorProvider.SetError(this.lastNameTextBox, "Please enter a last name.");
                    return false;
                }
                else
                {
                    this.lastNameErrorProvider.Clear();
                    return true;
                }
            }

            TextBox streetAddressTextBox = control as TextBox;
            if (streetAddressTextBox == this.streetAddressTextBox)
            {
                if (String.IsNullOrWhiteSpace(this.streetAddressTextBox.Text))
                {
                    this.streetAddressErrorProvider.SetError(this.streetAddressTextBox, "Please enter a street address.");
                    return false;
                }
                else
                {
                    this.streetAddressErrorProvider.Clear();
                    return true;
                }
            }

            TextBox cityTextBox = control as TextBox;
            if (cityTextBox == this.cityTextBox)
            {
                if (String.IsNullOrWhiteSpace(this.cityTextBox.Text))
                {
                    this.cityErrorProvider.SetError(this.cityTextBox, "Please enter a city.");
                    return false;
                }
                else
                {
                    this.cityErrorProvider.Clear();
                    return true;
                }
            }

            ComboBox stateComboBox = control as ComboBox;
            if (stateComboBox == this.stateComboBox)
            {
                if (this.stateComboBox.SelectedIndex < 0)
                {
                    this.stateErrorProvider.SetError(this.stateComboBox, "Please select a state.");
                    return false;
                }
                else
                {
                    this.stateErrorProvider.Clear();
                    return true;
                }
            }

            MaskedTextBox zipCodeMaskedTextBox = control as MaskedTextBox;
            if (zipCodeMaskedTextBox == this.zipCodeMaskedTextBox)
            {
                if (this.zipCodeMaskedTextBox.MaskCompleted)
                {
                    this.zipCodeErrorProvider.Clear();
                    return true;
                }
                else
                {
                    this.zipCodeErrorProvider.SetError(this.zipCodeMaskedTextBox, "Please enter a valid ZIP code.");
                    return false;
                }
            }

            MaskedTextBox phoneMaskedTextBox = control as MaskedTextBox;
            if (phoneMaskedTextBox == this.phoneMaskedTextBox)
            {
                if (this.phoneMaskedTextBox.MaskCompleted)
                {
                    this.phoneErrorProvider.Clear();
                    return true;
                }
                else
                {
                    this.phoneErrorProvider.SetError(this.phoneMaskedTextBox, "Please enter a valid telephone number.");
                    return false;
                }
            }

            TextBox emailAddressTextBox = control as TextBox;
            if (emailAddressTextBox == this.emailAddressTextBox)
            {
                MailAddress email;
                try
                {
                    email = new MailAddress(this.emailAddressTextBox.Text);
                    this.emailAddressErrorProvider.Clear();
                    return true;
                }
                catch (ArgumentException)
                {
                    this.emailAddressErrorProvider.SetError(this.emailAddressTextBox, "Please enter an email address.");
                    return false;
                }
                catch (FormatException)
                {
                    this.emailAddressErrorProvider.SetError(this.emailAddressTextBox, "Please enter a valid email address.");
                    return false;
                }
            }

            DateTimePicker checkInDateTimePicker = control as DateTimePicker;
            DateTimePicker checkOutDateTimePicker = control as DateTimePicker;
            if (checkInDateTimePicker == this.checkInDateTimePicker || checkOutDateTimePicker == this.checkOutDateTimePicker)
            {
                TimeSpan rentalPeriod = this.checkOutDateTimePicker.Value.Date - this.checkInDateTimePicker.Value.Date;
                if (rentalPeriod.TotalDays > 0)
                {
                    this.rentalTermLabel.Text = string.Format(CultureInfo.CurrentCulture, "You have selected a rental period of {0} days", rentalPeriod.Days);
                    this.rentalTermLabel.ForeColor = Label.DefaultForeColor;
                    return true;
                }
                else
                {
                    this.rentalTermLabel.Text = "Check in time cannot be equal to or later than check out time";
                    this.rentalTermLabel.ForeColor = Color.Red;
                    return false;
                }
            }

            GroupBox rentalUnitsGroupBox = control as GroupBox;
            if (rentalUnitsGroupBox == this.rentalUnitsGroupBox)
            {
                bool oneButtonChecked = this.studioRadioButton.Checked ^ this.suite2RadioButton.Checked ^ this.suite3RadioButton.Checked ^ this.penthouseRadioButton.Checked;
                if (oneButtonChecked)
                {
                    this.rentalUnitsErrorProvider.Clear();
                    return true;
                }
                else
                {
                    this.rentalUnitsErrorProvider.SetError(this.rentalUnitsGroupBox, "Please select a rental unit.");
                    return false;
                }
            }

            // An invalid control can just return false
            return false;
        }

        private void generateReceiptButton_Click(object sender, EventArgs e)
        {
            if (this.IsInputValid())
            {
                this.outputRichTextBox.Text = this.GenerateReceipt();
            }
            else
            {
                MessageBox.Show("Please correct the input errors before generating a receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.firstNameTextBox);
        }

        private void middleNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.middleNameTextBox);
        }

        private void lastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.lastNameTextBox);
        }

        private void streetAddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.streetAddressTextBox);
        }

        private void cityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.cityTextBox);
        }

        private void stateComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.stateComboBox);
        }

        private void zipCodeMaskedTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.zipCodeMaskedTextBox);
        }

        private void phoneMaskedTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.phoneMaskedTextBox);
        }

        private void emailAddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.emailAddressTextBox);
        }

        private void checkInAndCheckOutDateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            this.ValidateForControl(this.checkInDateTimePicker);
            this.ValidateForControl(this.checkOutDateTimePicker);
        }

        private void rentalUnitsRadioButtons_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ValidateForControl(this.rentalUnitsGroupBox);
        }
    }
}
