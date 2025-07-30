using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assigment = new Assignment("James Bond", "Fuctions");
        // Console.WriteLine(assigment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("James Bond", "Functions", "Section 5.3", "1,2,3");
        // Console.WriteLine(mathAssignment.GetSummary());
        // Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("James Bond", "Fuctions", "The Fuctions of C#");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
} 