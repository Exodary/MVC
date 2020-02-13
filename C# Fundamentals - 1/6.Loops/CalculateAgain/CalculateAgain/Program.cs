using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            int factorial_Recursion(int number)
            {
                if (number == 1)
                    return 1;
                else
                    return number * factorial_Recursion(number - 1);
            }

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int formula = factorial_Recursion(a) / factorial_Recursion(b);

            Console.WriteLine(formula);

        }

    }
}
