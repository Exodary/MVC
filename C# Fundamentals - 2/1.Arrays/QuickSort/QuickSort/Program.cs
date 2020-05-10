using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            numbers = Generate(size);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("#######");

            Shuffle(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

                Console.WriteLine("$$$$$");

            List<int> sorted = QuickSort(numbers);

            foreach(int num in sorted)
            {
                Console.WriteLine(num);
            }
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
                else if(numbers[i] > pivot)
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
            var numbers = new List<int>();

            for(int i = 1; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        public static void Shuffle(List<int> numbers)
        {
            Random random = new Random();

            for(int i = 0; i < numbers.Count; i++)
            {
                var randomIndex = random.Next(i, numbers.Count);
                Swap(numbers, i, randomIndex);
            }
        }

        public static void Swap(List<int> numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}
