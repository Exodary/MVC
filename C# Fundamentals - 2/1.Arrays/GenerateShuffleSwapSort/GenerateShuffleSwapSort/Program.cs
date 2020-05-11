using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateShuffleSwapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Generate(20);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Shuffle(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("############");

            List<int> sortedList = new List<int>();

            sortedList = InsertionSort(numbers);

            foreach (int num in sortedList)
            {
                Console.WriteLine(num);
            }
        }

        public static List<int> InsertionSort(List<int> numbers)
        {
            if(numbers.Count <= 1)
            {
                return numbers;
            }

            for(int i = 1; i < numbers.Count; i++)
            {
                int j = i;

                while(j > 0 && numbers[j] < numbers[j - 1])
                {
                    Swap(numbers, j, j - 1);
                    j--;
                }
            }

            return numbers;
        }

        public static List<int> QuickSort(List<int> numbers)
        {
            if(numbers.Count <= 1)
            {
                return numbers;
            }

            int pivotValue = numbers.Count / 2;
            int pivot = numbers[pivotValue];

            List<int> lesser = new List<int>();
            List<int> greater = new List<int>();

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < pivot)
                {
                    lesser.Add(numbers[i]);
                }
                if(pivot < numbers[i])
                {
                    greater.Add(numbers[i]);
                }
            }

            List<int> result = new List<int>();

            result.AddRange(QuickSort(lesser));
            result.Add(pivot);
            result.AddRange(QuickSort(greater));

            return result;
        }

        public static List<int> Generate(int maxNumber)
        {
            List<int> numbers = new List<int>();

            for(int i = 1; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        public static void Shuffle(List<int> numbers)
        {
            Random random = new Random();

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                int randomIndex = random.Next(i + 1, numbers.Count);
                Swap(numbers, i, randomIndex);
            }
        }

        private static void Swap(List<int> numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}
