using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer\nPaper Carrier".Replace("\n", Environment.NewLine);
        job1._company = "Microsoft";
        job1._startYear = 1998;
        job1._endYear = 2002;

        Job job2 = new Job();
        job2._jobTitle = "Solution Engineer";
        job2._company = "Apple";
        job2._startYear = 2002;
        job2._endYear = 2020;

        Resume name1 = new Resume();
        name1._givenName = "Amber Rose";
        name1._familyName = "Smith";

        // job1.DisplayJob();
        // job2.DisplayJob();

        name1._jobs.Add(job1);
        name1._jobs.Add(job2);

        name1.DisplayDetails();


    }
}
