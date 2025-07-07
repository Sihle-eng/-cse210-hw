using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2014;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Amazon";
        job2._startYear = 2017;
        job2._endYear = 2019;

        Resume resume1 = new Resume();
        resume1._name = "Welcome Nobela";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}