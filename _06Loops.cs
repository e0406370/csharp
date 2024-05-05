using System;

class _06Loops
{

  public static void ForLoop()
  {

    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine(i);
    }

    for (int i = 10; i >= 0; i--)
    {
      Console.WriteLine(i);
    }

    string[] names = ["Alex", "Eddie", "David", "Michael"];
    for (int i = names.Length - 1; i >= 0; i--)
    {
      Console.WriteLine(names[i]);
    }
  }

  public static void ForEachLoop()
  {
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = 0; i < names.Length; i++)
    {
      if (names[i] == "David")
      {
        names[i] = "Sammy";
      }
    }
    foreach (var name in names)
    {
      Console.WriteLine(name);
    }
  }

  public static void FizzBuzz()
  {
    for (int i = 1; i <= 100; i++)
    {
      Console.WriteLine(ReturnFizzBuzz(i));
    }
  }

  private static string ReturnFizzBuzz(int n)
  {
    bool isDivisibleBy3 = (n % 3 == 0);
    bool isDivisibleBy5 = (n % 5 == 0);
    int condition = (isDivisibleBy3 ? 1 : 0) + (isDivisibleBy5 ? 2 : 0);

    return condition switch
    {
      1 => $"{n} - Fizz",
      2 => $"{n} - Buzz",
      3 => $"{n} - FizzBuzz",
      _ => $"{n}",
    };
  }
}