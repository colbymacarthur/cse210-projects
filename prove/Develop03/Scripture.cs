using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>(); 
    private Reference _reference; 
    private HashSet<int> _hiddenIndexes = new HashSet<int>(); 

    public Scripture(Reference reference, string scripture)
    {
        this._reference = reference;

        foreach (string word in scripture.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    

    public void HideRandomWords()
    {
        Random random = new Random();
        int randomIndex;

        do
        {
            randomIndex = random.Next(0, _words.Count);
        } while (!_hiddenIndexes.Add(randomIndex)); 
        _words[randomIndex].Hide();
    }

    public bool IsCompletelyHidden() => _hiddenIndexes.Count == _words.Count; 
}
