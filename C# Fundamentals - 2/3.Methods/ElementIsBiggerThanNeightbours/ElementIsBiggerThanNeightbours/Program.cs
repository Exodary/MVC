using System;


namespace ElementIsBiggerThanNeightbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            ArrayInput(length, numbers);

            int counter = LargerThanNeighbour(numbers);

            Console.WriteLine(counter);


        }

        static void ArrayInput(int length, params int[] array)
        {
            string[] textArray = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < length; i++)
            {
                array[i] = int.Parse(textArray[i]);
            }
        }

        static int LargerThanNeighbour(params int[] array)
        {
            int counter = 0;

            for(int i = 1; i< array.Length - 1; i++)
            {
                if(array[i -1] < array[i] && array[i + 1] < array[i])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
