using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double CenterX = 0;
            double CenterY = 0;
            double radius = 2;
            double distance = Math.Sqrt(Math.Pow((x - CenterX), 2) + Math.Pow((y - CenterY), 2));
            if (distance <= radius)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}
