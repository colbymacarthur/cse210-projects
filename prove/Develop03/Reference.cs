using System;

public class Reference
{
    private string _book { get; } 
    private int _chapter { get; }
    private int _verse { get; }
    private int _endVerse { get; }  

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse) : this(book, chapter, verse)
    {
        _endVerse = endVerse;
    }

    // Method 
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}