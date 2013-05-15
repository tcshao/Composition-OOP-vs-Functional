Composition-OOP-vs-Functional
=============================

This is a small example written in C# that has a simple composition using shapes, and computes the area for the given shape. There is an accompanying project in F# which does the same thing.

The purpose of this is to illustrate how functional techniques/languages cut away some of the ceremony involved in C#.

This is an example of the C# code

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
    // a seperate class is required implementing the IShape interface 

The given class structure and methods can be distilled into the following F#

	// Discriminated Union for the Shape type
	type Shape =
	    | Circle of float
	    | EquilateralTriangle of double
	    | Square of double
	    | Rectangle of double * double

	// declaring function to get the value of the area
	let area thisShape =
	    match thisShape with
	    | Circle radius -> System.Math.PI * radius * radius
	    | EquilateralTriangle side -> (sqrt 3.0) / 4.0 * side * side
	    | Square side -> side * side
	    | Rectangle (height, width) -> height * width