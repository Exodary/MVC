using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            if (number < 2)
            {
                Console.WriteLine("false");
                return;
            }

            bool boolPrime = true;
            if ((number == 2) || (number == 5))
            {
                boolPrime = true;
            }
            else
            {
                if ((number % 2 == 0) || (number % 5 == 0))
                {
                    boolPrime = false;
                }
                else
                {

                    int maxDivider = (int)Math.Sqrt(number);
                    for (int i = 3; i <= maxDivider; i++)
                    {
                        if (number % i == 0)
                        {
                            boolPrime = false;
                            break;
                        }
                    }



                }
            }
            if (boolPrime == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
