public class Activity
{
    protected string _name;
    protected string _description;
    protected int _durationInSeconds;

    public Activity(string name, string description, int durationInSeconds)
    {
        _name = name;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }

    public void StartActivity()
    {
        Start();
        PerformActivity();
    }

    public void EndActivity()
    {
        End();
    }

    protected void Start()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Setting duration to {_durationInSeconds} seconds.");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5); // Show spinner for 5 seconds
    }

    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_name} activity in {_durationInSeconds} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        Console.Write("Loading ");
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|");
            Thread.Sleep(250); // Adjust speed as needed
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }

    protected virtual void PerformActivity()
    {
        // Base class does not implement any specific activity
        // Derived classes will override this method to provide specific behavior
    }
}