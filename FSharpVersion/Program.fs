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
    
// calling this function
let circle = Circle(4.0)
printfn "Area of a circle that has radius of 4.0: %f" (area circle)

let rectangle = Rectangle(7.0, 2.0)
printfn "Area of a rectangle that has width of 7.0 and a height of 2.0 is %f" (area rectangle)

let triangle = EquilateralTriangle(4.5)
printfn "Area of an equilateral triangle with a 4.5 long side is %f" (area triangle)

let square = Square(5.0)
printfn "Area of a square with 5.0 long sides is %f" (area square)

