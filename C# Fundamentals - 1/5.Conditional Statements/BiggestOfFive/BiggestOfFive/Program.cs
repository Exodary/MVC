using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double biggest = a;

            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            if (biggest < d)
            {
                biggest = d;
            }
            if (biggest < e)
            {
                biggest = e;
            }
            Console.WriteLine(biggest);
        }
    }
}
