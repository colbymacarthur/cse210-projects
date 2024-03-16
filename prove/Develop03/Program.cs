using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureString1 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        string book1 = "1 Nephi";
        int chapter1 = 3;
        int verse1 = 7;

        // Create Scripture object
        Reference reference1 = new Reference(book1, chapter1, verse1);
        Scripture newScripture = new Scripture(reference1, scriptureString1);

        Console.Clear();

        // Display reference and scripture on separate lines
        Console.WriteLine(reference1.GetDisplayText());
        Console.WriteLine(newScripture.GetDisplayText());

        Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit:");

        string userInput = Console.ReadLine().ToLower();

        // Loop until user quits or all words are hidden
        while (userInput != "quit" && !newScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Random random = new Random();
            int numWordsToHide = random.Next(3, 10); 

            for (int i = 0; i < numWordsToHide; i++)
            {
                newScripture.HideRandomWords();
            }


            // Display reference and updated scripture
            Console.WriteLine(reference1.GetDisplayText());
            Console.WriteLine(newScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit:");
            userInput = Console.ReadLine().ToLower();
        }

        if (newScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Congratulations! All words are hidden.");
        }
    }
}
