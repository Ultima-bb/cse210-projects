public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string _commenterName, string _text)
    {
        CommenterName = _commenterName;
        Text = _text;
    }
}