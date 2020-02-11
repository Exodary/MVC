using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int c = 1;
            if (a == 1)
            {
                Console.WriteLine(0);
            }
            else if (a == 2)
            {
                Console.WriteLine("0, 1");
            }
            else
            {
                Console.Write("0");

                for (int i = 1; i < a; i++)
                {
                    int temp = b;
                    b = c;
                    c = temp + c;

                    Console.Write(", {0}", b);
                }
            }
            Console.WriteLine();
        }
    }
} 
