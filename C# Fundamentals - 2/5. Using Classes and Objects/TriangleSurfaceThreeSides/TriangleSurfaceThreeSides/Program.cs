using System;

class TriangleSurfaceThreeSides
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        double area;

        area = TreeSidesTriangleArea(sideA, sideB, sideC);

        Console.WriteLine("{0:F2}", area);
    }

    // Heron's formula
    public static double TreeSidesTriangleArea(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;

        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

}