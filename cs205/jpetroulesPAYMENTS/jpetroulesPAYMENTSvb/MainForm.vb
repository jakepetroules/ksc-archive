' PAYMENTS
' Jake Petroules
' 2010-09-19
' This program allows the user to calculate monthly payments for a loan by providing the interest rate, number of payments, and principle

Option Strict On
Option Explicit On

Public Class MainForm
    ''' <summary>
    ''' Ensures that the user enters a numeric value in the interest rate text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.CancelEventArgs" /> instance containing the event data.</param>
    Private Sub interestRateTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles interestRateTextBox.Validating
        Dim number As Double
        Dim valid As Boolean = Double.TryParse(Me.interestRateTextBox.Text, number)

        Me.interestRateErrorProvider.SetError(Me.interestRateTextBox, If(valid And number >= 0, String.Empty, "Please enter a number greater than or equal to 0."))
    End Sub

    ''' <summary>
    ''' Ensures that the user enters an integer value in the number of payments text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.CancelEventArgs" /> instance containing the event data.</param>
    Private Sub numberOfPaymentsTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numberOfPaymentsTextBox.Validating
        Dim number As Integer
        Dim valid As Boolean = Integer.TryParse(Me.numberOfPaymentsTextBox.Text, number)

        Me.numberOfPaymentsErrorProvider.SetError(Me.numberOfPaymentsTextBox, If(valid And number > 0, String.Empty, "Please enter a number greater than 0."))
    End Sub

    ''' <summary>
    ''' Ensures that the user enters a numeric value in the principle text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.CancelEventArgs" /> instance containing the event data.</param>
    Private Sub principleTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles principleTextBox.Validating
        Dim number As Double
        Dim valid As Boolean = Double.TryParse(Me.principleTextBox.Text, number)

        Me.principleErrorProvider.SetError(Me.principleTextBox, If(valid And number > 0, String.Empty, "Please enter a number greater than 0."))
    End Sub

    ''' <summary>
    ''' Calculates the monthly payment and displays the result in the monthly payment text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim interestRate As Double = 0
        Dim numberOfPayments As Integer = 0
        Dim principle As Double = 0

        Dim wasNumeric As Boolean = Double.TryParse(Me.interestRateTextBox.Text, interestRate) And
                                    Integer.TryParse(Me.numberOfPaymentsTextBox.Text, numberOfPayments) And
                                    Double.TryParse(Me.principleTextBox.Text, principle)
        If (wasNumeric And interestRate >= 0 And numberOfPayments > 0 And principle > 0) Then
            If interestRate > 1 Then
                interestRate /= 100
            End If

            Me.monthlyPaymentTextBox.Text = Financial.Pmt(interestRate / 12, numberOfPayments, -principle).ToString("N2")
        Else
            Me.monthlyPaymentTextBox.Text = "Invalid"
        End If
    End Sub

    ''' <summary>
    ''' Resets the form, clearing all input, output and error providers.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        Me.interestRateTextBox.Clear()
        Me.numberOfPaymentsTextBox.Clear()
        Me.principleTextBox.Clear()
        Me.monthlyPaymentTextBox.Clear()
        Me.interestRateErrorProvider.Clear()
        Me.numberOfPaymentsErrorProvider.Clear()
        Me.principleErrorProvider.Clear()
    End Sub

    Private Sub exitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub changeFontMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeFontMenuItem.Click
        Dim dialog As FontDialog = New FontDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            Me.Font = dialog.Font
        End If
    End Sub

    Private Sub changeTextColorMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeTextColorMenuItem.Click
        Dim dialog As ColorDialog = New ColorDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = dialog.Color
        End If
    End Sub

    Private Sub changeBackgroundColorMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changeBackgroundColorMenuItem.Click
        Dim dialog As ColorDialog = New ColorDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            Me.BackColor = dialog.Color
        End If
    End Sub

    Private Sub resetFontsAndColorsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetFontsAndColorsMenuItem.Click
        Me.Font = Control.DefaultFont
        Me.ForeColor = Control.DefaultForeColor
        Me.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub aboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutMenuItem.Click
        MessageBox.Show("Monthly Payment Calculator 1.0", "About Monthly Payment Calculator", MessageBoxButtons.OK)
    End Sub
End Class
