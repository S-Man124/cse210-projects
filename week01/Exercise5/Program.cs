
using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Calculate the square of the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Function 3: Ask for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        return number;
    }

    // Function 4: Calculate and return the square
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    // Function 5: Display the final result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
