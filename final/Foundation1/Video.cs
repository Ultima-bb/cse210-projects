public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string _title, string _author, int _lengthInSeconds)
    {
        Title = _title;
        Author = _author;
        LengthInSeconds = _lengthInSeconds;
    }

    public void AddComment(string _commenterName, string text)
    {
        Comment comment = new Comment(_commenterName, text);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void PrintVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var _comment in _comments)
        {
            Console.WriteLine($"- {_comment.CommenterName}: {_comment.Text}");
        }
        Console.WriteLine();
    }
}
