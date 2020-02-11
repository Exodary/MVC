using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (((b * b) - 4 * a * c) < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (((b * b) - 4 * a * c) == 0)
            {
                double x = (-(b / (2 * a)));
                Console.WriteLine("{0:F2}", x);
            }
            else
            {
                double x1 = ((-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));
                double x2 = ((-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a));

                if(x1 > x2)
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);                 
                }
            }
        }
    }
}
