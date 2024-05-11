using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
public class Fraction
{
    private int _top;
    private int _botton;

    public Fraction ()
    {
        _top = 1;
        _botton = 1;

    }

    public Fraction (int denominator)
    {
        _top = denominator;//the denominator MUST BE 1.
        _botton = 1;
    }

    public Fraction (int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    public string GetFractionString()
    {
        string line = $"{_top}/{_botton}";
        return line;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
        
    }

}

