using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Activity _runningActivity = new Running(new DateTime(2024, 11, 3), 30, 3.0);
        Activity _bicycleActivity = new StationaryBicycle(new DateTime(2024, 11, 4), 45, 15.0); 
        Activity _swimmingActivity = new Swimming(new DateTime(2024, 11, 5), 60, 20); 

        _activities.Add(_runningActivity);
        _activities.Add(_bicycleActivity);
        _activities.Add(_swimmingActivity);

        foreach (var _activity in _activities)
        {
            Console.WriteLine(_activity.GetSummary());
        }
    }
}