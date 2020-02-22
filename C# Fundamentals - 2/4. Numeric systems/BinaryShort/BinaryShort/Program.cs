using System;

class ShortToBinaryConvertion
{
    static void Main()
    {
        short shortNumber = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinary(shortNumber));
    }

    private static string ShortToBinary(short number)
    {
        string binaryNumber = string.Empty;

        binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');

        return binaryNumber;
    }
}