using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries = new List<Entry>();


    public void AddEntry()
    {
        Prompt _userInput = new Prompt(); 
        _userInput.getRandomPrompt();
        string _content = Console.ReadLine();
        Console.WriteLine("Your daily progress has been recorded.");
        Entry _entry = new Entry(_content);
        _entries.Add(_entry);
    } 
    public void SaveEntry()
    {
        using (StreamWriter _outputFile = new StreamWriter("myJournal"))
        {
            foreach (Entry entry in _entries)
            {
            _outputFile.WriteLine(entry.SaveString());

            }
            

        }

    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Nothing here.");
        }
        else
        {

            Console.WriteLine("Current Entries");
            foreach (Entry _entry in _entries)
            {
                _entry.Display();
            }
        }
    }
    public void LoadEntries()
    {  
        string _filename = "myJournal";
        string[] _lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in _lines)
        {
            string[] parts = line.Split("|");

            DateTime _date = DateTime.Parse(parts[0]);
            
            string _content = parts[1];
            Entry entry = new Entry(_content,_date);  
            _entries.Add(entry);      
        }
    }



}   