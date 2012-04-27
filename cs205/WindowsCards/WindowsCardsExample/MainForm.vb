Imports Petroules.WindowsCards

Public Class MainForm
    Dim cards As CardRenderer = New CardRenderer()
    Dim cardTypeIndex As Integer = -1
    Dim cardIndex As Integer = -1
    Dim backgroundColor As Color = Color.Black

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Render our 4 chosen cards
        Me.PictureBox1.Image = Me.cards.FrontToBitmap(CardSuit.Diamonds, CardFace.Ace)

        ' FrontToBitmap automatically selects InvertedFront card type when supplied the color argument
        Me.PictureBox2.Image = Me.cards.FrontToBitmap(CardSuit.Spades, CardFace.Nine, Color.Turquoise)
        Me.PictureBox3.Image = Me.cards.BackToBitmap(CardBackground.Sky, Color.Black)
        Me.PictureBox4.Image = Me.cards.BackToBitmap(CardBackground.Crosshatch, Color.Yellow)

        ' The rest is magic voodoo
        Dim cardTypes As Array = [Enum].GetNames(GetType(CardType))
        For i As Integer = 0 To cardTypes.Length - 1
            Me.cardTypeComboBox.Items.Add(cardTypes(i))
        Next

        Dim suits As Array = [Enum].GetNames(GetType(CardSuit))
        Dim faces As Array = [Enum].GetNames(GetType(CardFace))
        Dim backgrounds As Array = [Enum].GetNames(GetType(CardBackground))

        For i As Integer = 0 To (suits.Length * faces.Length) - 1
            Me.cardComboBox.Items.Add(faces(CardRenderer.GetCardFace(i)) & " of " & suits(CardRenderer.GetCardSuit(i)))
        Next

        Me.cardComboBox.Items.Add("Unused")

        For i As Integer = 0 To backgrounds.Length - 1
            Me.cardComboBox.Items.Add(backgrounds(i))
        Next
    End Sub

    Private Sub backgroundColorTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backgroundColorTextBox.Click
        Dim dialog As ColorDialog = New ColorDialog
        If dialog.ShowDialog() = DialogResult.OK Then
            Me.backgroundColor = dialog.Color
            Me.backgroundColorTextBox.Text = dialog.Color.ToString()
            Me.backgroundColorTextBox.BackColor = dialog.Color
            Me.backgroundColorTextBox.ForeColor = Me.InverseColor(dialog.Color)

            SetImage()
        End If
    End Sub

    Private Sub ComboBoxIndexesChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardTypeComboBox.SelectedIndexChanged, cardComboBox.SelectedIndexChanged
        Me.cardTypeIndex = Me.cardTypeComboBox.SelectedIndex
        Me.cardIndex = Me.cardComboBox.SelectedIndex
        SetImage()
    End Sub

    Private Sub SetImage()
        If Me.cardIndex > -1 AndAlso Me.cardTypeIndex > -1 Then
            Try
                Me.cardPictureBox.Image = cards.ToBitmap(Me.cardIndex, Me.cardTypeIndex, Me.backgroundColor)
            Catch ex As InvalidOperationException
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Function InverseColor(ByVal colorIn As Color) As Color
        Return Color.FromArgb(colorIn.A, (colorIn.R + 128) Mod 256, (colorIn.G + 128) Mod 256, (colorIn.B + 128) Mod 256)
    End Function
End Class
