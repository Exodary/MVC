using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleByThreeAndSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= number; i++)
            {
                if(i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
