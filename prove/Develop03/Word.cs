public class Word
{
    private string _text; 
    private string _originalText; 

    public Word(string text) 
    {
        this._text = text;
        _originalText = text;
    }

    public string GetText()
    { 
        return _text; 
    }
    public void Hide()
    {
        _text = new string('_', _text.Length); 
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
