/*  21. Letters count
    Write a program that reads a string from the console and 
    prints all different letters in the string along with information how many times each letter is found. 
 */

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string str = Console.ReadLine();
        //string str = "aaa bbb BBBB AAAAA bbb 0123456";

        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            letters.Add(i, 0);
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters.Add(i, 0);
        }

        foreach (char ch in str)
        {
            if (letters.ContainsKey(ch))
            {
                letters[ch]++;
            }
        }

        var orderedLetters = letters; 

        foreach (var letter in orderedLetters)
        {
            if (letter.Value != 0)
            {
                Console.WriteLine("{0} -> {1} ", letter.Key, letter.Value);
            }
        }

    }
}