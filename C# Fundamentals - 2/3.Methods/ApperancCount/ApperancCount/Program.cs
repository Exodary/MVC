using System;

namespace ApperancCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            string[] numberAsText = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[arraySize];

            for(int i = 0; i< numbers.Length;i++)
            {
                numbers[i] = int.Parse(numberAsText[i]);
            }

            int desiredNumber = int.Parse(Console.ReadLine());

            int appCount = ApperanceCount(numbers, desiredNumber);

            Console.WriteLine(appCount);
        }

        static int ApperanceCount(int[] array, int number)
        {
            int count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
