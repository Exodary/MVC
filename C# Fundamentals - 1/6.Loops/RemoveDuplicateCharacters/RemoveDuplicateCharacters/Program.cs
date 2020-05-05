using System;

class Program
{
    static void Main()
    {
        string UserInput = Console.ReadLine();

        string result = RemoveDuplicateChars(UserInput);

        Console.WriteLine(result);
        
    }

    static string RemoveDuplicateChars(string key)
    {
        string table = "";

        string result = "";

        foreach (char value in key)
        {
            if (table.IndexOf(value) == -1)
            {
                // Append to the table and the result.
                table += value;
                result += value;
            }
        }
        return result;
    }
}