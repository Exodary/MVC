using System;

class DayOfWeek
{
    static void Main()
    {
        // first way
        Console.WriteLine(DateTime.Now.DayOfWeek);

        // second way
        Console.WriteLine(DateTime.Today.DayOfWeek);
    }
}