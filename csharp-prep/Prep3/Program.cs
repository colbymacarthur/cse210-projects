using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Random object to generate random numbers
        Random random = new Random();

        // Generate a random integer between 1 and 100
        int magicNumber = random.Next(1, 101);

        // set variable to start loop
        int userNumber = -1;

        int attempt = 0;

        // Start while loop to allow user to guess
        while (userNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userNumber = int.Parse(userGuess);

            // Increase attempts 
            attempt++;

            // If statement to check if guess is correct.
            if (magicNumber > userNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userNumber)
            {
                Console.WriteLine("Lower");
            }
            // User is correct and runs last statement before closing while loop.
            else if (magicNumber == userNumber)
            {
                Console.WriteLine($"Congratulations you guessed it. It took you {attempt} tries.");
            }
        }

        
    }
}