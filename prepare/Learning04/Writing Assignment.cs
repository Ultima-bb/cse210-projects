public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string _name, string _topic, string _title)
        : base(_name, _topic)
    {
        this._title = _title;
    }

    public string GetWritingInformation()
    {
        string _name = GetStudentName();

        return $"{_title} by {_name}";
    }
}