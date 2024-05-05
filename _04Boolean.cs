using System;

class _04Boolean
{

  public static void Boolean()
  {
    Console.WriteLine("a" == "a"); // True
    Console.WriteLine("a" == "A"); // False
    Console.WriteLine(1 != 2); // True

    string myValue = "a";
    Console.WriteLine(myValue == "a"); // True

    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // True

    string pangram = "The quick brown fox jumps over the lazy dog.";
    Console.WriteLine(pangram.Contains("fox")); // True
    Console.WriteLine(pangram.Contains("cow")); // False

    int saleAmount = 1001;
    int discount = (saleAmount > 1000) ? 100 : 50;
    Console.WriteLine($"Discount: {discount}"); // Discount: 100
  }

  public static void CoinFlip()
  {
    Random coin = new();
    int flip = coin.Next(0, 2); // [0, 2) => [0, 1]

    Console.WriteLine((flip == 0) ? "head" : "tails");
  }
}