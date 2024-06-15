using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("It's time to meditate. Which activity would you like to do?");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter your choice: ");

        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter duration in seconds: ");
        int durationInSeconds = int.Parse(Console.ReadLine());

        Activity activity = null;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity("Breathing", "You'll be breathing in and out to help you relax.", durationInSeconds);
                break;
            case 2:
                activity = new ReflectionActivity("Reflection", "You've done things in your life that have value. Let's think about them for a moment.", durationInSeconds);
                break;
            case 3:
                activity = new ListingActivity("Listing", "There are things we don't realize we've done until we've thought them through. For a set amount of time please list as many as you can.", durationInSeconds);
                break;
            default:
                Console.WriteLine("Perhaps some other time.");
                return;
        }

        activity.StartActivity();
        activity.EndActivity();

        Console.WriteLine("Your mind should be more focused and relaxed. (Press any key to exit.)");
        Console.ReadKey();
    }
}