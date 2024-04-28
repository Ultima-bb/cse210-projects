using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Are you passing this class? What's your current grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent == 100)
        {grade = "A+";}

        else if (percent >= 93)
        {grade = "A";}

        else if(percent >= 90)
        {grade = "A-";}

        else if(percent >= 86)
        {grade = "B+";}

        else if(percent >= 82)
        {grade = "B";}

        else if(percent >= 80)
        {grade = "B-";}

        else if(percent >= 76)
        {grade = "C+";}

        else if(percent >= 72)
        {grade = "C";}

        else if(percent >= 70)
        {grade = "C-";}

        else if(percent >= 66)
        {grade = "D+";}

        else if(percent >= 62)
        {grade = "D";}

        else if(percent >= 60)
        {grade = "D-";}

        else
        {grade = "F";}

        Console.WriteLine($"So your grade is a {grade} ");

        if (percent >= 70)
        {Console.WriteLine("That works. You'll pass no problem.");}

        else
        {Console.WriteLine("Wow. Um... You're gonna have to retake the class buddy.");}



    }
}