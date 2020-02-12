using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputString = Console.ReadLine();


            switch (input)
            {
                case "integer":
                    int value = Convert.ToInt32(inputString);
                    Console.WriteLine(value + 1);
                    break;
                case "real":
                    double number = Convert.ToDouble(inputString);
                    Console.WriteLine("{0:F2}", number + 1);
                    break;
                case "text":
                    Console.WriteLine("{0}*", inputString);
                    break;
            }
        }
    }
}