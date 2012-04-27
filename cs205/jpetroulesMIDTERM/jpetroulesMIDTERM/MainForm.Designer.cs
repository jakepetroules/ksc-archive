namespace jpetroulesMIDTERM
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.questionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.correctAnswerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.incorrectAnswerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.correctAnswerWasLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.gameOverTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.correctAnswerContinueButton = new System.Windows.Forms.Button();
            this.incorrectAnswerContinueButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameStatePanel = new System.Windows.Forms.Panel();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.correctAnswerPanel = new System.Windows.Forms.Panel();
            this.incorrectAnswerPanel = new System.Windows.Forms.Panel();
            this.gameBeginPanel = new System.Windows.Forms.Panel();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.questionTableLayoutPanel.SuspendLayout();
            this.correctAnswerTableLayoutPanel.SuspendLayout();
            this.incorrectAnswerTableLayoutPanel.SuspendLayout();
            this.gameOverTableLayoutPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.gameStatePanel.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.correctAnswerPanel.SuspendLayout();
            this.incorrectAnswerPanel.SuspendLayout();
            this.gameBeginPanel.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Location = new System.Drawing.Point(3, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(524, 179);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            this.answerButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerButton1.AutoSize = true;
            this.answerButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answerButton1.Location = new System.Drawing.Point(234, 182);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(61, 23);
            this.answerButton1.TabIndex = 1;
            this.answerButton1.Text = "Answer 1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerButton2.AutoSize = true;
            this.answerButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answerButton2.Location = new System.Drawing.Point(234, 211);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(61, 23);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "Answer 2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerButton3.AutoSize = true;
            this.answerButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answerButton3.Location = new System.Drawing.Point(234, 240);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(61, 23);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "Answer 3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerButton4.AutoSize = true;
            this.answerButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answerButton4.Location = new System.Drawing.Point(234, 269);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(61, 23);
            this.answerButton4.TabIndex = 4;
            this.answerButton4.Text = "Answer 4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(3, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 5;
            // 
            // questionTableLayoutPanel
            // 
            this.questionTableLayoutPanel.ColumnCount = 1;
            this.questionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionTableLayoutPanel.Controls.Add(this.questionLabel, 0, 0);
            this.questionTableLayoutPanel.Controls.Add(this.answerButton1, 0, 1);
            this.questionTableLayoutPanel.Controls.Add(this.answerButton4, 0, 4);
            this.questionTableLayoutPanel.Controls.Add(this.answerButton2, 0, 2);
            this.questionTableLayoutPanel.Controls.Add(this.answerButton3, 0, 3);
            this.questionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.questionTableLayoutPanel.Name = "questionTableLayoutPanel";
            this.questionTableLayoutPanel.RowCount = 5;
            this.questionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.questionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.questionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.questionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.questionTableLayoutPanel.Size = new System.Drawing.Size(530, 295);
            this.questionTableLayoutPanel.TabIndex = 0;
            // 
            // correctAnswerTableLayoutPanel
            // 
            this.correctAnswerTableLayoutPanel.ColumnCount = 1;
            this.correctAnswerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.correctAnswerTableLayoutPanel.Controls.Add(this.correctAnswerLabel, 0, 0);
            this.correctAnswerTableLayoutPanel.Controls.Add(this.infoLabel, 0, 1);
            this.correctAnswerTableLayoutPanel.Controls.Add(this.correctAnswerContinueButton, 0, 2);
            this.correctAnswerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctAnswerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.correctAnswerTableLayoutPanel.Name = "correctAnswerTableLayoutPanel";
            this.correctAnswerTableLayoutPanel.RowCount = 3;
            this.correctAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.correctAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.correctAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.correctAnswerTableLayoutPanel.Size = new System.Drawing.Size(554, 319);
            this.correctAnswerTableLayoutPanel.TabIndex = 2;
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerLabel.ForeColor = System.Drawing.Color.Green;
            this.correctAnswerLabel.Location = new System.Drawing.Point(3, 0);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(548, 106);
            this.correctAnswerLabel.TabIndex = 0;
            this.correctAnswerLabel.Text = "Correct!";
            this.correctAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(3, 106);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(548, 106);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // incorrectAnswerTableLayoutPanel
            // 
            this.incorrectAnswerTableLayoutPanel.ColumnCount = 1;
            this.incorrectAnswerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.incorrectAnswerTableLayoutPanel.Controls.Add(this.incorrectLabel, 0, 0);
            this.incorrectAnswerTableLayoutPanel.Controls.Add(this.correctAnswerWasLabel, 0, 1);
            this.incorrectAnswerTableLayoutPanel.Controls.Add(this.incorrectAnswerContinueButton, 0, 2);
            this.incorrectAnswerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incorrectAnswerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.incorrectAnswerTableLayoutPanel.Name = "incorrectAnswerTableLayoutPanel";
            this.incorrectAnswerTableLayoutPanel.RowCount = 3;
            this.incorrectAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.incorrectAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.incorrectAnswerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.incorrectAnswerTableLayoutPanel.Size = new System.Drawing.Size(554, 319);
            this.incorrectAnswerTableLayoutPanel.TabIndex = 3;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLabel.Location = new System.Drawing.Point(3, 0);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(548, 106);
            this.incorrectLabel.TabIndex = 0;
            this.incorrectLabel.Text = "Incorrect!";
            this.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctAnswerWasLabel
            // 
            this.correctAnswerWasLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctAnswerWasLabel.Location = new System.Drawing.Point(3, 106);
            this.correctAnswerWasLabel.Name = "correctAnswerWasLabel";
            this.correctAnswerWasLabel.Size = new System.Drawing.Size(548, 106);
            this.correctAnswerWasLabel.TabIndex = 1;
            this.correctAnswerWasLabel.Text = "The correct answer was {0}.";
            this.correctAnswerWasLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Location = new System.Drawing.Point(206, 83);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(143, 13);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Welcome to Lauffordd\'s Lab!";
            // 
            // gameOverTableLayoutPanel
            // 
            this.gameOverTableLayoutPanel.ColumnCount = 1;
            this.gameOverTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gameOverTableLayoutPanel.Controls.Add(this.gameOverLabel, 0, 0);
            this.gameOverTableLayoutPanel.Controls.Add(this.finalScoreLabel, 0, 1);
            this.gameOverTableLayoutPanel.Controls.Add(this.newGameButton, 0, 2);
            this.gameOverTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverTableLayoutPanel.Name = "gameOverTableLayoutPanel";
            this.gameOverTableLayoutPanel.RowCount = 3;
            this.gameOverTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameOverTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameOverTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameOverTableLayoutPanel.Size = new System.Drawing.Size(554, 319);
            this.gameOverTableLayoutPanel.TabIndex = 2;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(3, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(548, 106);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "Game over!";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.Location = new System.Drawing.Point(3, 106);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(548, 106);
            this.finalScoreLabel.TabIndex = 1;
            this.finalScoreLabel.Text = "{0} / {1}";
            this.finalScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // correctAnswerContinueButton
            // 
            this.correctAnswerContinueButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correctAnswerContinueButton.Location = new System.Drawing.Point(239, 215);
            this.correctAnswerContinueButton.Name = "correctAnswerContinueButton";
            this.correctAnswerContinueButton.Size = new System.Drawing.Size(75, 23);
            this.correctAnswerContinueButton.TabIndex = 2;
            this.correctAnswerContinueButton.Text = "Continue";
            this.correctAnswerContinueButton.UseVisualStyleBackColor = true;
            this.correctAnswerContinueButton.Click += new System.EventHandler(this.correctAnswerContinueButton_Click);
            // 
            // incorrectAnswerContinueButton
            // 
            this.incorrectAnswerContinueButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.incorrectAnswerContinueButton.Location = new System.Drawing.Point(239, 215);
            this.incorrectAnswerContinueButton.Name = "incorrectAnswerContinueButton";
            this.incorrectAnswerContinueButton.Size = new System.Drawing.Size(75, 23);
            this.incorrectAnswerContinueButton.TabIndex = 2;
            this.incorrectAnswerContinueButton.Text = "Continue";
            this.incorrectAnswerContinueButton.UseVisualStyleBackColor = true;
            this.incorrectAnswerContinueButton.Click += new System.EventHandler(this.correctAnswerContinueButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(240, 195);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newGameButton.Location = new System.Drawing.Point(239, 215);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.scoreLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.gameStatePanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(560, 338);
            this.mainTableLayoutPanel.TabIndex = 8;
            // 
            // gameStatePanel
            // 
            this.gameStatePanel.Controls.Add(this.gameBeginPanel);
            this.gameStatePanel.Controls.Add(this.gameOverPanel);
            this.gameStatePanel.Controls.Add(this.incorrectAnswerPanel);
            this.gameStatePanel.Controls.Add(this.correctAnswerPanel);
            this.gameStatePanel.Controls.Add(this.questionPanel);
            this.gameStatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameStatePanel.Location = new System.Drawing.Point(3, 16);
            this.gameStatePanel.Name = "gameStatePanel";
            this.gameStatePanel.Size = new System.Drawing.Size(554, 319);
            this.gameStatePanel.TabIndex = 9;
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionTableLayoutPanel);
            this.questionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionPanel.Location = new System.Drawing.Point(0, 0);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Padding = new System.Windows.Forms.Padding(12);
            this.questionPanel.Size = new System.Drawing.Size(554, 319);
            this.questionPanel.TabIndex = 0;
            // 
            // correctAnswerPanel
            // 
            this.correctAnswerPanel.Controls.Add(this.correctAnswerTableLayoutPanel);
            this.correctAnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctAnswerPanel.Location = new System.Drawing.Point(0, 0);
            this.correctAnswerPanel.Name = "correctAnswerPanel";
            this.correctAnswerPanel.Size = new System.Drawing.Size(554, 319);
            this.correctAnswerPanel.TabIndex = 1;
            // 
            // incorrectAnswerPanel
            // 
            this.incorrectAnswerPanel.Controls.Add(this.incorrectAnswerTableLayoutPanel);
            this.incorrectAnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incorrectAnswerPanel.Location = new System.Drawing.Point(0, 0);
            this.incorrectAnswerPanel.Name = "incorrectAnswerPanel";
            this.incorrectAnswerPanel.Size = new System.Drawing.Size(554, 319);
            this.incorrectAnswerPanel.TabIndex = 10;
            // 
            // gameBeginPanel
            // 
            this.gameBeginPanel.Controls.Add(this.introLabel);
            this.gameBeginPanel.Controls.Add(this.startGameButton);
            this.gameBeginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBeginPanel.Location = new System.Drawing.Point(0, 0);
            this.gameBeginPanel.Name = "gameBeginPanel";
            this.gameBeginPanel.Size = new System.Drawing.Size(554, 319);
            this.gameBeginPanel.TabIndex = 10;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Controls.Add(this.gameOverTableLayoutPanel);
            this.gameOverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(554, 319);
            this.gameOverPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lauffordd\'s Laboratory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.questionTableLayoutPanel.ResumeLayout(false);
            this.questionTableLayoutPanel.PerformLayout();
            this.correctAnswerTableLayoutPanel.ResumeLayout(false);
            this.incorrectAnswerTableLayoutPanel.ResumeLayout(false);
            this.gameOverTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.gameStatePanel.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.correctAnswerPanel.ResumeLayout(false);
            this.incorrectAnswerPanel.ResumeLayout(false);
            this.gameBeginPanel.ResumeLayout(false);
            this.gameBeginPanel.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TableLayoutPanel questionTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel gameOverTableLayoutPanel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.TableLayoutPanel correctAnswerTableLayoutPanel;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TableLayoutPanel incorrectAnswerTableLayoutPanel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label correctAnswerWasLabel;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Button correctAnswerContinueButton;
        private System.Windows.Forms.Button incorrectAnswerContinueButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel gameStatePanel;
        private System.Windows.Forms.Panel gameBeginPanel;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Panel incorrectAnswerPanel;
        private System.Windows.Forms.Panel correctAnswerPanel;
        private System.Windows.Forms.Panel questionPanel;
    }
}

