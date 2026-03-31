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
            int randint = _random.Next(0, _words.Count);
            while (_words[randint].IsHidden())
            {
                randint = _random.Next(0, _words.Count);
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

    public float Mastery()
    {
        int mastery = 0;
        foreach (Word word in _words)
        {
            if (!(word.IsHidden()))
            {
                mastery += 1;
                
            }
        }
        int length = _words.Count;
        float percentage = (float)mastery / length;
        if ((float)mastery/length <= 0.5)
        {
            Console.WriteLine("Matery : 🟥🟥🟥");
        }
        else if ((float)mastery / length < 1)
        {
            Console.WriteLine("Mastery: 🟨🟨🟨");
        }
        else
        {
            Console.WriteLine("Mastery: 🟩🟩🟩");
        }

        return (float)percentage * 100;
    }
    
}