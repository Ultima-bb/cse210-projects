using System;
using System.Xml;
using System.Xml.Linq;


class Entry 
{
    
    public string Content {get;}
    public DateTime Date {get;}
    public Entry(string content)

    {
        Content = content;
        Date = DateTime.Now;
    }
    public Entry(string content, DateTime date)

    {
        Content = content;
        Date = date;
    }
    public void Display()
    {
        Console.WriteLine($"Date:{Date}");
        Console.WriteLine($"Content: {Content}");
    }
    
    public string SaveString()
    {
        return $"{Date}|{Content}"; 
    }

}