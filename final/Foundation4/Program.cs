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
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Sample");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please a select an option: ");

            // Selector
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                Running run =  new Running();
                run.NewActivity();
                break;

                case 2:
                Cycle cycle =  new Cycle();
                cycle.NewActivity();
                break;
                
                case 3:
                Swimming swimming =  new Swimming();
                swimming.NewActivity();
                break;

                case 4:
                Sample activity = new Sample();
                activity.Example();
                Console.WriteLine("\n\nPress any button to continue.");
                Console.ReadKey();
                break;
                
                case 5:
                continueProgram = false;
                break;

                default:
                Console.WriteLine("Invalid option");
                break;
                
            }
        }
        
        
    }
}