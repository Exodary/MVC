using System;

class TriangleSurfaceSideAltitude
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double altitudeToA = double.Parse(Console.ReadLine());

        double area;

        area = SideAltitudeTriangleArea(sideA, altitudeToA);

        Console.WriteLine("{0:F2}", area);
    }

    public static double SideAltitudeTriangleArea(double side, double altitude)
    {
        return side * altitude / 2;
    }

}