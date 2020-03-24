/*  6. String length
    Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Input: On the only line you will receive a string
    Output: Output a string with length 20
    Constraints: The length of the given string will be <= 20
    Sample tests:
    Input 	                    Output
    hello 	                    hello***************
    -=StringOfLength20=- 	    -=StringOfLength20=-
 */

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string str = Console.ReadLine().Replace("\\", string.Empty);

        str = str.PadRight(20, '*');
        Console.WriteLine(str);
    }
}