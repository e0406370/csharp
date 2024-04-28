class _01Intro

{
  public static void Intro()
  {
    Console.WriteLine("Hello, World!");
    Console.Write("You wrote your first lines of code.");

    // Console -> class
    // WriteLine, Write -> methods
    // use "double quotes" to produce string literals 
    // use 'single quotes' to produce char literals 

    Console.WriteLine("Hello"); // string
    Console.WriteLine('b'); // char
    Console.WriteLine(123); // int
    Console.WriteLine(0.25F); // float ~6-9 digits precision
    Console.WriteLine(2.625); // double ~15-17 digits precision 
    Console.WriteLine(12.39816m); // decimal 28-29 digits precision || Decimal values include the values after the decimal point when displayed.
    Console.WriteLine(true); // boolean
    Console.WriteLine(false); // boolean

    // naming variables - use camel case
    string firstName;
    char userOption;
    int gameScore;
    float temperatureValue;
    double distanceTravelled;
    decimal particlesPerMillion;
    bool processedCustomer;

    string lastName = "Bob";
    Console.WriteLine(lastName);

    // implicit variable; MUST be initialised
    /*
      The var keyword tells the C# compiler that the data type is implied by the assigned value. 
      After the type is implied, the variable acts the same as if the actual data type had been used to declare it. 
      The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.
    */
    var message = "Hello World";
    Console.WriteLine(message);

    // using string interpolation (similar to Javascript but no need to use backticks)
    string user = "Bob";
    int messages = 3;
    double temperature = 34.4;
    Console.Write($"Hello, {user}! You have {messages} in your inbox. The temperature is {temperature} celsius.");

    // escape character sequences
    Console.WriteLine("Hello\nWorld!"); // \n => new line
    Console.WriteLine("Hello\tWorld!"); // \t => tab
    Console.WriteLine("Hello \"World\"!"); // if need to use quotation marks internally
    Console.WriteLine("c:\\source\\repos"); // to display single backslash
    Console.Write(@"c:\invoices"); // verbatim string literals; can use unescaped \ character
    Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t"); // unicode characters
    Console.WriteLine();

    // using 1.string interpolation with 2.verbatim string literals
    string projectName = "ACME";
    string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
    Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

    string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
    string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
    Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

    // different order
    int value1 = 3 + 4 * 5;
    int value2 = (3 + 4) * 5;
    Console.WriteLine(value1);
    Console.WriteLine(value2);

    // formatting decimals
    int fahrenheit = 94;
    decimal celsius = (fahrenheit - 32m) * (5m / 9m);
    Console.WriteLine($"The temperature is {celsius:#.#} Celsius.");

    // array functions
    int[] sophiaGrades = [93, 87, 98, 95, 100];
    Console.WriteLine($"The sum of Sophia's grades is {sophiaGrades.Sum()}.");
    Console.WriteLine($"The average of Sophia's grades is {sophiaGrades.Average()}.");

    // declare constants
    const int gradeA = 5;
    const int gradeB = 4;
    const int gradeC = 3;
  }
}
