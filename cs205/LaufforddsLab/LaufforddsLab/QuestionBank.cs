namespace Petroules.LaufforddsLab
{
    using System;
    using System.Globalization;

    public static class QuestionBank
    {
        public static Question GenerateQuestion()
        {
            Random random = new Random();

            switch (random.Next(4))
            {
                case 0:
                    return QuestionBank.GenerateGuessTheFormula();
                case 1:
                    return QuestionBank.GenerateGuessTheSubstance();
                case 2:
                    return QuestionBank.GenerateGuessTheAtomicNumber();
                case 3:
                    return QuestionBank.GenerateGuessTheAtomicNumberOfSymbol();
                default:
                    throw new Exception("Wrong place to be");
            }
        }

        public static Question GenerateGuessTheFormula()
        {
            AnswerSet<Molecule> answerSet = new AnswerSet<Molecule>(SubstanceBank.Bank);

            string info = string.Empty;
            if (!string.IsNullOrWhiteSpace(answerSet.CorrectAnswer.Notes))
            {
                info = string.Join(" ", answerSet.CorrectAnswer.Name, answerSet.CorrectAnswer.Notes);
            }

            return new Question(string.Format(CultureInfo.CurrentCulture, "What is the chemical formula of {0}?", answerSet.CorrectAnswer.Name),
                answerSet.CorrectAnswerIndex,
                answerSet[0].ToString(),
                answerSet[1].ToString(),
                answerSet[2].ToString(),
                answerSet[3].ToString(),
                info);
        }

        public static Question GenerateGuessTheSubstance()
        {
            AnswerSet<Molecule> answerSet = new AnswerSet<Molecule>(SubstanceBank.Bank);

            string info = string.Empty;
            if (!string.IsNullOrWhiteSpace(answerSet.CorrectAnswer.Notes))
            {
                info = string.Join(" ", answerSet.CorrectAnswer.Name, answerSet.CorrectAnswer.Notes);
            }

            return new Question(string.Format(CultureInfo.CurrentCulture, "What is {0}?", answerSet.CorrectAnswer.ToString()),
                answerSet.CorrectAnswerIndex,
                answerSet[0].Name,
                answerSet[1].Name,
                answerSet[2].Name,
                answerSet[3].Name,
                info);
        }

        public static Question GenerateGuessTheAtomicNumber()
        {
            AnswerSet<ChemicalElement> answerSet = new AnswerSet<ChemicalElement>(ChemicalElement.ChemicalElements);

            return new Question(string.Format(CultureInfo.CurrentCulture, "What is the atomic number of {0}?", answerSet.CorrectAnswer.Name),
                answerSet.CorrectAnswerIndex,
                answerSet[0].AtomicNumber.ToString(),
                answerSet[1].AtomicNumber.ToString(),
                answerSet[2].AtomicNumber.ToString(),
                answerSet[3].AtomicNumber.ToString());
        }

        public static Question GenerateGuessTheAtomicNumberOfSymbol()
        {
            AnswerSet<ChemicalElement> answerSet = new AnswerSet<ChemicalElement>(ChemicalElement.ChemicalElements);

            return new Question(string.Format(CultureInfo.CurrentCulture, "What is the atomic number of the chemical element represented by the symbol {0}?", answerSet.CorrectAnswer.Symbol),
                answerSet.CorrectAnswerIndex,
                answerSet[0].AtomicNumber.ToString(),
                answerSet[1].AtomicNumber.ToString(),
                answerSet[2].AtomicNumber.ToString(),
                answerSet[3].AtomicNumber.ToString());
        }
    }
}
