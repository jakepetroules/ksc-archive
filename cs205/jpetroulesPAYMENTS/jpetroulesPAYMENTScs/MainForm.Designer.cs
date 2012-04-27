namespace jpetroulesPAYMENTScs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.outerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.innerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.numberOfPaymentsLabel = new System.Windows.Forms.Label();
            this.principleLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPaymentsTextBox = new System.Windows.Forms.TextBox();
            this.principleTextBox = new System.Windows.Forms.TextBox();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.editMenuItem = new System.Windows.Forms.MenuItem();
            this.changeFontMenuItem = new System.Windows.Forms.MenuItem();
            this.changeTextColorMenuItem = new System.Windows.Forms.MenuItem();
            this.changeBackgroundColorMenuItem = new System.Windows.Forms.MenuItem();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.resetFontsAndColorsMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.principleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numberOfPaymentsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.interestRateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.outerTableLayoutPanel.SuspendLayout();
            this.innerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPaymentsErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // outerTableLayoutPanel
            // 
            this.outerTableLayoutPanel.AutoSize = true;
            this.outerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outerTableLayoutPanel.ColumnCount = 2;
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outerTableLayoutPanel.Controls.Add(this.innerTableLayoutPanel, 0, 4);
            this.outerTableLayoutPanel.Controls.Add(this.interestRateLabel, 0, 0);
            this.outerTableLayoutPanel.Controls.Add(this.numberOfPaymentsLabel, 0, 1);
            this.outerTableLayoutPanel.Controls.Add(this.principleLabel, 0, 2);
            this.outerTableLayoutPanel.Controls.Add(this.monthlyPaymentLabel, 0, 3);
            this.outerTableLayoutPanel.Controls.Add(this.interestRateTextBox, 1, 0);
            this.outerTableLayoutPanel.Controls.Add(this.numberOfPaymentsTextBox, 1, 1);
            this.outerTableLayoutPanel.Controls.Add(this.principleTextBox, 1, 2);
            this.outerTableLayoutPanel.Controls.Add(this.monthlyPaymentTextBox, 1, 3);
            this.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.outerTableLayoutPanel.Name = "outerTableLayoutPanel";
            this.outerTableLayoutPanel.RowCount = 5;
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.Size = new System.Drawing.Size(320, 148);
            this.outerTableLayoutPanel.TabIndex = 1;
            // 
            // innerTableLayoutPanel
            // 
            this.innerTableLayoutPanel.AutoSize = true;
            this.innerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.innerTableLayoutPanel.ColumnCount = 2;
            this.outerTableLayoutPanel.SetColumnSpan(this.innerTableLayoutPanel, 2);
            this.innerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTableLayoutPanel.Controls.Add(this.calculateButton, 0, 0);
            this.innerTableLayoutPanel.Controls.Add(this.resetButton, 1, 0);
            this.innerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTableLayoutPanel.Location = new System.Drawing.Point(3, 100);
            this.innerTableLayoutPanel.Name = "innerTableLayoutPanel";
            this.innerTableLayoutPanel.RowCount = 1;
            this.innerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTableLayoutPanel.Size = new System.Drawing.Size(314, 45);
            this.innerTableLayoutPanel.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculateButton.Location = new System.Drawing.Point(79, 11);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.Location = new System.Drawing.Point(160, 11);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(3, 6);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(66, 13);
            this.interestRateLabel.TabIndex = 0;
            this.interestRateLabel.Text = "Interest rate:";
            // 
            // numberOfPaymentsLabel
            // 
            this.numberOfPaymentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numberOfPaymentsLabel.AutoSize = true;
            this.numberOfPaymentsLabel.Location = new System.Drawing.Point(3, 32);
            this.numberOfPaymentsLabel.Name = "numberOfPaymentsLabel";
            this.numberOfPaymentsLabel.Size = new System.Drawing.Size(107, 13);
            this.numberOfPaymentsLabel.TabIndex = 2;
            this.numberOfPaymentsLabel.Text = "Number of payments:";
            // 
            // principleLabel
            // 
            this.principleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.principleLabel.AutoSize = true;
            this.principleLabel.Location = new System.Drawing.Point(3, 58);
            this.principleLabel.Name = "principleLabel";
            this.principleLabel.Size = new System.Drawing.Size(50, 13);
            this.principleLabel.TabIndex = 4;
            this.principleLabel.Text = "Principle:";
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.monthlyPaymentLabel.AutoSize = true;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(3, 81);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(90, 13);
            this.monthlyPaymentLabel.TabIndex = 6;
            this.monthlyPaymentLabel.Text = "Monthly payment:";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateTextBox.Location = new System.Drawing.Point(163, 3);
            this.interestRateTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(138, 20);
            this.interestRateTextBox.TabIndex = 1;
            this.interestRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.interestRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.interestRateTextBox_Validating);
            // 
            // numberOfPaymentsTextBox
            // 
            this.numberOfPaymentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfPaymentsTextBox.Location = new System.Drawing.Point(163, 29);
            this.numberOfPaymentsTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.numberOfPaymentsTextBox.Name = "numberOfPaymentsTextBox";
            this.numberOfPaymentsTextBox.Size = new System.Drawing.Size(138, 20);
            this.numberOfPaymentsTextBox.TabIndex = 3;
            this.numberOfPaymentsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberOfPaymentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numberOfPaymentsTextBox_Validating);
            // 
            // principleTextBox
            // 
            this.principleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.principleTextBox.Location = new System.Drawing.Point(163, 55);
            this.principleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.principleTextBox.Name = "principleTextBox";
            this.principleTextBox.Size = new System.Drawing.Size(138, 20);
            this.principleTextBox.TabIndex = 5;
            this.principleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.principleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.principleTextBox_Validating);
            // 
            // monthlyPaymentTextBox
            // 
            this.monthlyPaymentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthlyPaymentTextBox.Location = new System.Drawing.Point(163, 81);
            this.monthlyPaymentTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.ReadOnly = true;
            this.monthlyPaymentTextBox.Size = new System.Drawing.Size(138, 13);
            this.monthlyPaymentTextBox.TabIndex = 7;
            this.monthlyPaymentTextBox.TabStop = false;
            this.monthlyPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 0;
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Text = "&File";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.helpMenuItem});
            // 
            // editMenuItem
            // 
            this.editMenuItem.Index = 1;
            this.editMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.changeFontMenuItem,
            this.changeTextColorMenuItem,
            this.changeBackgroundColorMenuItem,
            this.MenuItem1,
            this.resetFontsAndColorsMenuItem});
            this.editMenuItem.Text = "&Edit";
            // 
            // changeFontMenuItem
            // 
            this.changeFontMenuItem.Index = 0;
            this.changeFontMenuItem.Text = "Change font...";
            this.changeFontMenuItem.Click += new System.EventHandler(this.changeFontMenuItem_Click);
            // 
            // changeTextColorMenuItem
            // 
            this.changeTextColorMenuItem.Index = 1;
            this.changeTextColorMenuItem.Text = "Change text color...";
            this.changeTextColorMenuItem.Click += new System.EventHandler(this.changeTextColorMenuItem_Click);
            // 
            // changeBackgroundColorMenuItem
            // 
            this.changeBackgroundColorMenuItem.Index = 2;
            this.changeBackgroundColorMenuItem.Text = "Change background color...";
            this.changeBackgroundColorMenuItem.Click += new System.EventHandler(this.changeBackgroundColorMenuItem_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 3;
            this.MenuItem1.Text = "-";
            // 
            // resetFontsAndColorsMenuItem
            // 
            this.resetFontsAndColorsMenuItem.Index = 4;
            this.resetFontsAndColorsMenuItem.Text = "Reset fonts and colors";
            this.resetFontsAndColorsMenuItem.Click += new System.EventHandler(this.resetFontsAndColorsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 2;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // principleErrorProvider
            // 
            this.principleErrorProvider.ContainerControl = this;
            // 
            // numberOfPaymentsErrorProvider
            // 
            this.numberOfPaymentsErrorProvider.ContainerControl = this;
            // 
            // interestRateErrorProvider
            // 
            this.interestRateErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 172);
            this.Controls.Add(this.outerTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Payment Calculator";
            this.outerTableLayoutPanel.ResumeLayout(false);
            this.outerTableLayoutPanel.PerformLayout();
            this.innerTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.principleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPaymentsErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel outerTableLayoutPanel;
        internal System.Windows.Forms.TableLayoutPanel innerTableLayoutPanel;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Button resetButton;
        internal System.Windows.Forms.Label interestRateLabel;
        internal System.Windows.Forms.Label numberOfPaymentsLabel;
        internal System.Windows.Forms.Label principleLabel;
        internal System.Windows.Forms.Label monthlyPaymentLabel;
        internal System.Windows.Forms.TextBox interestRateTextBox;
        internal System.Windows.Forms.TextBox numberOfPaymentsTextBox;
        internal System.Windows.Forms.TextBox principleTextBox;
        internal System.Windows.Forms.TextBox monthlyPaymentTextBox;
        internal System.Windows.Forms.MenuItem exitMenuItem;
        internal System.Windows.Forms.MenuItem fileMenuItem;
        internal System.Windows.Forms.MainMenu mainMenu;
        internal System.Windows.Forms.MenuItem editMenuItem;
        internal System.Windows.Forms.MenuItem changeFontMenuItem;
        internal System.Windows.Forms.MenuItem changeTextColorMenuItem;
        internal System.Windows.Forms.MenuItem changeBackgroundColorMenuItem;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem resetFontsAndColorsMenuItem;
        internal System.Windows.Forms.MenuItem helpMenuItem;
        internal System.Windows.Forms.MenuItem aboutMenuItem;
        internal System.Windows.Forms.ErrorProvider principleErrorProvider;
        internal System.Windows.Forms.ErrorProvider numberOfPaymentsErrorProvider;
        internal System.Windows.Forms.ErrorProvider interestRateErrorProvider;
    }
}

