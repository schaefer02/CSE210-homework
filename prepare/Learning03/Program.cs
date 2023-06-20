using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetFractionDecimal());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetFractionDecimal());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetFractionDecimal());

        Fraction frac4 = new Fraction(1, 4);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetFractionDecimal());

        
    }
}