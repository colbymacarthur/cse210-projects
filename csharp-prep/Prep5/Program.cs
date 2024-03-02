using System;

class Program
{
    // main function
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResults(userName, square);
    }

    // Additional functions to called in MAIN()
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to CSE210");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your user number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResults(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }
    
}