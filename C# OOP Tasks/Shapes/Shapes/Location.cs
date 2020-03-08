using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Location
    {
        public double x;
        public double y;
        public double side;

       public double GetX()
        {
            return x;
        }

        public void SetX(double value)
        {
            x = value;
        }

        public double GetY()
        {
            return y;
        }

        public void SetY(double value)
        {
            y = value;
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double value)
        {
            side = value;
        }
    }
}
