using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов_Алфавит
{
    class EngAlphabet : Alphabet
    {
        public EngAlphabet()
        {
            language = "English";
            letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'};
        }

        public bool CheckLetter(char letter)
        {
            foreach (char let in letters)
            {
                if (let == letter) return true;
            }
            return false;
        }

        public void Example()
        {
            Console.WriteLine("Moscow is the capital and largest city of Russia, and it is a city with a rich history and culture. Located in the western part of the country, Moscow has a population of over 12 million people, making it one of the largest cities in the world.");
        }
    }
}
