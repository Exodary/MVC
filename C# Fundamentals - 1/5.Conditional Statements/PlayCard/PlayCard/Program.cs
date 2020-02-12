using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // first way - if-else statement
            if (input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9"
                || input == "10" || input == "J" || input == "Q" || input == "K" || input == "A")
            {
                Console.WriteLine("yes {0}", input);
            }
            else
            {
                Console.WriteLine("no {0}", input);
            }

            ////second way - using swicth-case
            //switch (input)
            //{
            //    case "2":
            //    case "3":
            //    case "4":
            //    case "5":
            //    case "6":
            //    case "7":
            //    case "8":
            //    case "9":
            //    case "10":
            //    case "J":
            //    case "Q":
            //    case "K":
            //    case "A":
            //        Console.WriteLine("yes {0}", input);
            //        break;
            //    default:
            //        Console.WriteLine("no {0}", input);
            //        break;
            //}
        }
    }
}
