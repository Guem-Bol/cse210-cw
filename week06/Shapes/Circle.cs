// Circle.cs
using System;

public class Circle : Shape
{
    private double _radius;

    // The constructor calls the base class constructor with the color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // This method is required because it's abstract in the base class.
    // It provides the specific implementation for calculating the area of a circle.
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}