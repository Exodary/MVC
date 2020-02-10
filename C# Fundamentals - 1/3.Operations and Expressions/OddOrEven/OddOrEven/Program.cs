using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());

            if(a % 2 != 0)
            {
                Console.WriteLine("odd Number");
            }
            else
            {
                Console.WriteLine("even Number");
            }
        }
    }
}
