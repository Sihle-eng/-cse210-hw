using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference();
        Scripture scripture = new Scripture("For ye are the church of the Firstborn, and he will take you up in a cloud, and appoint every man his portion. And he that is a faithful and wise steward shall inherit all things.Amen");

        string read = "";

        while (read != "quit")
        {
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            read = Console.ReadLine();
            scripture.HideRandomWord(4);
        }
    }
}