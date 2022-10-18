using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class VowelOrConsonent
    {
        public char Alphabet;

        public VowelOrConsonent(char alphabet)
        {
            Alphabet = alphabet;
        }
        public void CheckVowelOrConsonent()
        {
            if (Alphabet == 'a' || Alphabet == 'e' || Alphabet == 'i' || Alphabet == 'o' || Alphabet == 'u')
            {
                Console.WriteLine(Alphabet + " is Vowel.");
            }
            else
            {
                Console.WriteLine(Alphabet + " is Consonent.");
            }
        }
    }
}
// Program to Check Whether an Alphabet is Vowel or Consonant