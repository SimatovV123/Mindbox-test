using SquareClassLibrary.Figures;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void CircleRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0.0));
        }

        [Test]
        public void CircleRadiusIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(- 1.0));
        }

        [Test]
        public void CircleSquareDeltaTest()
        {
            var circleSquare = new Circle(10).CalculateSquare();

            Assert.AreEqual(314.15926535897931, circleSquare, 1E-6);
        }

        [Test]
        public void TriangleSquareDeltaTest()
        {
            var triangleSquare = new Triangle(7, 24, 25).CalculateSquare();

            Assert.AreEqual(84, triangleSquare, 1E-6);
        }

        [Test]
        public void TriangleRectangularTest()
        {
            var isTriangleRectangular = new Triangle(7, 24, 25).IsRectangular(1E-6);

            Assert.AreEqual(true, isTriangleRectangular);
        }
    }
}