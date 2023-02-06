using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction();
        

        string fraction1String = fraction1.GetFractionString();
        double fraction1Double = fraction1.GetDecimalValue();

        Console.WriteLine(fraction1String);
        Console.WriteLine(fraction1Double);

        string fraction2String = fraction2.GetFractionString();
        double fraction2Double = fraction2.GetDecimalValue();

        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction2Double);

        string fraction3String = fraction3.GetFractionString();
        double fraction3Double = fraction3.GetDecimalValue();

        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction3Double);

        fraction4.SetTop(1);
        fraction4.SetBottom(3);

        Console.Write("Top: ");
        fraction4.GetTop();
        Console.Write("Bottom: ");
        fraction4.GetBottom();

        string fraction4String = fraction4.GetFractionString();
        double fraction4Double = fraction4.GetDecimalValue();

        
        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Double);
    }
}