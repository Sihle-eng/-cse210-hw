using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Square square = new Square("red", 5.8);
        // Console.WriteLine(square.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("green", 3.4));
        shapes.Add(new Rectangle("blue", 2.5, 4.0));
        shapes.Add(new Square("orange", 3.5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }

    }
}