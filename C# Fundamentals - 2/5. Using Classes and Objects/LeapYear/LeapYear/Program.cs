using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);

        if (!isLeap)
        {
            Console.WriteLine("Common");
        }
        else
        {
            Console.WriteLine("Leap");
        }
    }
}