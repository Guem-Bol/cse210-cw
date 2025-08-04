// Rectangle.cs

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // The constructor calls the base class constructor with the color
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // This method provides the specific implementation for a rectangle's area.
    public override double GetArea()
    {
        return _length * _width;
    }
}