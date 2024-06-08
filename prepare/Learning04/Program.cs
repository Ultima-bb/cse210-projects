using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment D = new Assignment("Carol Winters", "U-substitution");
        Console.WriteLine(D.GetSummary());

        MathAssignment F = new MathAssignment("Mackenzie Fury", "Integrals", "Ch. 18", "P.S.5");
        Console.WriteLine(F.GetSummary());
        Console.WriteLine(F.GetHomeworkList());

        WritingAssignment G = new WritingAssignment("Jonathan Smith", "Petroglyphs", "Origins of Human Language");
        Console.WriteLine(G.GetSummary());
        Console.WriteLine(G.GetWritingInformation());
    }
}