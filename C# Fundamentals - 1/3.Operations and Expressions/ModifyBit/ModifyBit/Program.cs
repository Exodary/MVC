using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Write position: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Write a value (0) or (1): ");
            int value = int.Parse(Console.ReadLine());
            long mask;
            long result;

            if (value == 0)
            {
                mask = ~(1 << position);
                result = number & mask;

                Console.WriteLine("The new number is: {0}", result);
            }
            else
            {
                mask = 1 << position;
                result = number | mask;

                Console.WriteLine("The new number is: {0}", result);
            }
        }
    }
}
