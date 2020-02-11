using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int i = 0; i < a; i++)
            {
                double b = double.Parse(Console.ReadLine());
                sum += b;
            }

            Console.WriteLine(sum);
        }
    }
}
