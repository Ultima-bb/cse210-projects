using System;
using System.Xml;

class Program
{
    static void Main(string[]args)
    {
        Journal myJournal = new Journal();
        int Menuchoice = 0;
        while (Menuchoice != 5)
        {
            Console.WriteLine("What would you like to do?\n1.Add an entry \n2.Review old entries\n3.Save Entries?\n4.Load journal entries\n5.Press 5 to quit\n");
            Menuchoice = Int32.Parse(Console.ReadLine());
            if (Menuchoice == 1)
            {
                myJournal.AddEntry();
            }
            else if (Menuchoice ==2)
            {
                myJournal.DisplayEntries();
            }
            else if (Menuchoice == 3)
            {
                myJournal.SaveEntry();
            }
            else if (Menuchoice == 4)
            {
                myJournal.LoadEntries();
            }
            else
            {
                continue;
            } 

        

            
        }
    }

}