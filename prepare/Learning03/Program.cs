using System;

public class Fraction
{
    private int numberator;
    private int denominator;

    public Fraction()
    {
        numberator = 1;
        denominator = 1;
    }

    public Fraction(int interger)
    {
        numberator = interger;
        denominator = 1;
    }

    public Fraction(int up, int down)
    {
        numberator = up;
        denominator = down;
    }

    public string GetFractionString()
    {
        string text = $"{numberator}/{denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)numberator / (double)denominator;
    }
}