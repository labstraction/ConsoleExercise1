using ConsoleExercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        // This is a comment

        // The following line prints "Hello, World!" to the console

        // The method WriteHelloWorld is called to perform the action

        // The method is defined below

        // The method is called to execute the code

        // The method is defined to print "Hello, World!" to the console

        bool isActive = true; // This is a boolean variable declaration

        int number = 42; // This is a variable declaration

        float pi = 3.14f; // This is a floating-point variable declaration

        double result = 3.14159; // This is a double variable declaration

        decimal price = 19.99m; // This is a decimal variable declaration

        string name = "John Doe"; // This is a string variable declaration

        string greeting = $"Hello, {name}!"; // String interpolation

        string verbatimString = @"This is a verbatim string literal";

        string multiLineString = @"This is a
multi-line string
literal";

        char letter = 'A'; // This is a character variable declaration

        var isActiveVar = true; // Implicitly typed variable
        var numberVar = 42; // Implicitly typed variable
        var piVar = 3.14f; // Implicitly typed variable

        if (true)
        {
            
        }

        else if (false)
        {

        }

        else
        {
            
        }

        for (int i = 0; i < 10; i++)
        {
            
        }

        foreach (var item in new[] { 1, 2, 3 })
        {
            Console.WriteLine(item);
        }

        while (true)
        {
            break;
        }

        do
        {
            break;
        } while (true);

        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }

        WriteHelloWorld();
        
        var class1 = new Class1();
        class1.WriteStocazzo();
    }

    private static void WriteHelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }
}