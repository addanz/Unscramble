using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unscramble
{
    public partial class Form1 : Form
    {
        private GameManager gameManager;
        private WordManager wordManager;
        public Form1()
        {
            InitializeComponent();
            string jsonFileName = "words.json";
            string jsonFilePath = Path.Combine(Application.StartupPath, jsonFileName);
            wordManager = new WordManager(jsonFilePath);
            gameManager = new GameManager(wordManager, 3);
            gameManager.StartNewGame();
            UpdateUI();
        }

        private void ButtonSubmitGuess_Click(object sender, EventArgs e)
        {
            string guess = TextBoxUserGuess.Text.Trim();
            if (gameManager.CheckGuess(guess))
            {
                LabelCorrectOrIncorrect.Text = "Correct!";
                gameManager.StartNewGame();
            }
            else
            {
                LabelCorrectOrIncorrect.Text = "Incorrect. Try again.";
            }
            UpdateUI();
        }

        private void ButtonGetHint_Click(object sender, EventArgs e)
        {
            string hint = gameManager.GetHint();
            LabelDisplayHint.Text = hint;
        }
        private void UpdateUI()
        {
            LabelScrambledWord.Text = gameManager.CurrentWord.ScrambledWord;
            LabelScore.Text = "Score: " + gameManager.Score.ToString();
            TextBoxUserGuess.Clear();
            LabelDisplayHint.Text = string.Join(", ", gameManager.UsedHints);
        }
    }
}
