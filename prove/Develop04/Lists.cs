public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine($"Please start listing items for {_durationInSeconds} seconds...");
        Thread.Sleep(_durationInSeconds * 1000); // Pause for specified duration
        Console.WriteLine($"You listed {_durationInSeconds / 3} items.");
    }
}
