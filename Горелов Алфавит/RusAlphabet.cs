using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов_Алфавит
{
    class RusAlphabet : Alphabet
    {
        public RusAlphabet()
        {
            language = "Русский";
            letters = new char[33] {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и','й','к','л',
            'м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
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
            Console.WriteLine("Москва – столица и крупнейший город России, город с богатой историей и культурой. Расположенная в западной части страны, Москва имеет население более 12 миллионов человек, что делает ее одним из крупнейших городов мира.");
        }
    }
}
