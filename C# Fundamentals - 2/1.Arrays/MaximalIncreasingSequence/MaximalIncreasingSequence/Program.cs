using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int currentSequence = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                    currentSequence = 1;
                }
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            Console.WriteLine(maxSequence);
        }
    }
}
