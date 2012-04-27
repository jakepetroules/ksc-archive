namespace jpetroulesMPGcs
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
            this.distanceTraveledLabel = new System.Windows.Forms.Label();
            this.fuelUsedLabel = new System.Windows.Forms.Label();
            this.fuelEfficiencyLabel = new System.Windows.Forms.Label();
            this.distanceTraveledTextBox = new System.Windows.Forms.TextBox();
            this.fuelUsedTextBox = new System.Windows.Forms.TextBox();
            this.fuelEfficiencyTextBox = new System.Windows.Forms.TextBox();
            this.distanceTraveledErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fuelUsedErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.outerTableLayoutPanel.SuspendLayout();
            this.innerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTraveledErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelUsedErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // outerTableLayoutPanel
            // 
            this.outerTableLayoutPanel.AutoSize = true;
            this.outerTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outerTableLayoutPanel.ColumnCount = 2;
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTableLayoutPanel.Controls.Add(this.innerTableLayoutPanel, 0, 3);
            this.outerTableLayoutPanel.Controls.Add(this.distanceTraveledLabel, 0, 0);
            this.outerTableLayoutPanel.Controls.Add(this.fuelUsedLabel, 0, 1);
            this.outerTableLayoutPanel.Controls.Add(this.fuelEfficiencyLabel, 0, 2);
            this.outerTableLayoutPanel.Controls.Add(this.distanceTraveledTextBox, 1, 0);
            this.outerTableLayoutPanel.Controls.Add(this.fuelUsedTextBox, 1, 1);
            this.outerTableLayoutPanel.Controls.Add(this.fuelEfficiencyTextBox, 1, 2);
            this.outerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.outerTableLayoutPanel.Name = "outerTableLayoutPanel";
            this.outerTableLayoutPanel.RowCount = 4;
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerTableLayoutPanel.Size = new System.Drawing.Size(345, 123);
            this.outerTableLayoutPanel.TabIndex = 0;
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
            this.innerTableLayoutPanel.Location = new System.Drawing.Point(3, 74);
            this.innerTableLayoutPanel.Name = "innerTableLayoutPanel";
            this.innerTableLayoutPanel.RowCount = 1;
            this.innerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerTableLayoutPanel.Size = new System.Drawing.Size(339, 46);
            this.innerTableLayoutPanel.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculateButton.Location = new System.Drawing.Point(91, 11);
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
            this.resetButton.Location = new System.Drawing.Point(172, 11);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // distanceTraveledLabel
            // 
            this.distanceTraveledLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.distanceTraveledLabel.AutoSize = true;
            this.distanceTraveledLabel.Location = new System.Drawing.Point(3, 6);
            this.distanceTraveledLabel.Name = "distanceTraveledLabel";
            this.distanceTraveledLabel.Size = new System.Drawing.Size(154, 13);
            this.distanceTraveledLabel.TabIndex = 0;
            this.distanceTraveledLabel.Text = "Distance traveled (miles or km):";
            // 
            // fuelUsedLabel
            // 
            this.fuelUsedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fuelUsedLabel.AutoSize = true;
            this.fuelUsedLabel.Location = new System.Drawing.Point(3, 32);
            this.fuelUsedLabel.Name = "fuelUsedLabel";
            this.fuelUsedLabel.Size = new System.Drawing.Size(134, 13);
            this.fuelUsedLabel.TabIndex = 2;
            this.fuelUsedLabel.Text = "Fuel used (gallons or liters):";
            // 
            // fuelEfficiencyLabel
            // 
            this.fuelEfficiencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fuelEfficiencyLabel.AutoSize = true;
            this.fuelEfficiencyLabel.Location = new System.Drawing.Point(3, 55);
            this.fuelEfficiencyLabel.Name = "fuelEfficiencyLabel";
            this.fuelEfficiencyLabel.Size = new System.Drawing.Size(143, 13);
            this.fuelEfficiencyLabel.TabIndex = 4;
            this.fuelEfficiencyLabel.Text = "Fuel efficiency (mpg or km/l):";
            // 
            // distanceTraveledTextBox
            // 
            this.distanceTraveledTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceTraveledTextBox.Location = new System.Drawing.Point(163, 3);
            this.distanceTraveledTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.distanceTraveledTextBox.Name = "distanceTraveledTextBox";
            this.distanceTraveledTextBox.Size = new System.Drawing.Size(163, 20);
            this.distanceTraveledTextBox.TabIndex = 1;
            this.distanceTraveledTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distanceTraveledTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.distanceTraveledTextBox_Validating);
            // 
            // fuelUsedTextBox
            // 
            this.fuelUsedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelUsedTextBox.Location = new System.Drawing.Point(163, 29);
            this.fuelUsedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.fuelUsedTextBox.Name = "fuelUsedTextBox";
            this.fuelUsedTextBox.Size = new System.Drawing.Size(163, 20);
            this.fuelUsedTextBox.TabIndex = 3;
            this.fuelUsedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fuelUsedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fuelUsedTextBox_Validating);
            // 
            // fuelEfficiencyTextBox
            // 
            this.fuelEfficiencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fuelEfficiencyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelEfficiencyTextBox.Location = new System.Drawing.Point(163, 55);
            this.fuelEfficiencyTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.fuelEfficiencyTextBox.Name = "fuelEfficiencyTextBox";
            this.fuelEfficiencyTextBox.ReadOnly = true;
            this.fuelEfficiencyTextBox.Size = new System.Drawing.Size(163, 13);
            this.fuelEfficiencyTextBox.TabIndex = 5;
            this.fuelEfficiencyTextBox.TabStop = false;
            this.fuelEfficiencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // distanceTraveledErrorProvider
            // 
            this.distanceTraveledErrorProvider.ContainerControl = this;
            // 
            // fuelUsedErrorProvider
            // 
            this.fuelUsedErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 147);
            this.Controls.Add(this.outerTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Efficiency Calculator";
            this.outerTableLayoutPanel.ResumeLayout(false);
            this.outerTableLayoutPanel.PerformLayout();
            this.innerTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanceTraveledErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelUsedErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel outerTableLayoutPanel;
        internal System.Windows.Forms.TableLayoutPanel innerTableLayoutPanel;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Button resetButton;
        internal System.Windows.Forms.Label distanceTraveledLabel;
        internal System.Windows.Forms.Label fuelUsedLabel;
        internal System.Windows.Forms.Label fuelEfficiencyLabel;
        internal System.Windows.Forms.TextBox distanceTraveledTextBox;
        internal System.Windows.Forms.TextBox fuelUsedTextBox;
        internal System.Windows.Forms.TextBox fuelEfficiencyTextBox;
        internal System.Windows.Forms.ErrorProvider distanceTraveledErrorProvider;
        internal System.Windows.Forms.ErrorProvider fuelUsedErrorProvider;
    }
}

