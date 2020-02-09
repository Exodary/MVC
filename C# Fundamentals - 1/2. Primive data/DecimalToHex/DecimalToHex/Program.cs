using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 254;

            string hexValue = number.ToString("X");

            Console.WriteLine(hexValue);

        }
    }
}
