using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Console.Write("{0} ", i);
            }

        }
    }
}
