using ConsoleExercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        //        // This is a comment

        //        // The following line prints "Hello, World!" to the console

        //        // The method WriteHelloWorld is called to perform the action

        //        // The method is defined below

        //        // The method is called to execute the code

        //        // The method is defined to print "Hello, World!" to the console

        //        bool isActive = true; // This is a boolean variable declaration

        //        int number = 42; // This is a variable declaration

        //        float pi = 3.14f; // This is a floating-point variable declaration

        //        double result = 3.14159; // This is a double variable declaration

        //        decimal price = 19.99m; // This is a decimal variable declaration

        //        string name = "John Doe"; // This is a string variable declaration

        //        string greeting = $"Hello, {name}!"; // String interpolation

        //        string verbatimString = @"This is a verbatim string literal";

        //        string multiLineString = @"This is a
        //multi-line string
        //literal";

        //        char letter = 'A'; // This is a character variable declaration

        //        var isActiveVar = true; // Implicitly typed variable
        //        var numberVar = 42; // Implicitly typed variable
        //        var piVar = 3.14f; // Implicitly typed variable

        //        if (true)
        //        {

        //        }

        //        else if (false)
        //        {

        //        }

        //        else
        //        {

        //        }

        //        for (int i = 0; i < 10; i++)
        //        {

        //        }

        //        foreach (var item in new[] { 1, 2, 3 })
        //        {
        //            Console.WriteLine(item);
        //        }

        //        while (true)
        //        {
        //            break;
        //        }

        //        do
        //        {
        //            break;
        //        } while (true);

        //        switch (number)
        //        {
        //            case 1:
        //                Console.WriteLine("One");
        //                break;
        //            case 2:
        //                Console.WriteLine("Two");
        //                break;
        //            default:
        //                Console.WriteLine("Default case");
        //                break;
        //        }

        //        WriteHelloWorld();

        //        var pippo = new Class1();
        //        pippo.WriteStocazzo();
        //        Class1.WriteSticazzi();

        //Console.WriteLine("Hello, World!");

        //StrangeFizzBuzz();

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

        GuessNumber();
    }

    //private static void WriteHelloWorld()
    //{
    //    Console.WriteLine("Hello, World!");
    //}

    private static void StrangeFizzBuzz()
    {
        for (int i = 1; i <= 100; i++) 
        {

            var isMultipleOf7 = i % 7 == 0;
            var isPergectSquare = Math.Sqrt(i) % 1 == 0;

            string output = i.ToString();

            if (isMultipleOf7 && isPergectSquare) 
            {
                output = "paperone";
            }
            else if (isMultipleOf7)
            {
                output = "pippo";
            }
            else if (isPergectSquare)
            {
                output = "pluto";
            }

            Console.WriteLine(output);
        }

    }


    private static void GuessNumber()
    {
        Console.WriteLine("Indovina il numero da  1 a 10:");
        int randomNumber = new Random().Next(1, 11);

        while (true)
        {
;
            string? response = Console.ReadLine();
            int guessedNumber = 0;
            if (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("scrivi un numero!.");
                continue;
            }

            bool resultOfParse = int.TryParse(response, out guessedNumber);

            if (resultOfParse == false)
            {
                Console.WriteLine("scrivi un numero, non una stringa");
                continue;
            }

            bool hasGuessedCorrectly = guessedNumber == randomNumber;
            if (hasGuessedCorrectly)
            {
                Console.WriteLine("Bravo! Hai indovinato il numero!");
                break;
            }
            else
            {
                Console.WriteLine("Sbagliato! Riprova.");
                if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Il numero è più piccolo.");
                }
                else
                {
                    Console.WriteLine("Il numero è più grande.");
                }
            }
        }

    }
}