using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMaxSumAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());

            int[] numbers = new int[choice];

            for(int i = 0; i < choice; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            Console.WriteLine("min={0}", numbers.Min());
            Console.WriteLine("max={0}", numbers.Max());
            Console.WriteLine("sum={0}", numbers.Sum());
            Console.WriteLine("avg={0:F2}", numbers.Average());
        }
    }
}
