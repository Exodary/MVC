using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <=255; i++)
            {
                string asci = i.ToString("X");
                Console.Write(asci + " ");
            }
        }
    }
}
