using System;

namespace Geometry
{
    public interface IShape
    {
        dynamic GetArea();
    }

    public class Circle : IShape
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public dynamic GetArea()
        {
            return Math.PI*Radius*Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public dynamic GetArea()
        {
            return Height*Width;
        }
    }

    public class EquilateralTriangle : IShape
    {
        public double Side { get; set; }

        public EquilateralTriangle(double side)
        {
            Side = side;
        }

        public dynamic GetArea()
        {
            return ((Math.Sqrt(3))/4.0*Side*Side);
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public dynamic GetArea()
        {
            return Side*Side;
        }
    }
}
