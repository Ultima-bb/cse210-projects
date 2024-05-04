using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
        {List<int> numbers = new List<int>();
        int input = -1;
        while (input != 0)
    {
            Console.Write("Number? (enter 0 to quit)");
            string userResponse = Console.ReadLine();
            input = int.Parse(userResponse);
            if (input != 0)
                {numbers.Add(input);}
    }
    
        int Total = 0;
        foreach (int number in numbers)
            {Total+= number;}

        Console.WriteLine($"The total is {Total}.");
        float average = ((float)Total)/numbers.Count;
        Console.WriteLine($"The average is {average}");
        int Highest = numbers[0];
        foreach (int number in numbers)
            {if (number>Highest)
                {Highest=number;}
}
    Console.WriteLine($"The highest number is {Highest}");
    }
}