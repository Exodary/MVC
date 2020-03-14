using System;

namespace ReversedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNumber(number));
        }

        static decimal ReversedNumber(decimal number)
        {
            string input = number.ToString();

            string reversedInput = null;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            return decimal.Parse(reversedInput);
        }
    }
}
