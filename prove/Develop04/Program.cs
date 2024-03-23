using System;

class Program
{    
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            // Clear and write menu
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please a select an option: ");

            // Selector
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                BreathingActivity br = new BreathingActivity();
                br.Run();
                break;

                case 2:
                ReflectingActivity re = new ReflectingActivity();
                re.Run();
                break;
                
                case 3:
                ListingActivity li = new ListingActivity();
                li.Run();
                break;
                
                case 4:
                Activity.DisplayEndingMessage();
                continueProgram = false;
                break;

                default:
                Console.WriteLine("Invalid option");
                break;
                
            }
        }
    }
}