using System;

public class Comment
{
    // Attributes
    private string _commentorName;
    private string _comment;
    private List<string> _commentData = new List<string>();
    private int __videoID;

    // Constructors

    // Methods
    public void LoadCommentData(int videoID)
    {
        string fileName = "CommentData.txt";
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line; 

                while ((line = reader.ReadLine()) != null)
                {
                    _commentData.Add(line);
                }
                int commentCounter = 0;
                foreach (string i in _commentData)
                {
                    string[] parts = i.Split('|');
                    __videoID = int.Parse(parts[0].Trim());
                    _comment = parts[1].Trim(); 
                    _commentorName = parts[2].Trim();

                    if (__videoID == videoID)
                    {
                        commentCounter ++;
                        Console.WriteLine($"{_comment} by {_commentorName}");           
                    } 
                }
                Console.WriteLine($"{commentCounter} comment(s)\n");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Video data file not found!");
        }
    }
}