using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
        Fraction fraction4 = new Fraction();
        fraction4.SetTop(4);
        fraction4.SetBottom(5);

        Console.WriteLine($"Fraction 1 Top {fraction1.GetTop()}");
        Console.WriteLine($"Fraction 1 Bottom {fraction1.GetBottom()}");
        Console.WriteLine($"Fraction 2 Top {fraction2.GetTop()}");
        Console.WriteLine($"Fraction 2 Bottom {fraction2.GetBottom()}");
        Console.WriteLine($"Fraction 3 Top {fraction3.GetTop()}");
        Console.WriteLine($"Fraction 3 Bottom {fraction3.GetBottom()}");
        Console.WriteLine($"Fraction 4 Top {fraction4.GetTop()}");
        Console.WriteLine($"Fraction 4 Bottom {fraction4.GetBottom()}");

        Console.WriteLine($"Fraction 1 {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction 1 {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2 {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 2 {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3 {fraction3.GetFractionString()}");
        Console.WriteLine($"Fraction 3 {fraction3.GetDecimalValue()}");
        Console.WriteLine($"Fraction 4 {fraction4.GetFractionString()}");
        Console.WriteLine($"Fraction 4 {fraction4.GetDecimalValue()}");
    }
}