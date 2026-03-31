namespace ScriptureMemorizer;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
        Console.Write(string.Join("*", new string[_text.Length]));
    }

    public void show()
    {
        _isHidden = false;
        Console.WriteLine(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        return _text;
    }
    
}