﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetDigit(inputNum));
        }

        private static string GetDigit(int inputNum)
        {
            string digitAsWord = null;

            string inputAsString = inputNum.ToString();

            switch (inputAsString[inputAsString.Length - 1])
            {
                case '0': digitAsWord = "zero"; break;
                case '1': digitAsWord = "one"; break;
                case '2': digitAsWord = "two"; break;
                case '3': digitAsWord = "three"; break;
                case '4': digitAsWord = "four"; break;
                case '5': digitAsWord = "five"; break;
                case '6': digitAsWord = "six"; break;
                case '7': digitAsWord = "seven"; break;
                case '8': digitAsWord = "eight"; break;
                case '9': digitAsWord = "nine"; break;
            }

            return digitAsWord;
        }
    }
}
