using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1, 1000);
        int guess =-1;
        
        while (guess != Number)
        {   Console.Write("And the Magic Number from 1 to 1000 is? ");
            guess = int.Parse(Console.ReadLine());
        
            if (Number > guess)
            {Console.WriteLine("Greater than that." );}

            else if (Number < guess)
            {Console.WriteLine("The Numer's lower than that.");}

            else
            {Console.WriteLine("Well, well. Threading the needle aren't we? You're right, good guess.");}


        }
    }
}