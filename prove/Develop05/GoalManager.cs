using System;

public class GoalManager
{
    // Attributes
    private List<string> _goals = new List<string>();
    // private int _score;

    // Constructors
    public GoalManager()
    {

    }

    // Getters and Setters

    // Methods
    public void Start()
    {
        bool continueMainMenu = true;
        while (continueMainMenu)
        {
            // Clear and write menu
            Console.Clear();
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please a select an option: ");

            // Selector
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                CreateGoal();
                break;

                case 2:
                ListGoalDetails();
                break;
                
                case 3:
                Console.WriteLine("What is the name for the file? ");
                string savefile = Console.ReadLine();
                SaveGoals(savefile);
                break;

                case 4:
                Console.WriteLine("What is the name for the file? ");
                string loadfile = Console.ReadLine();
                LoadGoals(loadfile);
                break;

                case 5:
                RecordEvent();
                break;
                
                case 6:
                continueMainMenu = false;
                break;

                default:
                Console.WriteLine("Invalid option");
                break;
                
            }
        }
    }  
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nList of Goals:\n");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet. Create some to get started!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("The goals are:\n");
            // Iterate through each goal and display its name
            int goalNumber = 1;
            foreach (string goal in _goals)
            {
                // Extract the goal name from the string
                string[] parts = goal.Split('|');
                string goalName = parts[1].Trim(); 
                string goalDescription = parts[2].Trim(); 


                Console.WriteLine($"{goalNumber}. [ ] {goalName} ({goalDescription})");
                goalNumber++;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            
        }
    }
    public void CreateGoal()
    {
        bool continueGoalMenu = true;
        while (continueGoalMenu)
        {
            // Clear and write menu
            Console.Clear();
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.WriteLine("What type of goal do you want to work on? ");

            // Selector
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                // Get info from user
                Console.Clear();
                Console.WriteLine("What is the name of your goal?");
                string simpleName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string simpleDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                string simplePoints = Console.ReadLine();
                // Add goal to list
                string simpleGoal = $"Simple goal: | {simpleName} | {simpleDescription} | {simplePoints} | False";
                _goals.Add(simpleGoal);
                continueGoalMenu = false;
                break;

                case 2:
                // Get info from user
                Console.Clear();
                Console.WriteLine("What is the name of your goal?");
                string eternalName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string eternalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                string eternalPoints = Console.ReadLine();
                // Add goal to list
                string eternalGoal = $"Eternal goal: | {eternalName} | {eternalDescription} | {eternalPoints}";
                _goals.Add(eternalGoal);
                continueGoalMenu = false;
                break;
                
                case 3:
                // Get info from user
                Console.Clear();
                Console.WriteLine("What is the name of your goal?");
                string checklistName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string checklistDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                string checklistPoints = Console.ReadLine();
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                string checklistAttempts = Console.ReadLine();
                Console.WriteLine("What is the bonus for accomplishing this goal");
                string checklistBonusPoints = Console.ReadLine();
                // Add goal to list
                string checklistGoal = $"Checklist goal: | {checklistName} | {checklistDescription} | {checklistPoints} | {checklistBonusPoints} | {checklistAttempts}";
                _goals.Add(checklistGoal);
                continueGoalMenu = false;
                break;

                default:
                Console.WriteLine("Invalid option");
                break;
                
            }
        }
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals(string file)
    {
        string fileName = $"{file}.txt";
         // Open the file for writing
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            // Write each goal in the list to a separate line
            foreach (string goal in _goals)
            {
                writer.WriteLine(goal);
            }
        Console.WriteLine("Goals saved successfully to {0}", fileName);
        }
    }
    public void LoadGoals(string file)
    {
        string fileName = $"{file}.txt";
        _goals.Clear();
        using StreamReader reader = new StreamReader(fileName);
        string line;

        while ((line = reader.ReadLine()) !=null)
        {
            _goals.Add(line);
        }
    }
}