namespace jpetroulesMIDTERM
{
    using System.Windows.Forms;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.Globalization;
    using System.Drawing;
    using System.IO;
    using System;

    public partial class MainForm : Form
    {
        private Question currentQuestion;
        private int questionIndex;
        private int score;

        private const int QuestionsPerGame = 20;
        private const int ScorePerQuestion = 5;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.gameBeginPanel.BringToFront();
        }

        private void buttonAnswer_Click(object sender, System.EventArgs e)
        {
            string name = ((Button)sender).Name;
            this.CheckAnswer(name[name.Length - 1] - '0' - 1);
        }

        private void CheckAnswer(int index)
        {
            if (index == this.currentQuestion.CorrectAnswerIndex)
            {
                this.score += ScorePerQuestion;

                this.infoLabel.Text = this.currentQuestion.Info;
                this.correctAnswerPanel.BringToFront();
            }
            else
            {
                this.correctAnswerWasLabel.Text = string.Format(CultureInfo.CurrentCulture, "The correct answer was {0}", this.currentQuestion.CorrectAnswer);
                this.incorrectAnswerPanel.BringToFront();
            }

            this.UpdateScore();
            this.questionIndex++;
        }

        private void UpdateScore()
        {
            this.scoreLabel.Text = string.Format(CultureInfo.CurrentCulture, "Score: {0}", this.score);
        }

        private void LoadQuestion()
        {
            this.currentQuestion = QuestionBank.GenerateQuestion();
            this.questionLabel.Text = string.Format(CultureInfo.CurrentCulture, "Question {0} of {1}\n\n{2}", this.questionIndex + 1, QuestionsPerGame, this.currentQuestion.QuestionText);
            this.answerButton1.Text = this.currentQuestion.Answers[0];
            this.answerButton2.Text = this.currentQuestion.Answers[1];
            this.answerButton3.Text = this.currentQuestion.Answers[2];
            this.answerButton4.Text = this.currentQuestion.Answers[3];
            this.questionPanel.BringToFront();

            this.UpdateScore();
        }

        private void correctAnswerContinueButton_Click(object sender, System.EventArgs e)
        {
            if (this.questionIndex < QuestionsPerGame)
            {
                this.LoadQuestion();
            }
            else
            {
                this.finalScoreLabel.Text = string.Format(CultureInfo.CurrentCulture, "{0} / {1}", this.score, QuestionsPerGame * ScorePerQuestion);
                this.gameOverPanel.BringToFront();

                EnterNameDialog enterNameDialog = new EnterNameDialog();
                if (enterNameDialog.ShowDialog() == DialogResult.OK)
                {
                    this.AppendHighScore(enterNameDialog.PlayerName);
                }
            }
        }

        private void startGameButton_Click(object sender, System.EventArgs e)
        {
            this.questionIndex = 0;
            this.score = 0;
            this.LoadQuestion();
        }

        private void highscoresMenuItem_Click(object sender, System.EventArgs e)
        {
            HighscoresForm highscores = new HighscoresForm();
            highscores.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void AppendHighScore(string name)
        {
            File.AppendAllText(Path.Combine(Application.StartupPath, "highscores.txt"), string.Format(CultureInfo.InvariantCulture, "\"{0}\",{1},\"{2}\"\n", name.Replace("\"", "\\\""), this.score, DateTime.UtcNow.ToString()));
        }
    }
}
