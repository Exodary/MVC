using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];
            bool equal = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for(int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }

            for(int k = 0; k < firstArray.Length; k++)
            {
                if(firstArray[k] == secondArray[k])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
