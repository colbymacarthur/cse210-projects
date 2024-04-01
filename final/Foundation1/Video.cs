using System;

public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private string _length;
    private List<string> _videoData = new List<string>();
    private int __videoID;

    // Constructors
    public Video()
    {

    }

    // Methods
    public void LoadVideoData()
    {
        string fileName = "VideoData.txt";
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    _videoData.Add(line);
                }
                Console.Clear();
                Console.WriteLine("Data loaded successfully\n");
                foreach (string i in _videoData)
                {
                    string[] parts = i.Split('|');
                    __videoID = int.Parse(parts[0].Trim());
                    _title = parts[1].Trim(); 
                    _author = parts[2].Trim(); 
                    _length = parts[3].Trim(); 

                    Console.WriteLine($"'{_title}.' by {_author} ({_length} seconds long)");
                    Comment comments = new Comment();
                    comments.LoadCommentData(__videoID);
                }
                Console.WriteLine("");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Video data file not found!");
        }
    }
}