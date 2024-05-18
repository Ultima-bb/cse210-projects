using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();


    public void AddEntry()
    {
        Prompt userInput = new Prompt(); 
        userInput.getRandomPrompt();
        string content = Console.ReadLine();
        Console.WriteLine("Your daily progress has been recorded.");
        Entry entry = new Entry(content);
        entries.Add(entry);
    } 
    public void SaveEntry()
    {
        using (StreamWriter outputFile = new StreamWriter("myJournal"))
        {
            foreach (Entry entry in entries)
            {
            outputFile.WriteLine(entry.SaveString());

            }
            

        }

    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Nothing here.");
        }
        else
        {

            Console.WriteLine("Current Entries");
            foreach (Entry entry in entries)
            {
                entry.Display();
            }
        }
    }
    public void LoadEntries()
    {  
        string filename = "myJournal";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            DateTime Date = DateTime.Parse(parts[0]);
            
            string Content = parts[1];
            Entry entry = new Entry(Content,Date);  
            entries.Add(entry);      
        }
    }



}   