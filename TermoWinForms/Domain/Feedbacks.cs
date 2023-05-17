namespace TermoWinForms.Domain
{
    public class Feedbacks
    {        
        public enum LetterFeedback
        {
            Correct, WrongPosition, Incorrect
        }

        public LetterFeedback[] CheckGuess(string guess, string secretWord)
        {            
            LetterFeedback[] letterFeedback = new LetterFeedback[guess.Length];            
            
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secretWord[i])
                    letterFeedback[i] = LetterFeedback.Correct;

                else if (secretWord.Contains(guess[i]))
                    letterFeedback[i] = LetterFeedback.WrongPosition;

                else
                    letterFeedback[i] = LetterFeedback.Incorrect;
            } 

            return letterFeedback;
        }
    }
}
