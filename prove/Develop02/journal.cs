using System;
using System.IO;

public class Journal

{
    private List<Entry> _entries;

    public void AddEntry(Entry entry)
    {
        Console.ReadLine();
    }

    public static List<Entry> DisplayEntries()
    {
        Console.WriteLine("Reading from file list....");

    }

    public void SaveToFile(string userInput)

    {
        string filename = userInput + ".json";
        List<journalJsonEntry> _passage = new List<journalJsonEntry>();

        foreach ()
    }

    public void LoadFromFile()
    {

    }
}