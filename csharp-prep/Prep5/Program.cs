using System;

class Program
{
    static void Main(string[] args)
    {   Message();
        string GivenName = PromptUserName();
        int FavoriteNum = PromptUserNumber();
        int FavTimeFav = SquareNumber(FavoriteNum);
        DisplayResult(GivenName,FavTimeFav);
        
    }
    static void Message()
    {Console.WriteLine("Welcome to the program. ");}

    static string PromptUserName()
    {Console.Write("What's your name? ");
    string name = Console.ReadLine();
    return name;}

    static int PromptUserNumber()
    {Console.Write("What's you favorite number? ");
    int number = int.Parse(Console.ReadLine());
    return number;}

    static int SquareNumber (int number)
    {int square = number * number;
    return square;}

    static void DisplayResult(String name, int square)
    {Console.WriteLine($"So you're name is {name}, and your favorite number squared is {square}.");}
}