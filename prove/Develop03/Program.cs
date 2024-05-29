using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture verse = new Scripture("Job 23:10", "But he knoweth the way that I take: when he hath tried me, I shall come forth as gold. ");
        verse.Memoryaid();
        Console.WriteLine("All good things to those who endure.");
    }
}
