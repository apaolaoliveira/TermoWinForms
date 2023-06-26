using static TermoWinForms.Domain.Feedbacks;
using TermoWinForms.Controls;
using TermoWinForms.Domain;
using System.Collections;

namespace TermoWinForms
{
    public partial class Termo : Form
    {
        private string guess;
        private int attempts = 0;

        SecretWord word;
        Feedbacks feedback;
        List<PainelRowUserControl> rowsList;

        public Termo()
        {
            InitializeComponent();
            ConfigButtons();
            btnReset.Enabled = false;
            word = new SecretWord();            
            feedback = new Feedbacks();
            rowsList = new List<PainelRowUserControl>()
            {
                row1,
                row2,
                row3,
                row4,
                row5,
                row6
            };
        }

        public PainelRowUserControl CurrentRow()
        {
            return rowsList[attempts];
        }

        private void ConfigButtons()
        {
            foreach (Button button in pnlButtons.Controls)
            {
                if (button.Name != "btnEnter"
                    && button.Name != "btnReset"
                    && button.Name != "btnBackspace")
                    button.Click += ButtonsClick;
            }

            btnEnter.Click += TakeGuess;
            btnReset.Click += ResetGame;
            btnBackspace.Click += BackspaceClick;
        }

        private void ButtonsClick(object? sender, EventArgs e)
        {
            Button btn = (Button)sender!;
            lblText.Visible = false;
            lblText.Text = string.Empty;

            CurrentRow().Typewrite(btn.Text);
        }

        public void ChangeButtonsColor(ArrayList letters, LetterFeedback[] feedbacks)
        {
            for (int i = 0; i < feedbacks.Length; i++)
            {
                string letter = (string)letters[i];

                foreach (Button button in pnlButtons.Controls)
                {
                    if (button.Text == letter)
                    {
                        switch (feedbacks[i])
                        {
                            case LetterFeedback.Correct:
                                button.BackColor = Color.FromArgb(58, 163, 148);
                                break;

                            case LetterFeedback.WrongPosition:
                                button.BackColor = Color.FromArgb(211, 173, 105);
                                break;

                            case LetterFeedback.Incorrect:
                                button.BackColor = Color.FromArgb(49, 42, 44);
                                break;
                        }
                        break;
                    }
                }
            }
        }

        private void BackspaceClick(object? sender, EventArgs e)
        {
            CurrentRow().Backspace();
        }   

        private string HasErrors(string guess)
        {
            if (string.IsNullOrEmpty(guess))
            {
                lblText.Visible = true;
                return "digite uma palavra";
            }

            if (guess.Length < 5)
            {
                lblText.Visible = true;
                return "só palavras com 5 letras";
            }

            if (CurrentRow().SameLetter())
            {
                lblText.Visible = true;
                CurrentRow().ResetLabels();
                return "os campos não devem conter a mesma letra";
            }

            if (CurrentRow().OnlyVogals())
            {
                lblText.Visible = true;
                CurrentRow().ResetLabels();
                return "a palavra não deve conter apenas vogais";
            }

            return string.Empty;
        }

        private void Result(string guess)
        {
            if (Victory(guess))
            {
                lblText.Text = "fenomenal";
                lblText.Visible = true;
                End();
            }

            else if (GameOver())
            {
                lblText.Text = $"\"{word.secretWord}\"";
                lblText.Visible = true;
                End();
            }
        }

        public void TakeGuess(object? sender, EventArgs e)
        {
            guess = CurrentRow().ToString();

            string error = lblText.Text = HasErrors(guess);

            if (error != string.Empty)
                return;

            LetterFeedback[] feedbacks = feedback.CheckGuess(guess, word.secretWord);

            CurrentRow().ChangeLabelColor(feedbacks);
            ArrayList guessLetters = CurrentRow().GuessLetters();
            ChangeButtonsColor(guessLetters, feedbacks);

            Result(guess);

            attempts++;
        }        

        public void ResetGame(object? sender, EventArgs e)
        {
            word = new SecretWord();
            feedback = new Feedbacks();

            attempts = 0;
            lblText.Text = string.Empty;  
            lblText.Visible = false;
            btnReset.Enabled = false;
            pnlButtons.Enabled = true;

            foreach (Button button in pnlButtons.Controls)
                button.BackColor = Color.FromArgb(76, 67, 71);

            foreach (PainelRowUserControl row in tblWords.Controls)
                row.ClearRow();
        }

        private bool Victory(string guess)
        {
            return guess.ToUpper() == word.secretWord.ToUpper();
        }

        public bool GameOver()
        {
            return attempts == 5;
        }

        public void End()
        {
            pnlButtons.Enabled = false;
            btnReset.Enabled = true;
        }
    }
}