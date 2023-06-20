public class Fraction
{
    private int _top;
    private int _botttom;

    public Fraction()
    {
        _top     = 1;
        _botttom = 1;

    }

    public Fraction(int wholeNumber)
    {
        _top      = wholeNumber;
        _botttom  = 1;

    }
    public Fraction(int top, int bottom)
    {
        _top     = top;
        _botttom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_botttom}";
        return text;

    }
    public double GetFractionDecimal()
    {
        return (double)_top / (double) _botttom;
    }

}