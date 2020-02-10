using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {        
            double number = double.Parse(Console.ReadLine());
            double moonGravity = ((number * 17) / 100);
            Console.WriteLine("The weight on moon will be {0:F3}", moonGravity);

        }
    }
}
