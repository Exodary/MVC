/*  17. Date in Bulgarian
    Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
    and prints the date and time after 6 hours and 30 minutes 
    (in the same format) along with the day of week in Bulgarian.
    My example:
    Input: 23.05.2016 00:00:00      => Output: понеделник 23.5.2016 г. 6:30:00
 */

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter a date and time in the format [day.month.year hour:minute:second]: ");
        string input = Console.ReadLine();

        DateTime dateAndTime = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        dateAndTime = dateAndTime.AddHours(6.5);

        Console.WriteLine("{0} {1}", dateAndTime.ToString("dddd", new CultureInfo("bg-BG")), dateAndTime);

    }
}