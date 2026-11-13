
public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor 1: Default fraction 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Top number only
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Top and bottom numbers
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
