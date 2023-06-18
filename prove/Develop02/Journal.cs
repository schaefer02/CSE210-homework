public class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }

    }

    public void SaveToFile(string _file)
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            string entryAsCSV = $"{entry.date}|{entry.promptText}|{entry.entryText}";
            records.Add(entryAsCSV);
        }

        File.WriteAllLines(_file, records);

        
    }

    public void LoadFromFile(string file)
    {
        List<string> records = File.ReadAllLines(file).ToList();
        foreach (string record in records)
        {
            string[] splitstring =record.Split("|");
            Entry entry = new Entry(splitstring[0], splitstring[1], splitstring[2]);

            entries.Add(entry);
        }

    }

}