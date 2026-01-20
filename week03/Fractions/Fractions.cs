public class Fraction
{
    private int _numerator;           //step 3
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;         //step 4
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;                       //step 4
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;           //step 4
    }
    public int GetNumerator()
    {
        return _numerator;                   //step 5
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public int GetDenominator()
    {
        return _denominator;               //step 5
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";         //step 5
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;              //step 5
    }
}
