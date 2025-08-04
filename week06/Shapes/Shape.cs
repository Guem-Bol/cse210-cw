// Shape.cs
using System;

public abstract class Shape
{
    // A protected member to store the color of the shape
    protected string _color;

    // A constructor that takes a color
    public Shape(string color)
    {
        _color = color;
    }

    // A getter for the color
    public string GetColor()
    {
        return _color;
    }

    // An abstract method for calculating area.
    // This method has no implementation here; it must be implemented by derived classes.
    public abstract double GetArea();
}