public class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    public ScriptureReference(string reference)
    {
        ParseReference(reference);
    }

    private void ParseReference(string reference)
    {
        string[] parts = reference.Split(':');
        Book = parts[0];
        string[] chapterVerse = parts[1].Split('-');
        Chapter = int.Parse(chapterVerse[0]);
        StartVerse = int.Parse(chapterVerse[1]);
        if (chapterVerse.Length == 1)
            EndVerse = int.Parse(chapterVerse[1]);
    }
}
