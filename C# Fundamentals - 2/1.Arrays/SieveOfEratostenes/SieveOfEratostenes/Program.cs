using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1]; // False by default

            // Find all prime numbers in the range [1...n]
            for (int i = 2; i <= Math.Sqrt(n); i++) //n + 1 = primes.Length
            {
                // Skip those numbers that are not prime
                if (primes[i] == false)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            for (int i = n; i >= 2; i--)
            {
                if (!primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
