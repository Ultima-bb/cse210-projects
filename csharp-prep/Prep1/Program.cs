using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your name? ");
        string first = Console.ReadLine();

        Console.Write("And your Last name? ");
        string surname = Console.ReadLine();

        Console.Write("What's your middle name? At least give a middle initail. ");
        string middle = Console.ReadLine();

        Console.Write("Any preferred names or titles? ");
        string nickname = Console.ReadLine();

        Console.WriteLine($"So you full name is {first} {middle} {surname}, We'll just stick with {nickname}. ");
    }
}