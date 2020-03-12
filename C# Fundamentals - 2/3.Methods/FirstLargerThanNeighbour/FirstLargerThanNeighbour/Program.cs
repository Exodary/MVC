using System;


namespace FirstLargerThanNeighbour
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arraySize];

            ArrayReader(arraySize, numbers);

            int result = FirstLargerThenNeighbours(numbers);

            Console.WriteLine(result);
        }

        static void ArrayReader(int length, params int[] array)
        {
            string[] textArray = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(textArray[i]);
            }
        }

        static int FirstLargerThenNeighbours(params int[] array)
        {
            int index = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    index = i;

                    break;
                }
            }

            return index;
        }
    }
}
