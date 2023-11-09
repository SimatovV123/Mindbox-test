using System;

namespace SquareClassLibrary.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Get circle radius
        /// </summary>
        public double Radius => _radius;

        /// <summary>
        /// Create Circle instance
        /// </summary>
        /// <param name="r">Radius</param>
        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new ArgumentException("Provided radius is not a positive double");
            }
            _radius = radius;
        }
        /// <summary>
        /// Get Circle Area
        /// </summary>
        public override double CalculateSquare()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
