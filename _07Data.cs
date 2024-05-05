using System;

class _07Data
{

  public static void MinMax()
  {
    Console.WriteLine("Signed integral types:");
    Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}"); // -128 to 127
    Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}"); // -32768 to 32767
    Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}"); // -2147483648 to 2147483647
    Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}"); // -9223372036854775808 to 9223372036854775807

    Console.WriteLine("");
    Console.WriteLine("Unsigned integral types:");
    Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}"); // 0 to 255
    Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}"); // 0 to 65535
    Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}"); // 0 to 4294967295
    Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}"); // 0 to 18446744073709551615

    Console.WriteLine("");
    Console.WriteLine("Floating point types:");
    Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
    Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
    Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
  }

  public static void Data()
  {
    int[] ref_A = [2];

    int[] ref_B = ref_A; // ref_B points to the same memory location as ref_A
    ref_B[0] = 5;

    Console.WriteLine("--Reference Types--");
    Console.WriteLine($"ref_A[0]: {ref_A[0]}"); // 5
    Console.WriteLine($"ref_B[0]: {ref_B[0]}"); // 5
  }

  /*
    For simplicity's sake you should prefer a subset of basic data types, including:
    int for most whole numbers
    decimal for numbers representing money
    bool for true or false values
    string for alphanumeric value
  */

  /*
    The following examples identify where a specific .NET data types can be useful:
    byte: working with encoded data that comes from other computer systems or using different character sets.
    double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
    System.DateTime for a specific date and time value.
    System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
  */

  public static void Cast01() // implicit conversion -> widening conversion (small -> large)
  {
    int myInt = 3;
    Console.WriteLine($"int: {myInt}"); // 3

    decimal myDecimal = myInt;
    Console.WriteLine($"decimal: {myDecimal}"); // 3
  }

  public static void Cast02() // explicit conversion -> narrowing conversion (large -> small)
  {
    decimal myDecimal = 3.14m;
    Console.WriteLine($"decimal: {myDecimal}"); // 3.14

    int myInt = (int)myDecimal;
    Console.WriteLine($"int: {myInt}"); // 3
  }

  public static void Convert01()
  {
    int first = 5;
    int second = 7;
    string message = first.ToString() + second.ToString();
    Console.WriteLine(message); // 57
  }

  public static void Convert02()
  {
    string first = "5";
    string second = "7";
    int sum = int.Parse(first) + int.Parse(second);
    Console.WriteLine(sum); //12
  }

  public static void Convert03()
  {
    int value = (int)1.5m; // casting truncates => rounds down 
    Console.WriteLine(value); // 1

    int value2 = Convert.ToInt32(1.5m); // converting => rounds up
    Console.WriteLine(value2); // 2
  }

  public static void Convert04()
  {
    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    decimal total = 0m;
    string message = "";

    foreach (var value in values)
    {
      decimal number; // stores the TryParse "out" value
      if (decimal.TryParse(value, out number))
      {
        total += number;
      }
      else
      {
        message += value;
      }
    }

    Console.WriteLine($"Message: {message}"); // ABCDEF
    Console.WriteLine($"Total: {total}"); // 68.3
  }

  public static void Convert05()
  {
    int value1 = 11;
    decimal value2 = 6.2m;
    float value3 = 4.3f;

    int result1 = Convert.ToInt32(value1 / value2);
    Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}"); // 2

    decimal result2 = value2 / (decimal)value3;
    Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}"); // 1.4418604651162790697674418605

    float result3 = value3 / value1;
    Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); // 0.3909091
  }
}