using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unscramble
{
    public class GameManager
    {
        private readonly WordManager wordManager;
        public Word CurrentWord { get; private set; }
        public int Score { get; private set; }
        public int MaxHints { get; }
        public List<string> UsedHints { get; }

        public GameManager(WordManager wordManager, int maxHints)
        {
            this.wordManager = wordManager;
            MaxHints = maxHints;
            UsedHints = new List<string>();
        }

        public void StartNewGame()
        {
            CurrentWord = wordManager.GetRandomWord();
            CurrentWord.ScrambleWord();
            Score = 0;
            UsedHints.Clear();
        }

        public bool CheckGuess(string guess)
        {
            if (guess.ToLower() == CurrentWord.OriginalWord.ToLower())
            {
                Score++;
                return true;
            }
            return false;
        }

        public string GetHint()
        {
            if (UsedHints.Count < MaxHints)
            {
                string hint = RevealRandomLetter(CurrentWord.OriginalWord);
                UsedHints.Add(hint);
                return hint;
            }
            return "No more hints available.";
        }

        private string RevealRandomLetter(string word)
        {
            Random rand = new Random();
            int index = rand.Next(word.Length);
            return word.Substring(index, 1);
        }
    }
}
