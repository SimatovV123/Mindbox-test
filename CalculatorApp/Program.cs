using SquareClassLibrary.Figures;
using System;

namespace ZadanieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle(1);
            Triangle triangleRect = new Triangle(7, 24, 25);
            Triangle triangle = new Triangle(10, 24, 25);

            Console.WriteLine(triangleRect.IsRectangular(1E-6));
            Console.WriteLine(triangle.IsRectangular(1E-6));

            var figures = new[] { circle, triangleRect, triangle };

            //вычисляем площадь без знания типа фигуры в compile-time
            foreach(Figure figure in figures)
            {
                Console.WriteLine(figure.CalculateSquare());
            }
            Console.Read();
        }
    }
}
