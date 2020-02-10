using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Write a position:");
            int position = int.Parse(Console.ReadLine());

            long mask = 1 << position;
            long andMask = number & mask;
            long nthBit = andMask >> position;

            Console.WriteLine("The bit at position {0} is {1}", position, nthBit);
        }
    }
}
