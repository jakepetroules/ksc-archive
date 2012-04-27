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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.rentalUnitsGroupBox = New System.Windows.Forms.GroupBox()
        Me.rentalUnitsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.penthouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.studioRadioButton = New System.Windows.Forms.RadioButton()
        Me.suite3RadioButton = New System.Windows.Forms.RadioButton()
        Me.suite2RadioButton = New System.Windows.Forms.RadioButton()
        Me.rentalTermsGroupBox = New System.Windows.Forms.GroupBox()
        Me.rentalTermsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.rentalTermLabel = New System.Windows.Forms.Label()
        Me.checkInLabel = New System.Windows.Forms.Label()
        Me.checkOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.checkOutLabel = New System.Windows.Forms.Label()
        Me.checkInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.optionalServicesGroupBox = New System.Windows.Forms.GroupBox()
        Me.optionalServicesTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.limoServiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.maidServiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.linenServiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.customerInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.customerInformationTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.middleNameLabel = New System.Windows.Forms.Label()
        Me.middleNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.streetAddressLabel = New System.Windows.Forms.Label()
        Me.streetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.stateComboBox = New System.Windows.Forms.ComboBox()
        Me.zipCodeLabel = New System.Windows.Forms.Label()
        Me.zipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.phoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.emailAddressLabel = New System.Windows.Forms.Label()
        Me.emailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.outputRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.generateReceiptButton = New System.Windows.Forms.Button()
        Me.firstNameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.middleNameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lastNameErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.streetAddressErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cityErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.stateErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.emailAddressErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rentalUnitsErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.zipCodeErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.phoneErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rentalUnitsGroupBox.SuspendLayout()
        Me.rentalUnitsTableLayoutPanel.SuspendLayout()
        Me.rentalTermsGroupBox.SuspendLayout()
        Me.rentalTermsTableLayoutPanel.SuspendLayout()
        Me.optionalServicesGroupBox.SuspendLayout()
        Me.optionalServicesTableLayoutPanel.SuspendLayout()
        Me.customerInformationGroupBox.SuspendLayout()
        Me.customerInformationTableLayoutPanel.SuspendLayout()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.innerTableLayoutPanel.SuspendLayout()
        CType(Me.firstNameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.middleNameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastNameErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.streetAddressErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cityErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stateErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailAddressErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rentalUnitsErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zipCodeErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rentalUnitsGroupBox
        '
        Me.rentalUnitsGroupBox.AutoSize = True
        Me.rentalUnitsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rentalUnitsGroupBox.Controls.Add(Me.rentalUnitsTableLayoutPanel)
        Me.rentalUnitsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rentalUnitsGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.rentalUnitsGroupBox.Margin = New System.Windows.Forms.Padding(12, 12, 28, 12)
        Me.rentalUnitsGroupBox.Name = "rentalUnitsGroupBox"
        Me.rentalUnitsGroupBox.Size = New System.Drawing.Size(301, 111)
        Me.rentalUnitsGroupBox.TabIndex = 0
        Me.rentalUnitsGroupBox.TabStop = False
        Me.rentalUnitsGroupBox.Text = "Rental units"
        '
        'rentalUnitsTableLayoutPanel
        '
        Me.rentalUnitsTableLayoutPanel.AutoSize = True
        Me.rentalUnitsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rentalUnitsTableLayoutPanel.ColumnCount = 1
        Me.rentalUnitsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rentalUnitsTableLayoutPanel.Controls.Add(Me.penthouseRadioButton, 0, 3)
        Me.rentalUnitsTableLayoutPanel.Controls.Add(Me.studioRadioButton, 0, 0)
        Me.rentalUnitsTableLayoutPanel.Controls.Add(Me.suite3RadioButton, 0, 2)
        Me.rentalUnitsTableLayoutPanel.Controls.Add(Me.suite2RadioButton, 0, 1)
        Me.rentalUnitsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rentalUnitsTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.rentalUnitsTableLayoutPanel.Name = "rentalUnitsTableLayoutPanel"
        Me.rentalUnitsTableLayoutPanel.RowCount = 5
        Me.rentalUnitsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalUnitsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalUnitsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalUnitsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalUnitsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalUnitsTableLayoutPanel.Size = New System.Drawing.Size(295, 92)
        Me.rentalUnitsTableLayoutPanel.TabIndex = 0
        '
        'penthouseRadioButton
        '
        Me.penthouseRadioButton.AutoSize = True
        Me.penthouseRadioButton.Location = New System.Drawing.Point(3, 72)
        Me.penthouseRadioButton.Name = "penthouseRadioButton"
        Me.penthouseRadioButton.Size = New System.Drawing.Size(168, 17)
        Me.penthouseRadioButton.TabIndex = 3
        Me.penthouseRadioButton.TabStop = True
        Me.penthouseRadioButton.Text = "Penthouse: $15,000 per week"
        Me.penthouseRadioButton.UseVisualStyleBackColor = True
        '
        'studioRadioButton
        '
        Me.studioRadioButton.AutoSize = True
        Me.studioRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.studioRadioButton.Name = "studioRadioButton"
        Me.studioRadioButton.Size = New System.Drawing.Size(138, 17)
        Me.studioRadioButton.TabIndex = 0
        Me.studioRadioButton.TabStop = True
        Me.studioRadioButton.Text = "Studio: $1000 per week"
        Me.studioRadioButton.UseVisualStyleBackColor = True
        '
        'suite3RadioButton
        '
        Me.suite3RadioButton.AutoSize = True
        Me.suite3RadioButton.Location = New System.Drawing.Point(3, 49)
        Me.suite3RadioButton.Name = "suite3RadioButton"
        Me.suite3RadioButton.Size = New System.Drawing.Size(183, 17)
        Me.suite3RadioButton.TabIndex = 2
        Me.suite3RadioButton.TabStop = True
        Me.suite3RadioButton.Text = "3 bedroom suite: $3000 per week"
        Me.suite3RadioButton.UseVisualStyleBackColor = True
        '
        'suite2RadioButton
        '
        Me.suite2RadioButton.AutoSize = True
        Me.suite2RadioButton.Location = New System.Drawing.Point(3, 26)
        Me.suite2RadioButton.Name = "suite2RadioButton"
        Me.suite2RadioButton.Size = New System.Drawing.Size(183, 17)
        Me.suite2RadioButton.TabIndex = 1
        Me.suite2RadioButton.TabStop = True
        Me.suite2RadioButton.Text = "2 bedroom suite: $2000 per week"
        Me.suite2RadioButton.UseVisualStyleBackColor = True
        '
        'rentalTermsGroupBox
        '
        Me.rentalTermsGroupBox.AutoSize = True
        Me.rentalTermsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rentalTermsGroupBox.Controls.Add(Me.rentalTermsTableLayoutPanel)
        Me.rentalTermsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rentalTermsGroupBox.Location = New System.Drawing.Point(12, 147)
        Me.rentalTermsGroupBox.Margin = New System.Windows.Forms.Padding(12)
        Me.rentalTermsGroupBox.Name = "rentalTermsGroupBox"
        Me.rentalTermsGroupBox.Size = New System.Drawing.Size(317, 84)
        Me.rentalTermsGroupBox.TabIndex = 1
        Me.rentalTermsGroupBox.TabStop = False
        Me.rentalTermsGroupBox.Text = "Rental terms"
        '
        'rentalTermsTableLayoutPanel
        '
        Me.rentalTermsTableLayoutPanel.AutoSize = True
        Me.rentalTermsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rentalTermsTableLayoutPanel.ColumnCount = 2
        Me.rentalTermsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.rentalTermsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rentalTermsTableLayoutPanel.Controls.Add(Me.rentalTermLabel, 0, 2)
        Me.rentalTermsTableLayoutPanel.Controls.Add(Me.checkInLabel, 0, 0)
        Me.rentalTermsTableLayoutPanel.Controls.Add(Me.checkOutDateTimePicker, 1, 1)
        Me.rentalTermsTableLayoutPanel.Controls.Add(Me.checkOutLabel, 0, 1)
        Me.rentalTermsTableLayoutPanel.Controls.Add(Me.checkInDateTimePicker, 1, 0)
        Me.rentalTermsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rentalTermsTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.rentalTermsTableLayoutPanel.Name = "rentalTermsTableLayoutPanel"
        Me.rentalTermsTableLayoutPanel.RowCount = 3
        Me.rentalTermsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalTermsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalTermsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.rentalTermsTableLayoutPanel.Size = New System.Drawing.Size(311, 65)
        Me.rentalTermsTableLayoutPanel.TabIndex = 0
        '
        'rentalTermLabel
        '
        Me.rentalTermLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rentalTermLabel.AutoSize = True
        Me.rentalTermsTableLayoutPanel.SetColumnSpan(Me.rentalTermLabel, 2)
        Me.rentalTermLabel.Location = New System.Drawing.Point(49, 52)
        Me.rentalTermLabel.Name = "rentalTermLabel"
        Me.rentalTermLabel.Size = New System.Drawing.Size(212, 13)
        Me.rentalTermLabel.TabIndex = 4
        Me.rentalTermLabel.Text = "You have selected a rental period of 0 days"
        '
        'checkInLabel
        '
        Me.checkInLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkInLabel.Location = New System.Drawing.Point(3, 0)
        Me.checkInLabel.Name = "checkInLabel"
        Me.checkInLabel.Size = New System.Drawing.Size(59, 26)
        Me.checkInLabel.TabIndex = 0
        Me.checkInLabel.Text = "Check in:"
        Me.checkInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkOutDateTimePicker
        '
        Me.checkOutDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkOutDateTimePicker.Location = New System.Drawing.Point(68, 29)
        Me.checkOutDateTimePicker.Name = "checkOutDateTimePicker"
        Me.checkOutDateTimePicker.Size = New System.Drawing.Size(240, 20)
        Me.checkOutDateTimePicker.TabIndex = 3
        '
        'checkOutLabel
        '
        Me.checkOutLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkOutLabel.Location = New System.Drawing.Point(3, 26)
        Me.checkOutLabel.Name = "checkOutLabel"
        Me.checkOutLabel.Size = New System.Drawing.Size(59, 26)
        Me.checkOutLabel.TabIndex = 2
        Me.checkOutLabel.Text = "Check out:"
        Me.checkOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkInDateTimePicker
        '
        Me.checkInDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkInDateTimePicker.Location = New System.Drawing.Point(68, 3)
        Me.checkInDateTimePicker.Name = "checkInDateTimePicker"
        Me.checkInDateTimePicker.Size = New System.Drawing.Size(240, 20)
        Me.checkInDateTimePicker.TabIndex = 1
        '
        'optionalServicesGroupBox
        '
        Me.optionalServicesGroupBox.AutoSize = True
        Me.optionalServicesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.optionalServicesGroupBox.Controls.Add(Me.optionalServicesTableLayoutPanel)
        Me.optionalServicesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionalServicesGroupBox.Location = New System.Drawing.Point(12, 255)
        Me.optionalServicesGroupBox.Margin = New System.Windows.Forms.Padding(12)
        Me.optionalServicesGroupBox.Name = "optionalServicesGroupBox"
        Me.optionalServicesGroupBox.Size = New System.Drawing.Size(317, 105)
        Me.optionalServicesGroupBox.TabIndex = 2
        Me.optionalServicesGroupBox.TabStop = False
        Me.optionalServicesGroupBox.Text = "Optional services"
        '
        'optionalServicesTableLayoutPanel
        '
        Me.optionalServicesTableLayoutPanel.AutoSize = True
        Me.optionalServicesTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.optionalServicesTableLayoutPanel.ColumnCount = 1
        Me.optionalServicesTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.optionalServicesTableLayoutPanel.Controls.Add(Me.limoServiceCheckBox, 0, 2)
        Me.optionalServicesTableLayoutPanel.Controls.Add(Me.maidServiceCheckBox, 0, 0)
        Me.optionalServicesTableLayoutPanel.Controls.Add(Me.linenServiceCheckBox, 0, 1)
        Me.optionalServicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionalServicesTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.optionalServicesTableLayoutPanel.Name = "optionalServicesTableLayoutPanel"
        Me.optionalServicesTableLayoutPanel.RowCount = 4
        Me.optionalServicesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionalServicesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionalServicesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionalServicesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionalServicesTableLayoutPanel.Size = New System.Drawing.Size(311, 86)
        Me.optionalServicesTableLayoutPanel.TabIndex = 0
        '
        'limoServiceCheckBox
        '
        Me.limoServiceCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.limoServiceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.limoServiceCheckBox.Location = New System.Drawing.Point(3, 49)
        Me.limoServiceCheckBox.Name = "limoServiceCheckBox"
        Me.limoServiceCheckBox.Size = New System.Drawing.Size(305, 34)
        Me.limoServiceCheckBox.TabIndex = 2
        Me.limoServiceCheckBox.Text = "Limo service: $75 per day for one ride to and from the Mt. Snow base lodge"
        Me.limoServiceCheckBox.UseVisualStyleBackColor = True
        '
        'maidServiceCheckBox
        '
        Me.maidServiceCheckBox.AutoSize = True
        Me.maidServiceCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.maidServiceCheckBox.Name = "maidServiceCheckBox"
        Me.maidServiceCheckBox.Size = New System.Drawing.Size(179, 17)
        Me.maidServiceCheckBox.TabIndex = 0
        Me.maidServiceCheckBox.Text = "Daily maid service: $100 per day"
        Me.maidServiceCheckBox.UseVisualStyleBackColor = True
        '
        'linenServiceCheckBox
        '
        Me.linenServiceCheckBox.AutoSize = True
        Me.linenServiceCheckBox.Location = New System.Drawing.Point(3, 26)
        Me.linenServiceCheckBox.Name = "linenServiceCheckBox"
        Me.linenServiceCheckBox.Size = New System.Drawing.Size(213, 17)
        Me.linenServiceCheckBox.TabIndex = 1
        Me.linenServiceCheckBox.Text = "Linen service: $20 per day per bedroom"
        Me.linenServiceCheckBox.UseVisualStyleBackColor = True
        '
        'customerInformationGroupBox
        '
        Me.customerInformationGroupBox.AutoSize = True
        Me.customerInformationGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.customerInformationGroupBox.Controls.Add(Me.customerInformationTableLayoutPanel)
        Me.customerInformationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customerInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.customerInformationGroupBox.Margin = New System.Windows.Forms.Padding(12)
        Me.customerInformationGroupBox.Name = "customerInformationGroupBox"
        Me.mainTableLayoutPanel.SetRowSpan(Me.customerInformationGroupBox, 2)
        Me.customerInformationGroupBox.Size = New System.Drawing.Size(323, 266)
        Me.customerInformationGroupBox.TabIndex = 0
        Me.customerInformationGroupBox.TabStop = False
        Me.customerInformationGroupBox.Text = "Customer information"
        '
        'customerInformationTableLayoutPanel
        '
        Me.customerInformationTableLayoutPanel.AutoSize = True
        Me.customerInformationTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.customerInformationTableLayoutPanel.ColumnCount = 2
        Me.customerInformationTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.customerInformationTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.firstNameTextBox, 1, 0)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.lastNameLabel, 0, 2)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.lastNameTextBox, 1, 2)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.middleNameLabel, 0, 1)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.middleNameTextBox, 1, 1)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.firstNameLabel, 0, 0)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.streetAddressLabel, 0, 3)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.streetAddressTextBox, 1, 3)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.cityLabel, 0, 4)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.cityTextBox, 1, 4)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.stateLabel, 0, 5)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.stateComboBox, 1, 5)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.zipCodeLabel, 0, 6)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.zipCodeMaskedTextBox, 1, 6)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.phoneLabel, 0, 7)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.phoneMaskedTextBox, 1, 7)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.emailAddressLabel, 0, 8)
        Me.customerInformationTableLayoutPanel.Controls.Add(Me.emailAddressTextBox, 1, 8)
        Me.customerInformationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customerInformationTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.customerInformationTableLayoutPanel.Name = "customerInformationTableLayoutPanel"
        Me.customerInformationTableLayoutPanel.RowCount = 10
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.customerInformationTableLayoutPanel.Size = New System.Drawing.Size(317, 247)
        Me.customerInformationTableLayoutPanel.TabIndex = 0
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firstNameTextBox.Location = New System.Drawing.Point(109, 3)
        Me.firstNameTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.firstNameTextBox.TabIndex = 1
        '
        'lastNameLabel
        '
        Me.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lastNameLabel.Location = New System.Drawing.Point(3, 52)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(100, 26)
        Me.lastNameLabel.TabIndex = 4
        Me.lastNameLabel.Text = "Last name:"
        Me.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastNameTextBox.Location = New System.Drawing.Point(109, 55)
        Me.lastNameTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.lastNameTextBox.TabIndex = 5
        '
        'middleNameLabel
        '
        Me.middleNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.middleNameLabel.Location = New System.Drawing.Point(3, 26)
        Me.middleNameLabel.Name = "middleNameLabel"
        Me.middleNameLabel.Size = New System.Drawing.Size(100, 26)
        Me.middleNameLabel.TabIndex = 2
        Me.middleNameLabel.Text = "Middle name:"
        Me.middleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'middleNameTextBox
        '
        Me.middleNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.middleNameTextBox.Location = New System.Drawing.Point(109, 29)
        Me.middleNameTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.middleNameTextBox.Name = "middleNameTextBox"
        Me.middleNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.middleNameTextBox.TabIndex = 3
        '
        'firstNameLabel
        '
        Me.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.firstNameLabel.Location = New System.Drawing.Point(3, 0)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(100, 26)
        Me.firstNameLabel.TabIndex = 0
        Me.firstNameLabel.Text = "First name:"
        Me.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'streetAddressLabel
        '
        Me.streetAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.streetAddressLabel.Location = New System.Drawing.Point(3, 78)
        Me.streetAddressLabel.Name = "streetAddressLabel"
        Me.streetAddressLabel.Size = New System.Drawing.Size(100, 26)
        Me.streetAddressLabel.TabIndex = 6
        Me.streetAddressLabel.Text = "Street address:"
        Me.streetAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'streetAddressTextBox
        '
        Me.streetAddressTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.streetAddressTextBox.Location = New System.Drawing.Point(109, 81)
        Me.streetAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.streetAddressTextBox.Name = "streetAddressTextBox"
        Me.streetAddressTextBox.Size = New System.Drawing.Size(189, 20)
        Me.streetAddressTextBox.TabIndex = 7
        '
        'cityLabel
        '
        Me.cityLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cityLabel.Location = New System.Drawing.Point(3, 104)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(100, 26)
        Me.cityLabel.TabIndex = 8
        Me.cityLabel.Text = "City:"
        Me.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cityTextBox
        '
        Me.cityTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cityTextBox.Location = New System.Drawing.Point(109, 107)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(189, 20)
        Me.cityTextBox.TabIndex = 9
        '
        'stateLabel
        '
        Me.stateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stateLabel.Location = New System.Drawing.Point(3, 130)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(100, 27)
        Me.stateLabel.TabIndex = 10
        Me.stateLabel.Text = "State:"
        Me.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stateComboBox
        '
        Me.stateComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stateComboBox.FormattingEnabled = True
        Me.stateComboBox.Items.AddRange(New Object() {"Select...", "Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Marianas Islands", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Virgin Islands", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.stateComboBox.Location = New System.Drawing.Point(109, 133)
        Me.stateComboBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.stateComboBox.Name = "stateComboBox"
        Me.stateComboBox.Size = New System.Drawing.Size(189, 21)
        Me.stateComboBox.TabIndex = 11
        '
        'zipCodeLabel
        '
        Me.zipCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zipCodeLabel.Location = New System.Drawing.Point(3, 157)
        Me.zipCodeLabel.Name = "zipCodeLabel"
        Me.zipCodeLabel.Size = New System.Drawing.Size(100, 26)
        Me.zipCodeLabel.TabIndex = 12
        Me.zipCodeLabel.Text = "Zip Code:"
        Me.zipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'zipCodeMaskedTextBox
        '
        Me.zipCodeMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zipCodeMaskedTextBox.Location = New System.Drawing.Point(109, 160)
        Me.zipCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.zipCodeMaskedTextBox.Mask = "00000-9999"
        Me.zipCodeMaskedTextBox.Name = "zipCodeMaskedTextBox"
        Me.zipCodeMaskedTextBox.Size = New System.Drawing.Size(189, 20)
        Me.zipCodeMaskedTextBox.TabIndex = 13
        '
        'phoneLabel
        '
        Me.phoneLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.phoneLabel.Location = New System.Drawing.Point(3, 183)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(100, 26)
        Me.phoneLabel.TabIndex = 14
        Me.phoneLabel.Text = "Phone:"
        Me.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'phoneMaskedTextBox
        '
        Me.phoneMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneMaskedTextBox.Location = New System.Drawing.Point(109, 186)
        Me.phoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.phoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.phoneMaskedTextBox.Name = "phoneMaskedTextBox"
        Me.phoneMaskedTextBox.Size = New System.Drawing.Size(189, 20)
        Me.phoneMaskedTextBox.TabIndex = 15
        '
        'emailAddressLabel
        '
        Me.emailAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emailAddressLabel.Location = New System.Drawing.Point(3, 209)
        Me.emailAddressLabel.Name = "emailAddressLabel"
        Me.emailAddressLabel.Size = New System.Drawing.Size(100, 26)
        Me.emailAddressLabel.TabIndex = 16
        Me.emailAddressLabel.Text = "Email address:"
        Me.emailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'emailAddressTextBox
        '
        Me.emailAddressTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailAddressTextBox.Location = New System.Drawing.Point(109, 212)
        Me.emailAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 19, 3)
        Me.emailAddressTextBox.Name = "emailAddressTextBox"
        Me.emailAddressTextBox.Size = New System.Drawing.Size(189, 20)
        Me.emailAddressTextBox.TabIndex = 17
        '
        'outputRichTextBox
        '
        Me.outputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputRichTextBox.Location = New System.Drawing.Point(12, 302)
        Me.outputRichTextBox.Margin = New System.Windows.Forms.Padding(12)
        Me.outputRichTextBox.Name = "outputRichTextBox"
        Me.outputRichTextBox.ReadOnly = True
        Me.outputRichTextBox.Size = New System.Drawing.Size(323, 108)
        Me.outputRichTextBox.TabIndex = 2
        Me.outputRichTextBox.Text = ""
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.AutoSize = True
        Me.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.ColumnCount = 2
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.innerTableLayoutPanel, 1, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.customerInformationGroupBox, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.outputRichTextBox, 0, 2)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 3
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(694, 422)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'innerTableLayoutPanel
        '
        Me.innerTableLayoutPanel.AutoSize = True
        Me.innerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.innerTableLayoutPanel.ColumnCount = 1
        Me.innerTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.innerTableLayoutPanel.Controls.Add(Me.rentalUnitsGroupBox, 0, 0)
        Me.innerTableLayoutPanel.Controls.Add(Me.rentalTermsGroupBox, 0, 1)
        Me.innerTableLayoutPanel.Controls.Add(Me.optionalServicesGroupBox, 0, 2)
        Me.innerTableLayoutPanel.Controls.Add(Me.generateReceiptButton, 0, 3)
        Me.innerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTableLayoutPanel.Location = New System.Drawing.Point(350, 3)
        Me.innerTableLayoutPanel.Name = "innerTableLayoutPanel"
        Me.innerTableLayoutPanel.RowCount = 4
        Me.mainTableLayoutPanel.SetRowSpan(Me.innerTableLayoutPanel, 3)
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.innerTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.innerTableLayoutPanel.Size = New System.Drawing.Size(341, 416)
        Me.innerTableLayoutPanel.TabIndex = 1
        '
        'generateReceiptButton
        '
        Me.generateReceiptButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.generateReceiptButton.Location = New System.Drawing.Point(120, 382)
        Me.generateReceiptButton.Name = "generateReceiptButton"
        Me.generateReceiptButton.Size = New System.Drawing.Size(100, 23)
        Me.generateReceiptButton.TabIndex = 3
        Me.generateReceiptButton.Text = "Generate Receipt"
        Me.generateReceiptButton.UseVisualStyleBackColor = True
        '
        'firstNameErrorProvider
        '
        Me.firstNameErrorProvider.ContainerControl = Me
        '
        'middleNameErrorProvider
        '
        Me.middleNameErrorProvider.ContainerControl = Me
        '
        'lastNameErrorProvider
        '
        Me.lastNameErrorProvider.ContainerControl = Me
        '
        'streetAddressErrorProvider
        '
        Me.streetAddressErrorProvider.ContainerControl = Me
        '
        'cityErrorProvider
        '
        Me.cityErrorProvider.ContainerControl = Me
        '
        'stateErrorProvider
        '
        Me.stateErrorProvider.ContainerControl = Me
        '
        'emailAddressErrorProvider
        '
        Me.emailAddressErrorProvider.ContainerControl = Me
        '
        'rentalUnitsErrorProvider
        '
        Me.rentalUnitsErrorProvider.ContainerControl = Me
        '
        'zipCodeErrorProvider
        '
        Me.zipCodeErrorProvider.ContainerControl = Me
        '
        'phoneErrorProvider
        '
        Me.phoneErrorProvider.ContainerControl = Me
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(694, 422)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mt. Snow Condo Rentals"
        Me.rentalUnitsGroupBox.ResumeLayout(False)
        Me.rentalUnitsGroupBox.PerformLayout()
        Me.rentalUnitsTableLayoutPanel.ResumeLayout(False)
        Me.rentalUnitsTableLayoutPanel.PerformLayout()
        Me.rentalTermsGroupBox.ResumeLayout(False)
        Me.rentalTermsGroupBox.PerformLayout()
        Me.rentalTermsTableLayoutPanel.ResumeLayout(False)
        Me.rentalTermsTableLayoutPanel.PerformLayout()
        Me.optionalServicesGroupBox.ResumeLayout(False)
        Me.optionalServicesGroupBox.PerformLayout()
        Me.optionalServicesTableLayoutPanel.ResumeLayout(False)
        Me.optionalServicesTableLayoutPanel.PerformLayout()
        Me.customerInformationGroupBox.ResumeLayout(False)
        Me.customerInformationGroupBox.PerformLayout()
        Me.customerInformationTableLayoutPanel.ResumeLayout(False)
        Me.customerInformationTableLayoutPanel.PerformLayout()
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.innerTableLayoutPanel.ResumeLayout(False)
        Me.innerTableLayoutPanel.PerformLayout()
        CType(Me.firstNameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.middleNameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastNameErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.streetAddressErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cityErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stateErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailAddressErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rentalUnitsErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zipCodeErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rentalUnitsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents penthouseRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents suite3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents suite2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents studioRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents rentalTermsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rentalTermLabel As System.Windows.Forms.Label
    Friend WithEvents checkOutLabel As System.Windows.Forms.Label
    Friend WithEvents checkInLabel As System.Windows.Forms.Label
    Friend WithEvents checkOutDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkInDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents optionalServicesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents limoServiceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents linenServiceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents maidServiceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customerInformationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents customerInformationTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameLabel As System.Windows.Forms.Label
    Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents middleNameLabel As System.Windows.Forms.Label
    Friend WithEvents middleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents firstNameLabel As System.Windows.Forms.Label
    Friend WithEvents streetAddressLabel As System.Windows.Forms.Label
    Friend WithEvents streetAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents stateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents zipCodeLabel As System.Windows.Forms.Label
    Friend WithEvents zipCodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents phoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents emailAddressLabel As System.Windows.Forms.Label
    Friend WithEvents emailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rentalUnitsTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rentalTermsTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents optionalServicesTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents outputRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents innerTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents firstNameErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents middleNameErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lastNameErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents streetAddressErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cityErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents stateErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents generateReceiptButton As System.Windows.Forms.Button
    Friend WithEvents emailAddressErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents rentalUnitsErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents zipCodeErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents phoneErrorProvider As System.Windows.Forms.ErrorProvider

End Class
