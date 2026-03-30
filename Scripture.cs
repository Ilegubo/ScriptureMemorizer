namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        _words.RemoveAt(random.Next(0,_words.Count));
        _words.RemoveAt(random.Next(0, _words.Count));
    }

    public string GetDisplayText()
    {
        string words = "";
        foreach (Word word in _words)
        {
            words += word.GetDisplayText();
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