using System;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile (string file){
        using(StreamWriter writetext = new StreamWriter(file)){
            writetext.Flush();
            foreach (Entry entry in _entries){
                writetext.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._dayRating}");
            }
        }
    }

    public void LoadFromFile (string file){
        var lines = File.ReadAllLines(file);
        List<string> loadedEntries = lines.ToList<string>();

        foreach (string entry in loadedEntries){
            Entry anEntry = new Entry();
            string[] entryVariables = entry.Split('|');
            anEntry._date = entryVariables[0];
            anEntry._promptText = entryVariables[1];
            anEntry._entryText = entryVariables[2];
            anEntry._dayRating = entryVariables[3];
            AddEntry(anEntry);

        }
    }
}