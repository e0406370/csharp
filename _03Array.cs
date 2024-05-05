using System;

class _03Array

{
  public static void Array()
  {
    string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
    Console.WriteLine(fraudulentOrderIDs.Length);

    string[] names = ["Rowena", "Robin", "Bao"];
    foreach (string name in names)
    {
      Console.WriteLine(name);

      if (name.StartsWith('R'))
      {
        Console.WriteLine($"The name {name} starts with 'B'!");
      }
    }
  }
}