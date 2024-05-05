using System;

class _10String
{

  public static void HelperMethods01()
  {

    string message = "Find what is (inside the parentheses)";

    int openingPosition = message.IndexOf('(');
    int closingPosition = message.IndexOf(')');

    Console.WriteLine(openingPosition); // 13
    Console.WriteLine(closingPosition); // 36
    Console.WriteLine(message.Substring(openingPosition + 1, closingPosition - openingPosition - 1)); // inside the parentheses
  }

  /*
    Other methods:

    - LastIndexOf() 
    => returns the last position of a character or string inside of another string.

    - IndexOfAny() 
    => returns the first position of an array of char that occurs inside of another string.
  */

  public static void HelperMethods02()
  {

    string data = "12345John Smith          5000  3  ";
    string updatedData = data.Remove(5, 20);
    Console.WriteLine(updatedData); // 123455000  3

    string message = "This--is--ex-amp-le--da-ta";
    message = message.Replace("--", " ");
    message = message.Replace("-", "");
    Console.WriteLine(message); // This is example data
  }
}