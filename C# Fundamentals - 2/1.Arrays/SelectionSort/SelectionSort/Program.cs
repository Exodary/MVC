using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int minNumber = 0;


            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                minNumber = i;

                int j;

                for(j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[j] < numbers[minNumber])
                    {
                        minNumber = j;
                    }
                }

                if (minNumber != j)
                {
                    int swap = numbers[i];
                    numbers[i] = numbers[minNumber];
                    numbers[minNumber] = swap;
                }
            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
    
            
        }
    }
}
