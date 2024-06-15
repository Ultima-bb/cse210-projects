public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int countdown = _durationInSeconds;

        while (countdown > 0)
        {
            string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(5000);

            ShuffleArray(_questions);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(_questions[i]);
                Thread.Sleep(5000); 
            }

            countdown -= (5 + 3 * 5);
        }
    }

    private void ShuffleArray(string[] array)
    {
        Random random = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int index = random.Next(i + 1);

            string temp = array[index];
            array[index] = array[i];
            array[i] = temp;
        }
    }
}