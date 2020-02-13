using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());

                for(int i = 1; i <= n; i++)
                {
                    for(int k = i; k <= n + (i - 1); k++)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
