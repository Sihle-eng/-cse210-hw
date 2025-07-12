using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal journal = new Journal();

        string response;
        do
        {
            
            Console.WriteLine("Please select one of the following choices:");

            string write = "1";
            string writeWord = "1.Write";
            Console.WriteLine(writeWord);

            string display = "2";
            string displayWord = "2.Display";
            Console.WriteLine(displayWord);

            string load = "3";
            string loadWord = "3.Load";
            Console.WriteLine(loadWord);

            string save = "4";
            string saveWord = "4.Save";
            Console.WriteLine(saveWord);

            string quitWord = "5.Quit";
            Console.WriteLine(quitWord);

            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == write)
            {
                PromptGenerator generator = new PromptGenerator();

                Entry entry = new Entry ();
                entry._date = dateText;
                entry._promptText = generator.GetRandomPrompt();
                entry._entryText = "";
    
                journal._entries.Add(entry);
            
                entry.Display();
            }
            else if (response == display)
            {
                journal.DisplayAll();

            }
            
            else if (response == load)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }
            else if (response == save)
            {
                Console.Write("Enter file name to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (response == "5")
            {
                Console.Write("Thank you goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option entered try again. ");
            }

        }while (response != "5");
    }
}   