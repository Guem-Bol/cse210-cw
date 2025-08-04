using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<Shape> shapes = new List<Shape>();

        // Adding instances of different derived classes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Circle("Blue", 3));
        shapes.Add(new Rectangle("Green", 4, 6));

        Console.WriteLine("Shape Program");
        Console.WriteLine("-----------------------------------------");

        // Loop through the list of shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():F2}.");
        }
    }
}