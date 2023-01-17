using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the 1st job for the resume 
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        // Creates the 2nd job for the resume 
        Job Job2 = new Job();
        Job2._company = "Apple";
        Job2._jobTitle = "Manager";
        Job2._startYear = 2022;
        Job2._endYear = 2023;


        // creates the resume
        Resume myResume = new Resume();
        // adds name to resume
        myResume._name = "Kaleb Schauerhamer";
        // adds the jobs above to the job list in resume
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        // displays resume
        myResume.DisplayResume();
    }
}