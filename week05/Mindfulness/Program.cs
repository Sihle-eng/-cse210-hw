using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu:");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter the duration for the breathing activity in seconds:");
                int duration = int.Parse(Console.ReadLine());
                Breathing breathing = new Breathing(duration);
                breathing.Run();
            }
            else if (choice == "2")
            {
                Console.Write("Enter the duration for the reflection activivty in seconds:");
                int duration = int.Parse(Console.ReadLine());
                Reflecting reflecting = new Reflecting(duration);
                reflecting.Run();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the duration for the listing activity in seconds:");
                int duration = int.Parse(Console.ReadLine());
                Listing listing = new Listing(duration);
                listing.Run();

            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you! Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }




    }
}