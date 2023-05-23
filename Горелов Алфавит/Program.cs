using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Горелов_Алфавит
{
    class Program
    {
        static void Main(string[] args)
        {
            EngAlphabet engAlphabet = new EngAlphabet();
            Alphabet alph = new Alphabet("ASCII", new char[] { '☺', '☻', '♥', '♦' });
            RusAlphabet rusAlphabet = new RusAlphabet();
            Console.WriteLine();
            engAlphabet.CountLetters();
            engAlphabet.WriteLetters();
            engAlphabet.Example();
            Console.WriteLine(engAlphabet.CheckLetter('q'));
            Console.WriteLine(engAlphabet.CheckLetter('к'));
            Console.WriteLine();
            alph.WriteLetters();
            alph.CountLetters();
            Console.WriteLine();
            rusAlphabet.CountLetters();
            rusAlphabet.WriteLetters();
            rusAlphabet.Example();
            Console.WriteLine(rusAlphabet.CheckLetter('q'));
            Console.WriteLine(rusAlphabet.CheckLetter('к'));
        }
    }
}
