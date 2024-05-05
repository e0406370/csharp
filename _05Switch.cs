using System;

class _05Switch
{

  public static void EmployeeInfo()
  {
    string employeeName = "John Smith";

    int employeeLevel = 200;
    string title = employeeLevel switch
    {
      100 => "Junior Associate",
      200 => "Senior Associate",
      300 => "Manager",
      400 => "Senior Manager",
      _ => "Associate",
    };

    Console.WriteLine($"{employeeName}, {title}");
  }

  public static void StockInfo()
  {
    // SKU = Stock Keeping Unit
    string sku = "01-MN-L";

    string[] product = sku.Split('-');

    string type = "";
    string color = "";
    string size = "";

    switch (product[0])
    {
      case "01":
        type = "Sweat shirt";
        break;
      case "02":
        type = "T-Shirt";
        break;
      case "03":
        type = "Sweat pants";
        break;
      default:
        type = "Other";
        break;
    }

    switch (product[1])
    {
      case "BL":
        color = "Black";
        break;
      case "MN":
        color = "Maroon";
        break;
      default:
        color = "White";
        break;
    }

    switch (product[2])
    {
      case "S":
        size = "Small";
        break;
      case "M":
        size = "Medium";
        break;
      case "L":
        size = "Large";
        break;
      default:
        size = "One Size Fits All";
        break;
    }

    Console.WriteLine($"Product: {size} {color} {type}");
  }
}