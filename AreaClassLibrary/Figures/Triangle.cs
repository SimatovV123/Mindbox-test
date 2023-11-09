using System;
using System.Linq;

namespace AreaClassLibrary.Figures
{

    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        /// <summary>
        /// Create Triangle instance
        /// </summary>
        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of a triangle</param>
        /// <param name="c">C side length of a triangle</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Provided side length is not a positive double");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Get triangle perimeter
        /// </summary>
        public double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }

        /// <summary>
        /// Indicates whether triangle is rectangular
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                var max = new double[] { A, B, C }.Max();
                var maxSqr = max * max;

                return maxSqr + maxSqr == A * A + B * B + C * C;
            }
        }

        /// <summary>
        /// Get triangle area
        /// </summary>
        public override double CalculateSquare()
        {
            var p = Perimeter/2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
