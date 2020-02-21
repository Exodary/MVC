using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToHex(decimalNumber));
    }

    private static string DecimalToHex(long decNumber)
    {
        if (decNumber == 0)
        {
            return "0";
        }
        else
        {
            string hexadecimalNumber = string.Empty; // other way: string hexaNumber = "";   

            while (decNumber > 0)
            {
                // must be long; when this type is int the result is wrong
                long checkRemainder = (long)decNumber % 16;

                string remainder = string.Empty;

                switch (checkRemainder)
                {
                    case 10: remainder = "A"; break;
                    case 11: remainder = "B"; break;
                    case 12: remainder = "C"; break;
                    case 13: remainder = "D"; break;
                    case 14: remainder = "E"; break;
                    case 15: remainder = "F"; break;
                    default: remainder = checkRemainder.ToString(); break;
                }

                hexadecimalNumber = remainder + hexadecimalNumber;
                decNumber /= 16;
            }

            return hexadecimalNumber;
        }
    }

}