using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        Location l;


        public Square(double X, double Y, double side)
        {
            l.SetX(X);
            l.SetY(Y);
            l.SetSide(side);
        }

        public void Move(double x, double y)
        {
            l.SetX(x);
            l.SetY(y);
        }

        public void Scale(int factor)
        {
            l.SetSide(l.GetSide() * factor);
        }

        public string ToString()
        {
            return "Corner ({0}, {1}),";
        }
    }
}
