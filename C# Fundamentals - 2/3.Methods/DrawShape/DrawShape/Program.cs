using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShape
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            drawShape(number);
        }

        static void drawShape(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }

            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
            }
        }
    }
}
