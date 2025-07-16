using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
        Fraction f = new Fraction();
        f.SetTop(1);
        f.SetBottom(3);

        Console.WriteLine(f.GetTop());
        Console.WriteLine(f.GetBottom());
        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f.GetFractionString());

    }
}