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
        Me.components = New System.ComponentModel.Container()
        Me.outerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.interestRateLabel = New System.Windows.Forms.Label()
        Me.numberOfPaymentsLabel = New System.Windows.Forms.Label()
        Me.principleLabel = New System.Windows.Forms.Label()
        Me.monthlyPaymentLabel = New System.Windows.Forms.Label()
        Me.interestRateTextBox = New System.Windows.Forms.TextBox()
        Me.numberOfPaymentsTextBox = New System.Windows.Forms.TextBox()
        Me.principleTextBox = New System.Windows.Forms.TextBox()
        Me.monthlyPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.interestRateErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.numberOfPaymentsErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.principleErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.fileMenuItem = New System.Windows.Forms.MenuItem()
        Me.exitMenuItem = New System.Windows.Forms.MenuItem()
        Me.editMenuItem = New System.Windows.Forms.MenuItem()
        Me.changeFontMenuItem = New System.Windows.Forms.MenuItem()
        Me.changeTextColorMenuItem = New System.Windows.Forms.MenuItem()
        Me.changeBackgroundColorMenuItem = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.resetFontsAndColorsMenuItem = New System.Windows.Forms.MenuItem()
        Me.helpMenuItem = New System.Windows.Forms.MenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.MenuItem()
        Me.outerTableLayoutPanel.SuspendLayout()
        Me.innerTableLayoutPanel.SuspendLayout()
        CType(Me.interestRateErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfPaymentsErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.principleErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outerTableLayoutPanel
        '
        Me.outerTableLayoutPanel.AutoSize = True
        Me.outerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.outerTableLayoutPanel.ColumnCount = 2
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.outerTableLayoutPanel.Controls.Add(Me.innerTableLayoutPanel, 0, 4)
        Me.outerTableLayoutPanel.Controls.Add(Me.interestRateLabel, 0, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.numberOfPaymentsLabel, 0, 1)
        Me.outerTableLayoutPanel.Controls.Add(Me.principleLabel, 0, 2)
        Me.outerTableLayoutPanel.Controls.Add(Me.monthlyPaymentLabel, 0, 3)
        Me.outerTableLayoutPanel.Controls.Add(Me.interestRateTextBox, 1, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.numberOfPaymentsTextBox, 1, 1)
        Me.outerTableLayoutPanel.Controls.Add(Me.principleTextBox, 1, 2)
        Me.outerTableLayoutPanel.Controls.Add(Me.monthlyPaymentTextBox, 1, 3)
        Me.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outerTableLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.outerTableLayoutPanel.Name = "outerTableLayoutPanel"
        Me.outerTableLayoutPanel.RowCount = 5
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.Size = New System.Drawing.Size(320, 148)
        Me.outerTableLayoutPanel.TabIndex = 0
        '
        'innerTableLayoutPanel
        '
        Me.innerTableLayoutPanel.AutoSize = True
        Me.innerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.innerTableLayoutPanel.ColumnCount = 2
        Me.outerTableLayoutPanel.SetColumnSpan(Me.innerTableLayoutPanel, 2)
        Me.innerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.innerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.innerTableLayoutPanel.Controls.Add(Me.calculateButton, 0, 0)
        Me.innerTableLayoutPanel.Controls.Add(Me.resetButton, 1, 0)
        Me.innerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTableLayoutPanel.Location = New System.Drawing.Point(3, 100)
        Me.innerTableLayoutPanel.Name = "innerTableLayoutPanel"
        Me.innerTableLayoutPanel.RowCount = 1
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.innerTableLayoutPanel.Size = New System.Drawing.Size(314, 45)
        Me.innerTableLayoutPanel.TabIndex = 8
        '
        'calculateButton
        '
        Me.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.calculateButton.Location = New System.Drawing.Point(79, 11)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.resetButton.Location = New System.Drawing.Point(160, 11)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'interestRateLabel
        '
        Me.interestRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.interestRateLabel.AutoSize = True
        Me.interestRateLabel.Location = New System.Drawing.Point(3, 6)
        Me.interestRateLabel.Name = "interestRateLabel"
        Me.interestRateLabel.Size = New System.Drawing.Size(66, 13)
        Me.interestRateLabel.TabIndex = 0
        Me.interestRateLabel.Text = "Interest rate:"
        '
        'numberOfPaymentsLabel
        '
        Me.numberOfPaymentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numberOfPaymentsLabel.AutoSize = True
        Me.numberOfPaymentsLabel.Location = New System.Drawing.Point(3, 32)
        Me.numberOfPaymentsLabel.Name = "numberOfPaymentsLabel"
        Me.numberOfPaymentsLabel.Size = New System.Drawing.Size(107, 13)
        Me.numberOfPaymentsLabel.TabIndex = 2
        Me.numberOfPaymentsLabel.Text = "Number of payments:"
        '
        'principleLabel
        '
        Me.principleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.principleLabel.AutoSize = True
        Me.principleLabel.Location = New System.Drawing.Point(3, 58)
        Me.principleLabel.Name = "principleLabel"
        Me.principleLabel.Size = New System.Drawing.Size(50, 13)
        Me.principleLabel.TabIndex = 4
        Me.principleLabel.Text = "Principle:"
        '
        'monthlyPaymentLabel
        '
        Me.monthlyPaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.monthlyPaymentLabel.AutoSize = True
        Me.monthlyPaymentLabel.Location = New System.Drawing.Point(3, 81)
        Me.monthlyPaymentLabel.Name = "monthlyPaymentLabel"
        Me.monthlyPaymentLabel.Size = New System.Drawing.Size(90, 13)
        Me.monthlyPaymentLabel.TabIndex = 6
        Me.monthlyPaymentLabel.Text = "Monthly payment:"
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.interestRateTextBox.Location = New System.Drawing.Point(163, 3)
        Me.interestRateTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Size = New System.Drawing.Size(138, 20)
        Me.interestRateTextBox.TabIndex = 1
        Me.interestRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numberOfPaymentsTextBox
        '
        Me.numberOfPaymentsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numberOfPaymentsTextBox.Location = New System.Drawing.Point(163, 29)
        Me.numberOfPaymentsTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.numberOfPaymentsTextBox.Name = "numberOfPaymentsTextBox"
        Me.numberOfPaymentsTextBox.Size = New System.Drawing.Size(138, 20)
        Me.numberOfPaymentsTextBox.TabIndex = 3
        Me.numberOfPaymentsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'principleTextBox
        '
        Me.principleTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principleTextBox.Location = New System.Drawing.Point(163, 55)
        Me.principleTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.principleTextBox.Name = "principleTextBox"
        Me.principleTextBox.Size = New System.Drawing.Size(138, 20)
        Me.principleTextBox.TabIndex = 5
        Me.principleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'monthlyPaymentTextBox
        '
        Me.monthlyPaymentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.monthlyPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monthlyPaymentTextBox.Location = New System.Drawing.Point(163, 81)
        Me.monthlyPaymentTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox"
        Me.monthlyPaymentTextBox.ReadOnly = True
        Me.monthlyPaymentTextBox.Size = New System.Drawing.Size(138, 13)
        Me.monthlyPaymentTextBox.TabIndex = 7
        Me.monthlyPaymentTextBox.TabStop = False
        Me.monthlyPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'interestRateErrorProvider
        '
        Me.interestRateErrorProvider.ContainerControl = Me
        '
        'numberOfPaymentsErrorProvider
        '
        Me.numberOfPaymentsErrorProvider.ContainerControl = Me
        '
        'principleErrorProvider
        '
        Me.principleErrorProvider.ContainerControl = Me
        '
        'mainMenu
        '
        Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fileMenuItem, Me.editMenuItem, Me.helpMenuItem})
        '
        'fileMenuItem
        '
        Me.fileMenuItem.Index = 0
        Me.fileMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.exitMenuItem})
        Me.fileMenuItem.Text = "&File"
        '
        'exitMenuItem
        '
        Me.exitMenuItem.Index = 0
        Me.exitMenuItem.Text = "E&xit"
        '
        'editMenuItem
        '
        Me.editMenuItem.Index = 1
        Me.editMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.changeFontMenuItem, Me.changeTextColorMenuItem, Me.changeBackgroundColorMenuItem, Me.MenuItem1, Me.resetFontsAndColorsMenuItem})
        Me.editMenuItem.Text = "&Edit"
        '
        'changeFontMenuItem
        '
        Me.changeFontMenuItem.Index = 0
        Me.changeFontMenuItem.Text = "Change font..."
        '
        'changeTextColorMenuItem
        '
        Me.changeTextColorMenuItem.Index = 1
        Me.changeTextColorMenuItem.Text = "Change text color..."
        '
        'changeBackgroundColorMenuItem
        '
        Me.changeBackgroundColorMenuItem.Index = 2
        Me.changeBackgroundColorMenuItem.Text = "Change background color..."
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "-"
        '
        'resetFontsAndColorsMenuItem
        '
        Me.resetFontsAndColorsMenuItem.Index = 4
        Me.resetFontsAndColorsMenuItem.Text = "Reset fonts and colors"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.Index = 2
        Me.helpMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.aboutMenuItem})
        Me.helpMenuItem.Text = "&Help"
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Index = 0
        Me.aboutMenuItem.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(344, 172)
        Me.Controls.Add(Me.outerTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Payment Calculator"
        Me.outerTableLayoutPanel.ResumeLayout(False)
        Me.outerTableLayoutPanel.PerformLayout()
        Me.innerTableLayoutPanel.ResumeLayout(False)
        CType(Me.interestRateErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfPaymentsErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.principleErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents innerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents interestRateLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfPaymentsLabel As System.Windows.Forms.Label
    Friend WithEvents principleLabel As System.Windows.Forms.Label
    Friend WithEvents monthlyPaymentLabel As System.Windows.Forms.Label
    Friend WithEvents interestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents numberOfPaymentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents principleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents monthlyPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents interestRateErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents numberOfPaymentsErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents principleErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents mainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents fileMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents exitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents editMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents changeTextColorMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents changeBackgroundColorMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents helpMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents aboutMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents changeFontMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents resetFontsAndColorsMenuItem As System.Windows.Forms.MenuItem

End Class
