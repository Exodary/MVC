using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double product = a * b * c;

            if (product < 0)
            {
                Console.WriteLine("-");
            }
            else if (product == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
