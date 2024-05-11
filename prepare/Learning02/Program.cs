using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Newspaper Courrier";
        job1._company = "Niagara Falls Gazette";
        job1._startYear = 2002;
        job1._endYear = 2009;
    
    
        Job job2 = new Job();
        job2._jobTitle = "Production Worker";
        job2._company = "Ford Motor Company";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "Deli Worker";
        job3._company = "Top Friendly Markets";
        job3._startYear = 2023;
        job3._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Benjamin G. Barnes";

        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}