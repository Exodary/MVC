using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var escapedQuote = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(escapedQuote);

            var anotherEscapedQuote = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(anotherEscapedQuote);
        }
    }
}
