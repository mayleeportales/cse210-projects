using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {        
        using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach(Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.GetSaveString());            
                }
            }        
    }

    public void LoadFromFile(string file)
    {   

        string[] lines = System.IO.File.ReadAllLines(file);  
        _entries.Clear();

        foreach(string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry entry = new Entry(parts[0], parts[1], parts[2]);

            AddEntry(entry);
        }
    }
}