using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().Trim();
            string secondWord = Console.ReadLine().Trim();

            CheckAnagram(firstWord, secondWord);
        }

        static void CheckAnagram(string firstWord, string secondWord)
        {
            firstWord.ToLower();
            secondWord.ToLower();

            char[] charsFirstWord = firstWord.ToCharArray();
            char[] charsSecondWord = secondWord.ToCharArray();

            Array.Sort(charsFirstWord);
            Array.Sort(charsSecondWord);

            string newFirstWord = new string(charsFirstWord);
            string newSecondWord = new string(charsSecondWord);

            if(newFirstWord == newSecondWord)
            {
                Console.WriteLine("Yes, the words {0} and {1} are anagrams",newFirstWord, newSecondWord);
            }

            else
            {
                Console.WriteLine("No, the words {0} and {1} aren't anagrams", newFirstWord, newSecondWord);
            }
        }
    }
}
