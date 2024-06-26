public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds) { }

    protected override void PerformActivity()
    {
        int countdown = _durationInSeconds;
        while (countdown > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); 
            countdown -= 4;

            if (countdown > 0)
            {
                Console.WriteLine("\b \b");
                Thread.Sleep(5000); 
                
            }
        }
    }
}