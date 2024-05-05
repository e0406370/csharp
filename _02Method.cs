using System;

class _02Method

{
  public static int Roll()
  {
    Random dice = new();
    return dice.Next(1, 7);
  }

  public static void DisplayRandomNumbers()
  {
    Random random = new();

    for (int i = 0; i < 5; i++)
    {
      Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
  }

  public static void PrintCircleArea(int radius)
  {
    double pi = 3.14159;
    double area = pi * (radius * radius);

    Console.WriteLine($"Area of Circle = {area}");
  }

  public static void PrintEmailAddresses()
  {
    string[,] corporate =
    {
      {"Robert", "Bavin"}, {"Simon", "Bright"},
      {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
      {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

    string[,] external =
    {
      {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
      {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    string externalDomain = "hayworth.com";

    for (int i = 0; i < corporate.GetLength(0); i++)
    {
      DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
      DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
    }
  }

  private static void DisplayEmail(string first, string last, string domain = "contoso.com")
  {
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    
    Console.WriteLine($"{email}@{domain}");
  }
}
