<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cardTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.cardLabel = New System.Windows.Forms.Label()
        Me.cardComboBox = New System.Windows.Forms.ComboBox()
        Me.cardPictureBox = New System.Windows.Forms.PictureBox()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.backgroundColorLabel = New System.Windows.Forms.Label()
        Me.backgroundColorTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.cardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTableLayoutPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardTypeComboBox
        '
        Me.cardTypeComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cardTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cardTypeComboBox.FormattingEnabled = True
        Me.cardTypeComboBox.Location = New System.Drawing.Point(103, 3)
        Me.cardTypeComboBox.Name = "cardTypeComboBox"
        Me.cardTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cardTypeComboBox.TabIndex = 0
        '
        'typeLabel
        '
        Me.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(3, 7)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(55, 13)
        Me.typeLabel.TabIndex = 1
        Me.typeLabel.Text = "Card type:"
        '
        'cardLabel
        '
        Me.cardLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cardLabel.AutoSize = True
        Me.cardLabel.Location = New System.Drawing.Point(3, 34)
        Me.cardLabel.Name = "cardLabel"
        Me.cardLabel.Size = New System.Drawing.Size(32, 13)
        Me.cardLabel.TabIndex = 2
        Me.cardLabel.Text = "Card:"
        '
        'cardComboBox
        '
        Me.cardComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cardComboBox.FormattingEnabled = True
        Me.cardComboBox.Location = New System.Drawing.Point(103, 30)
        Me.cardComboBox.Name = "cardComboBox"
        Me.cardComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cardComboBox.TabIndex = 3
        '
        'cardPictureBox
        '
        Me.cardPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardPictureBox.Location = New System.Drawing.Point(230, 3)
        Me.cardPictureBox.Name = "cardPictureBox"
        Me.mainTableLayoutPanel.SetRowSpan(Me.cardPictureBox, 4)
        Me.cardPictureBox.Size = New System.Drawing.Size(120, 182)
        Me.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cardPictureBox.TabIndex = 4
        Me.cardPictureBox.TabStop = False
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 7
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.cardTypeComboBox, 1, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.cardPictureBox, 2, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.cardComboBox, 1, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.typeLabel, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.cardLabel, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.backgroundColorLabel, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.backgroundColorTextBox, 1, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.PictureBox1, 3, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.PictureBox2, 4, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.PictureBox3, 5, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.PictureBox4, 6, 0)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 4
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(860, 188)
        Me.mainTableLayoutPanel.TabIndex = 5
        '
        'backgroundColorLabel
        '
        Me.backgroundColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.backgroundColorLabel.AutoSize = True
        Me.backgroundColorLabel.Location = New System.Drawing.Point(3, 60)
        Me.backgroundColorLabel.Name = "backgroundColorLabel"
        Me.backgroundColorLabel.Size = New System.Drawing.Size(94, 13)
        Me.backgroundColorLabel.TabIndex = 5
        Me.backgroundColorLabel.Text = "Background color:"
        '
        'backgroundColorTextBox
        '
        Me.backgroundColorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backgroundColorTextBox.Location = New System.Drawing.Point(103, 57)
        Me.backgroundColorTextBox.Name = "backgroundColorTextBox"
        Me.backgroundColorTextBox.ReadOnly = True
        Me.backgroundColorTextBox.Size = New System.Drawing.Size(121, 20)
        Me.backgroundColorTextBox.TabIndex = 6
        Me.backgroundColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(356, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.mainTableLayoutPanel.SetRowSpan(Me.PictureBox1, 4)
        Me.PictureBox1.Size = New System.Drawing.Size(120, 182)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(482, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.mainTableLayoutPanel.SetRowSpan(Me.PictureBox2, 4)
        Me.PictureBox2.Size = New System.Drawing.Size(120, 182)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Location = New System.Drawing.Point(608, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.mainTableLayoutPanel.SetRowSpan(Me.PictureBox3, 4)
        Me.PictureBox3.Size = New System.Drawing.Size(120, 182)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Location = New System.Drawing.Point(734, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.mainTableLayoutPanel.SetRowSpan(Me.PictureBox4, 4)
        Me.PictureBox4.Size = New System.Drawing.Size(123, 182)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 212)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WindowsCards Example"
        CType(Me.cardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cardTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents typeLabel As System.Windows.Forms.Label
    Friend WithEvents cardLabel As System.Windows.Forms.Label
    Friend WithEvents cardComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents cardPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents mainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents backgroundColorLabel As System.Windows.Forms.Label
    Friend WithEvents backgroundColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
