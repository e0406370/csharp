using System;

class _09Format
{

  public static void StringFormatting()
  {
    string first = "Hello";
    string second = "World";

    // composite formatting
    string result = string.Format("{0} {1}!", first, second);
    Console.WriteLine(result);
    Console.WriteLine("{1} {0}!", first, second);
    Console.WriteLine("{0} {0} {0}!", first, second);

    // string interpolation (recommended)
    Console.WriteLine($"{first} {second}!");
    Console.WriteLine($"{second} {first}!");
    Console.WriteLine($"{first} {first} {first}!");

    // currency formatting
    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"Price: {price:C} (Save {discount:C})");

    // decimal formatting
    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N} units"); // 123,456.79 | by default 2 d.p.
    Console.WriteLine($"Measurement: {measurement:N4} units"); // 123,456.7891 | fixed to 4 d.p.

    // percentage formatting
    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}"); // 36.79 % || 2 decimal places
  }

  public static void Padding()
  {
    string input = "Pad this";
    Console.WriteLine(input.PadLeft(12)); //  	Pad this || add spaces from left until length is 12 chars long
    Console.WriteLine(input.PadLeft(12, '-')); //  ----Pad this
    Console.WriteLine(input.PadRight(12, '-')); //  Pad this----
  }
}