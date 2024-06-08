using System;
using System.Xml;

class Program
{
    static void Main(string[]args)
    {
        Journal _myJournal = new Journal();
        int _menuchoice = 0;
        while (_menuchoice != 5)
        {
            Console.WriteLine("What would you like to do?\n1.Add an entry \n2.Review old entries\n3.Save Entries?\n4.Load journal entries\n5.Press 5 to quit\n");
            _menuchoice = Int32.Parse(Console.ReadLine());
            if (_menuchoice == 1)
            {
                _myJournal.AddEntry();
            }
            else if (_menuchoice ==2)
            {
                _myJournal.DisplayEntries();
            }
            else if (_menuchoice == 3)
            {
                _myJournal.SaveEntry();
            }
            else if (_menuchoice == 4)
            {
                _myJournal.LoadEntries();
            }
            else
            {
                continue;
            } 

        

            
        }
    }

}