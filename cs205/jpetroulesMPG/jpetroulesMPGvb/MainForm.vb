' MPG
' Jake Petroules
' 2010-09-10
' This program allows the user to calculate a vehicle's fuel efficiency by providing the amount of fuel used and the distance traveled

Option Explicit On
Option Strict On

Public Class MainForm
    ''' <summary>
    ''' Ensures that the user enters a numeric value in the distance traveled text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.CancelEventArgs" /> instance containing the event data.</param>
    Private Sub distanceTraveledTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles distanceTraveledTextBox.Validating
        Dim number As Double
        Dim valid As Boolean = Double.TryParse(Me.distanceTraveledTextBox.Text, number)

        Me.distanceTraveledErrorProvider.SetError(Me.distanceTraveledTextBox, If(valid And number > 0, String.Empty, "Please enter a number greater than 0."))
    End Sub

    ''' <summary>
    ''' Ensures that the user enters a numeric value in the fuel used text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.ComponentModel.CancelEventArgs" /> instance containing the event data.</param>
    Private Sub fuelUsedTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fuelUsedTextBox.Validating
        Dim number As Double
        Dim valid As Boolean = Double.TryParse(Me.fuelUsedTextBox.Text, number)

        Me.fuelUsedErrorProvider.SetError(Me.fuelUsedTextBox, If(valid And number > 0, String.Empty, "Please enter a number greater than 0."))
    End Sub

    ''' <summary>
    ''' Calculates the fuel efficiency and displays the result in the fuel efficiency text box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim distanceTraveled As Double = 0
        Dim fuelUsed As Double = 0

        Dim wasNumeric As Boolean = Double.TryParse(Me.distanceTraveledTextBox.Text, distanceTraveled) And Double.TryParse(Me.fuelUsedTextBox.Text, fuelUsed)
        If (wasNumeric And distanceTraveled > 0 And fuelUsed > 0) Then
            Me.fuelEfficiencyTextBox.Text = (distanceTraveled / fuelUsed).ToString("N2")
        Else
            Me.fuelEfficiencyTextBox.Text = "Invalid"
        End If
    End Sub

    ''' <summary>
    ''' Resets the form, clearing all input, output and error providers.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    Private Sub resetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetButton.Click
        Me.distanceTraveledTextBox.Clear()
        Me.fuelUsedTextBox.Clear()
        Me.fuelEfficiencyTextBox.Clear()
        Me.distanceTraveledErrorProvider.Clear()
        Me.fuelUsedErrorProvider.Clear()
    End Sub
End Class
