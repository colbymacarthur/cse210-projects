using System;
using System.Security.Cryptography.X509Certificates;

public static  class PromptGenerator
{
    public static List<string> _prompts = new List<string>() 
    {
        "What positive quality or value can you focus on today?",
        "Did you achieve your goals today?",
        "Check in with your body-how is it feeling today?",
        "What are the positives of your day?",
        "An inspirational thought or theme for tomorrow.",
        "What can you do today to take care of yourself and your needs, even just for a little while?"
        // ... other prompts
    };

    public static string GetRandomPrompt() // Public method to get random prompt
    {
        Random random = new Random();
        int listCount = _prompts.Count;
        int randomIndex = random.Next(listCount);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    
}
