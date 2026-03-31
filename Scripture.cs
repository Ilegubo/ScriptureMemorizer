namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word strWord = new Word(word);
            _words.Add(strWord);
        }
    }

    public void HideRandomWords(/*int numberToHide*/)
    {
        int randint = GenerateRandom();
        while (_words[randint].IsHidden())
        {
            randint = GenerateRandom();
        }

        _words[randint].Hide();
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

    public int GenerateRandom()
    {
        Random random = new Random();
        int randint = random.Next(0, _words.Count);
        return randint;
    }
}