using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToDecimalNumber(binaryNumber));
    }

    private static long BinaryToDecimalNumber(string binNumber)
    {
        long decimalNumber = 0;

        for (int position = 0; position < binNumber.Length; position++)
        {
            if (binNumber[binNumber.Length - position - 1] == '0')
            {
                // bypasses the iteration of the inner-most loop and jumps to the update expression in for loop
                continue;
            }

            decimalNumber += (long)Math.Pow(2, position);
        }

        return decimalNumber;
    }
}