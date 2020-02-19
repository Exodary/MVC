using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = ArrayReader();

            int numberToCount = int.Parse(Console.ReadLine());

            int countResult = Counter(numberToCount, inputArray);

            Console.WriteLine(countResult);

        }

        static int[] ArrayReader()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            string[] inputText = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[sizeOfArray];

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = int.Parse(inputText[i]);
            }

            return numbers;
        }

        static int Counter(int number,params int[] array)
        {
            int counter = 0;

            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
