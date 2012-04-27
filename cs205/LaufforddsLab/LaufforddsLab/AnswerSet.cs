namespace Petroules.LaufforddsLab
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class AnswerSet<T>
    {
        private Collection<T> answers = new Collection<T>();

        public AnswerSet(IList<T> bank)
        {
            Random random = new Random();

            this.answers = new Collection<T>();
            while (this.answers.Count < AnswerSet<T>.MultipleChoiceCount)
            {
                T item = bank[random.Next(bank.Count)];
                if (!this.answers.Contains(item))
                {
                    this.answers.Add(item);
                }
            }

            this.CorrectAnswerIndex = random.Next(answers.Count);
        }

        public static int MultipleChoiceCount
        {
            get { return 4; }
        }

        public ReadOnlyCollection<T> Answers
        {
            get { return new ReadOnlyCollection<T>(this.answers); }
        }

        public int CorrectAnswerIndex
        {
            get;
            private set;
        }

        public T CorrectAnswer
        {
            get { return this.answers[this.CorrectAnswerIndex]; }
        }

        public T this[int index]
        {
            get { return this.answers[index]; }
        }
    }
}
