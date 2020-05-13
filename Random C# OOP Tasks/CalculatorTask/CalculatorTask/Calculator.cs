using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
   public class Calculator
    {
        public static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine("{0} + {1} = {2}",firstNumber, secondNumber ,firstNumber + secondNumber);

        }

        public static void Multiply(double firstNumber, double secondNumber)
        {
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);

        }

        public static void Divide(double firstNumber, double secondNumber)
        {
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);

        }

        public static void Substaction(double firstNumber, double secondNumber)
        {
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);

        }

        public static void Squareroot(double number)
        {
            Console.WriteLine("Square root of {0} = {1}", number, Math.Sqrt(number));

        }


    }
}
