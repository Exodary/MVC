using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToBinaryNumber(decimalNumber));
        }

        private static string DecimalToBinaryNumber(long decNumber)
        {
            if (decNumber == 0)
            {
                return "0";
            }
            else
            {
                string binaryNumber = string.Empty; // other way: string binaryNumber = "";

                while (decNumber > 0)
                {
                    binaryNumber = (decNumber % 2) + binaryNumber;
                    decNumber /= 2;
                }

                return binaryNumber;
            }
        }
    }
}
