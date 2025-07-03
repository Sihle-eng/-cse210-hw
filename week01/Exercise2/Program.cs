using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int number = int.Parse(gradePercentage);
        string letter = ""; 
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "E";
        }

        Console.WriteLine(letter);
        if (number >= 70)
        {
            Console.WriteLine("Congragulations you passed");
        }
        else
        {
            Console.WriteLine("Love the effort but I know you can do better!");
        }
    }
}