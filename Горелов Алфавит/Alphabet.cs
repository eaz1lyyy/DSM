using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов_Алфавит
{
    class Alphabet
    {
        protected string language;
        protected char[] letters;

        protected Alphabet() {}

        public Alphabet(string language, char[] letters)
        {
            this.language = language;
            this.letters = letters;
        }

        public void WriteLetters()
        {
            Console.WriteLine($"Буквы алфавита \"{language}\"");
            foreach (char letter in letters) Console.Write($"{letter} ");
            Console.WriteLine();
        }

        public void CountLetters()
        {
            Console.WriteLine($"В алфавите \"{language}\" всего {letters.Length} букв");
        }
    }
}
