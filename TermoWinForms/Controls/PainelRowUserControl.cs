﻿using TermoWinForms.Domain;
using System.Collections;

namespace TermoWinForms.Controls
{
    public partial class PainelRowUserControl : UserControl
    {
        public List<Label> labelsList;
        private int currentIndex = 0;

        public PainelRowUserControl()
        {
            InitializeComponent();
            labelsList = new List<Label>
            {
                label1,
                label2,
                label3,
                label4,
                label5
            };
        }

        public bool SameLetter()
        {
            char firstLetter = labelsList[0].Text.FirstOrDefault();

            return labelsList.All(label => char.ToUpper(label.Text.FirstOrDefault()) == firstLetter);
        }

        public bool OnlyVogals()
        {
            return labelsList.All(label => label.Text.All(c => "AEIOU".Contains(char.ToUpper(c))));            
        }

        public void ResetLabels()
        {
            foreach (Label label in labelsList)
            {
                label.Text = string.Empty;
            }
        }

        public void Typewrite(string letter)
        {
            Label currentLabel = labelsList[currentIndex];

            currentLabel.Text = letter;

            currentIndex++;

            if (currentIndex >= labelsList.Count)
                currentIndex = 0;
        }

        public ArrayList GuessLetters()
        {
            ArrayList letters = new ArrayList();

            foreach (Label label in labelsList) 
                letters.Add(label.Text);
            
            return letters;
        }

        public override string ToString()
        {
            string fullGuess = string.Empty;

            foreach (Label label in labelsList)
                fullGuess += label.Text;

            return fullGuess;
        }

        public void ChangeLabelColor(Feedbacks.LetterFeedback[] feedbacks)
        {
            for (int i = 0; i < feedbacks.Length; i++)
            {
                Label currentLabel = labelsList[i];

                switch (feedbacks[i])
                {
                    case Feedbacks.LetterFeedback.Correct:
                        currentLabel.BackColor = Color.FromArgb(58, 163, 148);
                        break;

                    case Feedbacks.LetterFeedback.WrongPosition:
                        currentLabel.BackColor = Color.FromArgb(211, 173, 105);
                        break;

                    case Feedbacks.LetterFeedback.Incorrect:
                        currentLabel.BackColor = Color.FromArgb(49, 42, 44);
                        break;
                }
            }
        }

        public void Backspace()
        {
            if (currentIndex == 0)
                return;

            currentIndex--;

            Label selectedLabel = labelsList[currentIndex];
            selectedLabel.Text = string.Empty;
        }

        public void ClearRow()
        {
            currentIndex = 0;

            foreach (Label label in tblColumns.Controls)
            {
                label.Text = string.Empty;
                label.BackColor = Color.FromArgb(97, 84, 88);
            }
        }
    }
}