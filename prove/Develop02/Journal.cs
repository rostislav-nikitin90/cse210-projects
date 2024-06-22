using System.Text;

namespace Develop02;

public class Journal
{
    private readonly List<Entry> _entries = new();
    private readonly PromptGenerator _promptGenerator = new();

    public void AddEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.Write($"{prompt}\n> ");
        string userEntryText = Console.ReadLine();
        Entry entry = new Entry(theCurrentTime, prompt, userEntryText);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {          
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();
        
        if (filename is { Length: > 0 })
        {
            StringBuilder outputFile = new StringBuilder();
            foreach (Entry entry in _entries)
            {
                outputFile.AppendLine(entry.PrepareString());
            }
            
            File.WriteAllText(filename, outputFile.ToString());
            return;
        }
        Console.WriteLine("Filename can't be null or empty. Please consider to provide a filename.");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();
        if (filename is { Length: > 0 })
        {
            if (_entries.Any( item => item != null) )
            {
                _entries.Clear();
            }

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                
                _entries.Add(new Entry(Entry.ConvertStringToDateTime(date), promptText, entryText));
            }
            return;
        }
        Console.WriteLine("Filename can't be null or empty. Please consider to provide a filename.");
    }
}