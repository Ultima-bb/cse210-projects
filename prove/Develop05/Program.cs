using System;
using System.Collections.Generic;
class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _currentScore = 0;

    static void Main(string[] args)
    {
        InitializeGoals();
        DisplayMenu();
    }

    static void InitializeGoals()
    {
        _goals.Add(new DailyGoal("Talked to at least 5 people", 50));
        _goals.Add(new DailyGoal("Read a page of a book", 5));
        _goals.Add(new ChecklistGoal("Go to classes 10 times in a row", 50, 10));
        _goals.Add(new LongTermGoal("Read your scriptures for a month straight.", 100));
    }

    static void DisplayMenu()
    {
        bool _exit = false;
        while (!_exit)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Add New Goal");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int _choice))
            {
                switch (_choice)
                {
                    case 1:
                        DisplayGoals();
                        break;
                    case 2:
                        RecordEvent();
                        break;
                    case 3:
                        AddNewGoal();
                        break;
                    case 4:
                        DisplayScore();
                        break;
                    case 5:
                        _exit = true;
                        break;
                    default:
                        Console.WriteLine("Well. That doesn't seem right.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsCompleted ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {_goals[i].DisplayGoal()} (Goal {i + 1})");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("You completed a Goal?! Which number? ");
        if (int.TryParse(Console.ReadLine(), out int _goalIndex) && _goalIndex >= 1 && _goalIndex <= _goals.Count)
        {
            Goal goal = _goals[_goalIndex - 1];
            goal.CompleteGoal();
            _currentScore += goal.Points;
            Console.WriteLine("Recorded successfully!");
        }
        else
        {
            Console.WriteLine("Come again?");
        }
    }

    static void AddNewGoal()
    {
        Console.WriteLine("Select type of goal to add:");
        Console.WriteLine("1. Daily Goal");
        Console.WriteLine("2. Long Term Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");

        if (int.TryParse(Console.ReadLine(), out int _choice))
        {
            Console.Write("What's your goal? ");
            string _name = Console.ReadLine();
            Console.Write("How many points is it worth? ");
            if (int.TryParse(Console.ReadLine(), out int _points))
            {
                switch (_choice)
                {
                    case 1:
                        _goals.Add(new DailyGoal(_name, _points));
                        break;
                    case 2:
                        _goals.Add(new LongTermGoal(_name, _points));
                        break;
                    case 3:
                        Console.Write("Number of times this goal needs to be completed? ");
                        if (int.TryParse(Console.ReadLine(), out int _requiredTimes))
                        {
                            _goals.Add(new ChecklistGoal(_name, _points, _requiredTimes));
                        }
                        else
                        {
                            Console.WriteLine("That doesn't make sense.");
                        }
                        break;
                    default:
                        Console.WriteLine("That wasn't one of the options...");
                        break;
                }
                Console.WriteLine("Goal added!");
            }
            else
            {
                Console.WriteLine("Goal not added.");
            }
        }
        else
        {
            Console.WriteLine("Goal not added.");
        }
    }

    static void DisplayScore()
    {
        int _completedChecklistGoals = 0;
        int _totalChecklistGoals = 0;

        foreach (var _goal in _goals)
        {
            if (_goal is ChecklistGoal _checklistGoal)
            {
                _totalChecklistGoals++;
                if (_checklistGoal.IsCompleted)
                {
                    _completedChecklistGoals++;
                }
            }
        }

        Console.WriteLine($"Your current score is: {_currentScore}");
        Console.WriteLine($"You've also completed {_completedChecklistGoals} out of {_totalChecklistGoals} checklist goals.");
    }
}