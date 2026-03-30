namespace ScriptureMemorizer;

public class Word
{
    private string _text;
    private bool _isHidden;

    public void Hide()
    {
        _isHidden = true;
        Console.Write((_text.Length)*"_");
    }

    public void show()
    {
        _isHidden = false;
        Console.WriteLine(_text);
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    
}