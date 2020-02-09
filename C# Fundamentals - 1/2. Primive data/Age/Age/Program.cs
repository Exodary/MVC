using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inputNumber = DateTime.Parse(Console.ReadLine());
            int presentYear = DateTime.Now.Year;
            int yearOfInputNumber = inputNumber.Year;
            int yourAge = presentYear - yearOfInputNumber;
            Console.WriteLine("You are {0} years old!", yourAge);
            Console.WriteLine("In 10 years you will be {0} years old", yourAge + 10);
        }
    }
}
