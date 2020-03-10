using System;

namespace SquareOfNumber
{
    class Program
    {
        static void SquareOfNumber(int number)
        {
            int square = number * number;

            Console.WriteLine(square);
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            SquareOfNumber(num);
        }
    }
}
