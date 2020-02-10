using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitBitwise
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            string binaryForm = Convert.ToString(number, 2);
            Console.WriteLine("Your number in binary form is: {0}", binaryForm);

            int position = 3;

            int mask = 1 << position;

            int comparison = number & mask;

            int bit = comparison >> position;

            Console.WriteLine("The bit at index 3 is: {0}", bit);

        }
    }
}
