﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();

            SayHello(inputName);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
