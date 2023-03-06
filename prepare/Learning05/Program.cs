using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(7, "Green");
        //Console.WriteLine($"The square's color is {square.GetColor()} and area is {square.GetArea()}.");

        Rectangle rectangle = new Rectangle(7, 14, "Red");
        //Console.WriteLine($"The rectangle's color is {rectangle.GetColor()} and area is {rectangle.GetArea()}.");

        Circle circle = new Circle(7, "Blue");
        //Console.WriteLine($"The circle's color is {circle.GetColor()}and area is {circle.GetArea()}.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes){
            Console.WriteLine($"The shape's color is {shape.GetColor()} and area is {shape.GetArea()}.");
        }
    }
}