using System;

class _08ArrayOperations
{

  public static void SortArray()
  {
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Array.Sort(pallets);

    Console.WriteLine("Sorted...");
    foreach (var pallet in pallets)
    {
      Console.WriteLine($"-- {pallet}");
    }
  }

  public static void ReverseArray()
  {
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Array.Sort(pallets);
    Array.Reverse(pallets);

    Console.WriteLine("Reversed...");
    foreach (var pallet in pallets)
    {
      Console.WriteLine($"-- {pallet}");
    }
  }

  public static void ClearArray()
  {
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Array.Clear(pallets, 0, 2);

    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
      Console.WriteLine($"-- {pallet}");
    }
  }

  public static void JoinSplitArray()
  {
    string value = "abc123";
    char[] valueArray = value.ToCharArray();

    Array.Reverse(valueArray);

    // string result = new string(valueArray);
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);

    string[] items = result.Split(',');
    foreach (string item in items)
    {
      Console.WriteLine(item);
    }
  }

  public static void Challenge()
  {
    string pangram = "The quick brown fox jumps over the lazy dog";

    string[] message = pangram.Split(' ');
    string[] newMessage = new string[message.Length];

    for (int i = 0; i < message.Length; i++)
    {
      char[] letters = message[i].ToCharArray();
      Array.Reverse(letters);
      newMessage[i] = new string(letters);
    }

    string result = String.Join(" ", newMessage);
    Console.WriteLine(result); // ehT kciuq nworb xof spmuj revo eht yzal god
  }
}