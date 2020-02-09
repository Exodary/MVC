using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var c = 0;
            Console.WriteLine("Before Exchange: {0}, {1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Exchange: {0}, {1}", a, b);
        }
    }
}
