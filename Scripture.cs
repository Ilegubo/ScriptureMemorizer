namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word strWord = new Word(word);
            _words.Add(strWord);
        }
    }

    public void HideRandomWords()
    {
        if (!(IsCompletelyHidden()))
        {
            int randint = _random.Next(0, _words.Count+1);
            while (_words[randint].IsHidden())
            {
                randint = _random.Next(0, _words.Count + 1);
            }
    
            _words[randint].Hide();
        }

    }

    public string GetDisplayText()
    {
        string words = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            words += " " + word.GetDisplayText();
        }

        return words;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
    
}