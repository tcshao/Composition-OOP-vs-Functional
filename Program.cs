using System;

namespace Geometry
{
    class Program
    {
        static void Main()
        {
            var circle = new Circle(4.0f);
            Console.WriteLine("Area of a circle with a 4.0 radius is {0}", circle.GetArea());

            var rectangle = new Rectangle(7.0, 2.0);
            Console.WriteLine("Area of a rectangle with 7.0 Height and 2.0 Width is {0}", rectangle.GetArea());

            var equilateralTriangle = new EquilateralTriangle(4.5);
            Console.WriteLine("Area of an equilateral triangle with a 4.5 long side is {0}", equilateralTriangle.GetArea());

            var square = new Square(5.0);
            Console.WriteLine("Area of a square with 5.0 long sides is {0}", square.GetArea());

            Console.ReadKey();
        }
    }
}
