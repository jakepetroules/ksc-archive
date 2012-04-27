' CONDO
' Jake Petroules
' 2010-10-11
' This program allows condominium rentals to be made at Mt. Snow

Option Strict On
Option Explicit On

Imports System.Globalization
Imports System.Net.Mail
Imports System.Text

Public Class MainForm
    ''' <summary>
    ''' Generates a receipt containing customer information, rental unit, rental period,
    ''' optional services and payment information and returns the result as a string.
    ''' </summary>
    Private Function GenerateReceipt() As String
        Dim builder As StringBuilder = New StringBuilder()

        ' Add the customer information
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "{0} {1} {2}", Me.firstNameTextBox.Text, Me.middleNameTextBox.Text, Me.lastNameTextBox.Text))
        builder.AppendLine(Me.streetAddressTextBox.Text)
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "{0}, {1} {2}", Me.cityTextBox.Text, Me.stateComboBox.Text, Me.zipCodeMaskedTextBox.MaskedTextProvider.ToString()))
        builder.AppendLine(Me.phoneMaskedTextBox.MaskedTextProvider.ToString())
        builder.AppendLine(Me.emailAddressTextBox.Text)
        builder.AppendLine()

        ' Add the rental unit information
        If Me.studioRadioButton.Checked Then
            builder.AppendLine(Me.studioRadioButton.Text)
        ElseIf Me.suite2RadioButton.Checked Then
            builder.AppendLine(Me.suite2RadioButton.Text)
        ElseIf Me.suite3RadioButton.Checked Then
            builder.AppendLine(Me.suite3RadioButton.Text)
        ElseIf Me.penthouseRadioButton.Checked Then
            builder.AppendLine(Me.penthouseRadioButton.Text)
        End If

        ' Add the rental period information (check-in/check-out times)
        Dim rentalPeriod As TimeSpan = Me.checkOutDateTimePicker.Value.Date - Me.checkInDateTimePicker.Value.Date
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "Check in: {0}", Me.checkInDateTimePicker.Value.Date))
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "Check out: {0}", Me.checkOutDateTimePicker.Value.Date))
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "Rental period: {0} days", rentalPeriod.Days))
        builder.AppendLine()

        ' Add the optional services if they were selected
        If Me.maidServiceCheckBox.Checked OrElse Me.linenServiceCheckBox.Checked OrElse Me.limoServiceCheckBox.Checked Then
            builder.AppendLine("Optional services:")
        End If

        If Me.maidServiceCheckBox.Checked Then
            builder.AppendLine(Me.maidServiceCheckBox.Text)
        End If

        If Me.linenServiceCheckBox.Checked Then
            builder.AppendLine(Me.linenServiceCheckBox.Text)
        End If

        If Me.limoServiceCheckBox.Checked Then
            builder.AppendLine(Me.limoServiceCheckBox.Text)
        End If

        ' Add the customer's total bill
        builder.AppendLine(String.Format(CultureInfo.CurrentCulture, "Grand total: {0:C}", Me.CalculateTotal()))

        Return builder.ToString()
    End Function

    ''' <summary>
    ''' Calculates the customer's total bill and returns the result as a decimal
    ''' </summary>
    Private Function CalculateTotal() As Decimal
        Dim rentalPeriod As TimeSpan = Me.checkOutDateTimePicker.Value.Date - Me.checkInDateTimePicker.Value.Date

        ' Determine the weekly price of the selected rental unit
        Dim unit As RentalUnit
        If Me.studioRadioButton.Checked Then
            unit = RentalUnit.Studio
        ElseIf Me.suite2RadioButton.Checked Then
            unit = RentalUnit.TwoBedroomSuite
        ElseIf Me.suite3RadioButton.Checked Then
            unit = RentalUnit.ThreeBedroomSuite
        ElseIf Me.penthouseRadioButton.Checked Then
            unit = RentalUnit.Penthouse
        End If

        Dim services As OptionalServices = 0
        If Me.maidServiceCheckBox.Checked Then
            services = services Or OptionalServices.Maid
        End If
        
        If Me.linenServiceCheckBox.Checked Then
            services = services Or OptionalServices.Linen
        End If

        If Me.limoServiceCheckBox.Checked Then
            services = services Or OptionalServices.Limo
        End If

        Return RentalCalculator.CalculateTotal(rentalPeriod, unit, services)
    End Function

    ''' <summary>
    ''' Determines whether the user has entered complete and valid input in all fields.
    ''' </summary>
    Private Function IsInputValid() As Boolean
        Return _
            Me.ValidateForControl(Me.firstNameTextBox) And
            Me.ValidateForControl(Me.middleNameTextBox) And
            Me.ValidateForControl(Me.lastNameTextBox) And
            Me.ValidateForControl(Me.streetAddressTextBox) And
            Me.ValidateForControl(Me.cityTextBox) And
            Me.ValidateForControl(Me.stateComboBox) And
            Me.ValidateForControl(Me.zipCodeMaskedTextBox) And
            Me.ValidateForControl(Me.phoneMaskedTextBox) And
            Me.ValidateForControl(Me.emailAddressTextBox) And
            Me.ValidateForControl(Me.checkInDateTimePicker) And
            Me.ValidateForControl(Me.checkOutDateTimePicker) And
            Me.ValidateForControl(Me.rentalUnitsGroupBox)
    End Function

    ''' <summary>
    ''' Runs validation for the specified control and returns whether its corresponding input is valid.
    ''' </summary>
    ''' <param name="control">The control to validate.</param>
    Private Function ValidateForControl(ByVal control As Control) As Boolean
        Dim firstNameTextBox As TextBox = TryCast(control, TextBox)
        If firstNameTextBox Is Me.firstNameTextBox Then
            If String.IsNullOrWhiteSpace(Me.firstNameTextBox.Text) Then
                Me.firstNameErrorProvider.SetError(Me.firstNameTextBox, "Please enter a first name.")
                Return False
            Else
                Me.firstNameErrorProvider.Clear()
                Return True
            End If
        End If

        Dim middleNameTextBox As TextBox = TryCast(control, TextBox)
        If middleNameTextBox Is Me.middleNameTextBox Then
            If String.IsNullOrWhiteSpace(Me.middleNameTextBox.Text) Then
                Me.middleNameErrorProvider.SetError(Me.middleNameTextBox, "Please enter a middle name.")
                Return False
            Else
                Me.middleNameErrorProvider.Clear()
                Return True
            End If
        End If

        Dim lastNameTextBox As TextBox = TryCast(control, TextBox)
        If lastNameTextBox Is Me.lastNameTextBox Then
            If String.IsNullOrWhiteSpace(Me.lastNameTextBox.Text) Then
                Me.lastNameErrorProvider.SetError(Me.lastNameTextBox, "Please enter a last name.")
                Return False
            Else
                Me.lastNameErrorProvider.Clear()
                Return True
            End If
        End If

        Dim streetAddressTextBox As TextBox = TryCast(control, TextBox)
        If streetAddressTextBox Is Me.streetAddressTextBox Then
            If String.IsNullOrWhiteSpace(Me.streetAddressTextBox.Text) Then
                Me.streetAddressErrorProvider.SetError(Me.streetAddressTextBox, "Please enter a street address.")
                Return False
            Else
                Me.streetAddressErrorProvider.Clear()
                Return True
            End If
        End If

        Dim cityTextBox As TextBox = TryCast(control, TextBox)
        If cityTextBox Is Me.cityTextBox Then
            If String.IsNullOrWhiteSpace(Me.cityTextBox.Text) Then
                Me.cityErrorProvider.SetError(Me.cityTextBox, "Please enter a city.")
                Return False
            Else
                Me.cityErrorProvider.Clear()
                Return True
            End If
        End If

        Dim stateComboBox As ComboBox = TryCast(control, ComboBox)
        If stateComboBox Is Me.stateComboBox Then
            If Me.stateComboBox.SelectedIndex < 0 Then
                Me.stateErrorProvider.SetError(Me.stateComboBox, "Please select a state.")
                Return False
            Else
                Me.stateErrorProvider.Clear()
                Return True
            End If
        End If

        Dim zipCodeMaskedTextBox As MaskedTextBox = TryCast(control, MaskedTextBox)
        If zipCodeMaskedTextBox Is Me.zipCodeMaskedTextBox Then
            If Me.zipCodeMaskedTextBox.MaskCompleted Then
                Me.zipCodeErrorProvider.Clear()
                Return True
            Else
                Me.zipCodeErrorProvider.SetError(Me.zipCodeMaskedTextBox, "Please enter a valid ZIP code.")
                Return False
            End If
        End If

        Dim phoneMaskedTextBox As MaskedTextBox = TryCast(control, MaskedTextBox)
        If phoneMaskedTextBox Is Me.phoneMaskedTextBox Then
            If Me.phoneMaskedTextBox.MaskCompleted Then
                Me.phoneErrorProvider.Clear()
                Return True
            Else
                Me.phoneErrorProvider.SetError(Me.phoneMaskedTextBox, "Please enter a valid telephone number.")
                Return False
            End If
        End If

        Dim emailAddressTextBox As TextBox = TryCast(control, TextBox)
        If emailAddressTextBox Is Me.emailAddressTextBox Then
            Dim email As MailAddress
            Try
                email = New MailAddress(Me.emailAddressTextBox.Text)
                Me.emailAddressErrorProvider.Clear()
                Return True
            Catch argex As ArgumentException
                Me.emailAddressErrorProvider.SetError(Me.emailAddressTextBox, "Please enter an email address.")
                Return False
            Catch fex As FormatException
                Me.emailAddressErrorProvider.SetError(Me.emailAddressTextBox, "Please enter a valid email address.")
                Return False
            End Try
        End If

        Dim checkInDateTimePicker As DateTimePicker = TryCast(control, DateTimePicker)
        Dim checkOutDateTimePicker As DateTimePicker = TryCast(control, DateTimePicker)
        If checkInDateTimePicker Is Me.checkInDateTimePicker OrElse checkOutDateTimePicker Is Me.checkOutDateTimePicker Then
            Dim rentalPeriod As TimeSpan = Me.checkOutDateTimePicker.Value.Date - Me.checkInDateTimePicker.Value.Date
            If rentalPeriod.TotalDays > 0 Then
                Me.rentalTermLabel.Text = String.Format(CultureInfo.CurrentCulture, "You have selected a rental period of {0} days", rentalPeriod.Days)
                Me.rentalTermLabel.ForeColor = Label.DefaultForeColor
                Return True
            Else
                Me.rentalTermLabel.Text = "Check in time cannot be equal to or later than check out time"
                Me.rentalTermLabel.ForeColor = Color.Red
                Return False
            End If
        End If

        Dim rentalUnitsGroupBox As GroupBox = TryCast(control, GroupBox)
        If rentalUnitsGroupBox Is Me.rentalUnitsGroupBox Then
            Dim oneButtonChecked As Boolean = Me.studioRadioButton.Checked Xor Me.suite2RadioButton.Checked Xor Me.suite3RadioButton.Checked Xor Me.penthouseRadioButton.Checked
            If oneButtonChecked Then
                Me.rentalUnitsErrorProvider.Clear()
                Return True
            Else
                Me.rentalUnitsErrorProvider.SetError(Me.rentalUnitsGroupBox, "Please select a rental unit.")
                Return False
            End If
        End If

        ' An invalid control can just return false
        Return False
    End Function

    Private Sub generateReceiptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateReceiptButton.Click, generateReceiptMenuItem.Click
        If Me.IsInputValid() Then
            Me.outputRichTextBox.Text = Me.GenerateReceipt()
        Else
            MessageBox.Show("Please correct the input errors before generating a receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub firstNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles firstNameTextBox.Validating
        Me.ValidateForControl(Me.firstNameTextBox)
    End Sub

    Private Sub middleNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles middleNameTextBox.Validating
        Me.ValidateForControl(Me.middleNameTextBox)
    End Sub

    Private Sub lastNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lastNameTextBox.Validating
        Me.ValidateForControl(Me.lastNameTextBox)
    End Sub

    Private Sub streetAddressTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles streetAddressTextBox.Validating
        Me.ValidateForControl(Me.streetAddressTextBox)
    End Sub

    Private Sub cityTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cityTextBox.Validating
        Me.ValidateForControl(Me.cityTextBox)
    End Sub

    Private Sub stateComboBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles stateComboBox.Validating
        Me.ValidateForControl(Me.stateComboBox)
    End Sub

    Private Sub zipCodeMaskedTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles zipCodeMaskedTextBox.Validating
        Me.ValidateForControl(Me.zipCodeMaskedTextBox)
    End Sub

    Private Sub phoneMaskedTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles phoneMaskedTextBox.Validating
        Me.ValidateForControl(Me.phoneMaskedTextBox)
    End Sub

    Private Sub emailAddressTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles emailAddressTextBox.Validating
        Me.ValidateForControl(Me.emailAddressTextBox)
    End Sub

    Private Sub checkInAndCheckOutDateTimePickers_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkInDateTimePicker.ValueChanged, checkOutDateTimePicker.ValueChanged
        Me.ValidateForControl(Me.checkInDateTimePicker)
        Me.ValidateForControl(Me.checkOutDateTimePicker)
    End Sub

    Private Sub rentalUnitsRadioButtons_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles studioRadioButton.Validating, suite2RadioButton.Validating, suite3RadioButton.Validating, penthouseRadioButton.Validating
        Me.ValidateForControl(Me.rentalUnitsGroupBox)
    End Sub

    Private Sub exitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub aboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutMenuItem.Click
        Dim dialog As AboutBox = New AboutBox
        dialog.ShowDialog()
    End Sub
End Class
