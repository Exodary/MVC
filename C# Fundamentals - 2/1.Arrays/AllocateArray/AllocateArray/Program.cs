using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
