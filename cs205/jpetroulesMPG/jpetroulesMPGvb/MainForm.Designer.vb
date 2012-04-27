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
        Me.distanceTraveledLabel = New System.Windows.Forms.Label()
        Me.fuelUsedLabel = New System.Windows.Forms.Label()
        Me.fuelEfficiencyLabel = New System.Windows.Forms.Label()
        Me.distanceTraveledTextBox = New System.Windows.Forms.TextBox()
        Me.fuelUsedTextBox = New System.Windows.Forms.TextBox()
        Me.fuelEfficiencyTextBox = New System.Windows.Forms.TextBox()
        Me.distanceTraveledErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.fuelUsedErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.outerTableLayoutPanel.SuspendLayout()
        Me.innerTableLayoutPanel.SuspendLayout()
        CType(Me.distanceTraveledErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fuelUsedErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outerTableLayoutPanel
        '
        Me.outerTableLayoutPanel.AutoSize = True
        Me.outerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.outerTableLayoutPanel.ColumnCount = 2
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.outerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTableLayoutPanel.Controls.Add(Me.innerTableLayoutPanel, 0, 3)
        Me.outerTableLayoutPanel.Controls.Add(Me.distanceTraveledLabel, 0, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.fuelUsedLabel, 0, 1)
        Me.outerTableLayoutPanel.Controls.Add(Me.fuelEfficiencyLabel, 0, 2)
        Me.outerTableLayoutPanel.Controls.Add(Me.distanceTraveledTextBox, 1, 0)
        Me.outerTableLayoutPanel.Controls.Add(Me.fuelUsedTextBox, 1, 1)
        Me.outerTableLayoutPanel.Controls.Add(Me.fuelEfficiencyTextBox, 1, 2)
        Me.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outerTableLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.outerTableLayoutPanel.Name = "outerTableLayoutPanel"
        Me.outerTableLayoutPanel.RowCount = 4
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.outerTableLayoutPanel.Size = New System.Drawing.Size(345, 123)
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
        Me.innerTableLayoutPanel.Location = New System.Drawing.Point(3, 74)
        Me.innerTableLayoutPanel.Name = "innerTableLayoutPanel"
        Me.innerTableLayoutPanel.RowCount = 1
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.innerTableLayoutPanel.Size = New System.Drawing.Size(339, 46)
        Me.innerTableLayoutPanel.TabIndex = 6
        '
        'calculateButton
        '
        Me.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.calculateButton.Location = New System.Drawing.Point(91, 11)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.resetButton.Location = New System.Drawing.Point(172, 11)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 23)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'distanceTraveledLabel
        '
        Me.distanceTraveledLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.distanceTraveledLabel.AutoSize = True
        Me.distanceTraveledLabel.Location = New System.Drawing.Point(3, 6)
        Me.distanceTraveledLabel.Name = "distanceTraveledLabel"
        Me.distanceTraveledLabel.Size = New System.Drawing.Size(154, 13)
        Me.distanceTraveledLabel.TabIndex = 0
        Me.distanceTraveledLabel.Text = "Distance traveled (miles or km):"
        '
        'fuelUsedLabel
        '
        Me.fuelUsedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fuelUsedLabel.AutoSize = True
        Me.fuelUsedLabel.Location = New System.Drawing.Point(3, 32)
        Me.fuelUsedLabel.Name = "fuelUsedLabel"
        Me.fuelUsedLabel.Size = New System.Drawing.Size(134, 13)
        Me.fuelUsedLabel.TabIndex = 2
        Me.fuelUsedLabel.Text = "Fuel used (gallons or liters):"
        '
        'fuelEfficiencyLabel
        '
        Me.fuelEfficiencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fuelEfficiencyLabel.AutoSize = True
        Me.fuelEfficiencyLabel.Location = New System.Drawing.Point(3, 55)
        Me.fuelEfficiencyLabel.Name = "fuelEfficiencyLabel"
        Me.fuelEfficiencyLabel.Size = New System.Drawing.Size(143, 13)
        Me.fuelEfficiencyLabel.TabIndex = 4
        Me.fuelEfficiencyLabel.Text = "Fuel efficiency (mpg or km/l):"
        '
        'distanceTraveledTextBox
        '
        Me.distanceTraveledTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.distanceTraveledTextBox.Location = New System.Drawing.Point(163, 3)
        Me.distanceTraveledTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.distanceTraveledTextBox.Name = "distanceTraveledTextBox"
        Me.distanceTraveledTextBox.Size = New System.Drawing.Size(163, 20)
        Me.distanceTraveledTextBox.TabIndex = 1
        Me.distanceTraveledTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fuelUsedTextBox
        '
        Me.fuelUsedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fuelUsedTextBox.Location = New System.Drawing.Point(163, 29)
        Me.fuelUsedTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.fuelUsedTextBox.Name = "fuelUsedTextBox"
        Me.fuelUsedTextBox.Size = New System.Drawing.Size(163, 20)
        Me.fuelUsedTextBox.TabIndex = 3
        Me.fuelUsedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fuelEfficiencyTextBox
        '
        Me.fuelEfficiencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fuelEfficiencyTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fuelEfficiencyTextBox.Location = New System.Drawing.Point(163, 55)
        Me.fuelEfficiencyTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.fuelEfficiencyTextBox.Name = "fuelEfficiencyTextBox"
        Me.fuelEfficiencyTextBox.ReadOnly = True
        Me.fuelEfficiencyTextBox.Size = New System.Drawing.Size(163, 13)
        Me.fuelEfficiencyTextBox.TabIndex = 5
        Me.fuelEfficiencyTextBox.TabStop = False
        Me.fuelEfficiencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'distanceTraveledErrorProvider
        '
        Me.distanceTraveledErrorProvider.ContainerControl = Me
        '
        'fuelUsedErrorProvider
        '
        Me.fuelUsedErrorProvider.ContainerControl = Me
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(369, 147)
        Me.Controls.Add(Me.outerTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fuel Efficiency Calculator"
        Me.outerTableLayoutPanel.ResumeLayout(False)
        Me.outerTableLayoutPanel.PerformLayout()
        Me.innerTableLayoutPanel.ResumeLayout(False)
        CType(Me.distanceTraveledErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fuelUsedErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents distanceTraveledLabel As System.Windows.Forms.Label
    Friend WithEvents fuelUsedLabel As System.Windows.Forms.Label
    Friend WithEvents fuelEfficiencyLabel As System.Windows.Forms.Label
    Friend WithEvents distanceTraveledTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fuelUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fuelEfficiencyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents innerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents distanceTraveledErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents fuelUsedErrorProvider As System.Windows.Forms.ErrorProvider

End Class
