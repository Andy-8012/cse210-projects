using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // creates a job using the new job class
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //creates a seccond job using the job class
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //calls resume class and creates variable.
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        //adds the jobs to the resume.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //displays the resume.
        myResume.Display();
    }
}