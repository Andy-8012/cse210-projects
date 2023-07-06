using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("pink", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle ("blue", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("red", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            Console.WriteLine($"Color:  {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }

        
    }
}