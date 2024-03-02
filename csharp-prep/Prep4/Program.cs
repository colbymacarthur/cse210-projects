using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        List<int> numbers = new List<int>();

        // set variable to start loop
        int userNumber = -1;
        float sum = 0;
        int max = 0;

        while (userNumber != 0)
        {
            // Get input from user
            Console.Write("Please add number to list? (to end type 0) ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            // run if statement to add number 
            if ( userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            // Calculate 
            else 
            {
                foreach (int number in numbers)
                {
                    sum = number + sum;
                    if (number > max)
                    {
                        max = number;
                    }
                }
                float average = sum / numbers.Count;
                Console.WriteLine($"The total from the list is {sum}");
                Console.WriteLine($"The average from the list is {average}");
                Console.WriteLine($"The max from the list is {max}");


            }
        }
    }
}