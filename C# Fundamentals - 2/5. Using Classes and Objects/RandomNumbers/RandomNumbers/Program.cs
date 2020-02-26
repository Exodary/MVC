using System;

class RandomNumbers
{
    static void Main()
    {
        Random rndGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rndGenerator.Next(100, 201));
        }
    }
}