public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 0;
        _bottom = 0;

    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return GetTop();
    }

    public int SetTop(int top)
    {
        return SetTop(top);
    }
    public int GetBottom()
    {
        return GetBottom();
    }

    public int SetBottom(int bottom)
    {
        return SetBottom(bottom);
    }

     public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}







