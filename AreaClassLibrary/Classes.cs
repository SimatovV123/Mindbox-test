using System;
using System.Linq;

namespace AreaClassLibrary
{
    public interface ISquare
    {
        public double Square();
    }
    public class Circle: ISquare
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Square()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Triangle: ISquare
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }
        public bool IsRectangular
        {
            get
            {
                var max = new double[] { A, B, C }.Max();
                var maxSqr = max * max;

                return maxSqr + maxSqr == A * A + B * B + C * C;
            }
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        
        public double Square()
        {
            var p = Perimeter;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
