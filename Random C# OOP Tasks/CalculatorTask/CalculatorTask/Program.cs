﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Calculator.Add(firstNumber, secondNumber);
            Calculator.Substaction(firstNumber, secondNumber);
            Calculator.Multiply(firstNumber, secondNumber);
            Calculator.Divide(firstNumber, secondNumber);
            Calculator.Squareroot(firstNumber);
            Calculator.Squareroot(secondNumber);

        }
    }
}
