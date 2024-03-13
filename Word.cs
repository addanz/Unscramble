using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unscramble
{
    public class Word
    {
        public string OriginalWord { get; set; }
        public string ScrambledWord { get; set; }

        public void ScrambleWord()
        {
            char[] chars = OriginalWord.ToCharArray();
            Random rand = new Random();
            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            ScrambledWord = new string(chars);
        }
    }
}
