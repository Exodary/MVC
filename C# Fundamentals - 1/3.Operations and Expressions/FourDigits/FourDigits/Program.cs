using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 1000;
            int secondDigit = (number % 1000) / 100;
            int thirdDigit = (number % 100) / 10;
            int fourthDigit = number % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("Sum of digits: {0}", sum);
            Console.WriteLine("Rerevse order of digits: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Last digit in first position: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
