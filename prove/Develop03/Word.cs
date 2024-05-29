public class Word
{
    public string Text { get; private set; }
    public bool hideThis { get; set; }

    public Word(string text)
    {
        Text = text;
        hideThis = false;
    }
}