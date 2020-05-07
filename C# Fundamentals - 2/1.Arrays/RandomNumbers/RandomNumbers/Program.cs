using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> randomSorted = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                randomSorted.Add(random.Next(100, 200));
            }

            List<int> sortedList = QuickSort(randomSorted);

            foreach(int ele in sortedList)
            {
                Console.WriteLine(ele);
            }
            
        }

        static List<int> QuickSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            int pivot = unsorted.Count / 2;
            int pivotValue = unsorted[pivot];

            unsorted.RemoveAt(pivot);

            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            foreach(int element in unsorted)
            {
                if(element <= pivotValue)
                {
                    less.Add(element);
                }
                if(element > pivotValue)
                {
                    greater.Add(element);
                }
            }

            List<int> result = new List<int>();

            result.AddRange(QuickSort(less));
            result.Add(pivotValue);
            result.AddRange(QuickSort(greater));

            return result;
        }
     }
}
