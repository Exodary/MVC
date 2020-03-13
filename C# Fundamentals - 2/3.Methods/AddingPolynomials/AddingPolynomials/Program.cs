using System;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] firstPolynomialCoefficients = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        int[] secondPolynomialCoefficients = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        int[] sum = AddPolynomials(firstPolynomialCoefficients, secondPolynomialCoefficients, length);

        Console.WriteLine(String.Join(" ", sum));
    }

    public static int[] AddPolynomials(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] + secondArray[i];
        }

        return resultArray;
    }

}