
using System;

Fraction fraction1 = new Fraction();
Fraction fraction2 = new Fraction(5);
Fraction fraction3 = new Fraction(3, 4);
Fraction fraction4 = new Fraction(1, 3);

Console.WriteLine(fraction1.GetFractionString());
Console.WriteLine(fraction1.GetDecimalValue());

Console.WriteLine(fraction2.GetFractionString());
Console.WriteLine(fraction2.GetDecimalValue());

Console.WriteLine(fraction3.GetFractionString());
Console.WriteLine(fraction3.GetDecimalValue());

Console.WriteLine(fraction4.GetFractionString());
Console.WriteLine(fraction4.GetDecimalValue());


Console.WriteLine("\nTesting Getters and Setters:");

Fraction fraction5 = new Fraction(2, 3);

Console.WriteLine($"Original: {fraction5.GetFractionString()}");

// Change the numerator and denominator
fraction5.SetTop(7);
fraction5.SetBottom(8);

// Retrieve the updated values
Console.WriteLine($"Top: {fraction5.GetTop()}");
Console.WriteLine($"Bottom: {fraction5.GetBottom()}");

Console.WriteLine($"Updated: {fraction5.GetFractionString()}");
Console.WriteLine($"Decimal: {fraction5.GetDecimalValue()}");
