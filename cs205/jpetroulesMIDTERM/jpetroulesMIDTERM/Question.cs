namespace jpetroulesMIDTERM
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Represents a question that can be asked in the game.
    /// </summary>
    public sealed class Question
    {
        private Collection<string> answers = new Collection<string>();

        public Question(string questionText, int correctAnswerIndex, string answer1, string answer2, string answer3, string answer4, string info = "")
        {
            this.QuestionText = questionText;
            this.CorrectAnswerIndex = correctAnswerIndex;
            this.answers.Add(answer1);
            this.answers.Add(answer2);
            this.answers.Add(answer3);
            this.answers.Add(answer4);
            this.Info = info;
        }

        public string QuestionText
        {
            get;
            private set;
        }

        public string Info
        {
            get;
            private set;
        }

        public int CorrectAnswerIndex
        {
            get;
            private set;
        }

        public ReadOnlyCollection<string> Answers
        {
            get { return new ReadOnlyCollection<string>(this.answers); }
        }

        public string CorrectAnswer
        {
            get { return this.answers[this.CorrectAnswerIndex]; }
        }
    }
}
