using System.IO.Pipelines;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(' ');

        foreach(string word in parts)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

     public string GetDisplayText()
    {        
        List<string> wordsScripture = new List<string>();

        foreach(Word word in _words)
        {
            wordsScripture.Add(word.GetDisplayText());
        }

        string scripture = string.Join(' ', wordsScripture);

        return _reference.GetDisplayText() + " " + scripture;
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0; i < numberToHide; i++)
        {            
            int randomIndex = _random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }   

    public bool IsCompletelyHidden()
    {
       foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}