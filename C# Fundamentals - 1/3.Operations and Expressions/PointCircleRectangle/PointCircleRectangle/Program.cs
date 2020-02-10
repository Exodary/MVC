using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double centerX = 1;
            double centerY = 1;
            double radius = 1.5;

            double rectangleTop = 1;
            double rectangleLeft = -1;
            double rectangleWidth = 6;
            double rectangleHeight = 2;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2));

            if(radius >= distance)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            bool distanceRectangle = (x >= rectangleLeft) && (x <= (rectangleLeft + rectangleWidth)) &&
                                        (y >= (rectangleTop - rectangleHeight)) && (y <= rectangleTop);

            if(distanceRectangle == true)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}
