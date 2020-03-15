using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] splitNumbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int sum = 0;

                for (int i = 0; i < splitNumbers.Length; i++)
                {
                    sum += int.Parse(splitNumbers[i]);
                }

                Console.WriteLine(sum);
            }
        }
    }
}
