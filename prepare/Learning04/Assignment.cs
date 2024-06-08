public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string _studentName, string _topic)
    {
        _name = _studentName;
        this._topic = _topic;
    }

    public string GetStudentName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _name + " - " + _topic;
    }
}