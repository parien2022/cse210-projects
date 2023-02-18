using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();

        fraction.SetFraction();

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.setFraction2(5);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.setFraction3(6, 6);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction.setFraction3(1, 3);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        
    }
}