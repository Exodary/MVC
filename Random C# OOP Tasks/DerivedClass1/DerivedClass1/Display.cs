using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass1
{
    public class Display
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int NumberOfColors { get; set; }

        public Display(int height = 0, int width = 0, int numbersOfColors = 0)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfColors = numbersOfColors;
        }
    }
}
