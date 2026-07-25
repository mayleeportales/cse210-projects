public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {

        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        
    }

    public void Display()
    {
       Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n{_entryText}");
        
    }

    public string GetSaveString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }
}