using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, squaredNumber);
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program! ");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
            
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        } 
    }
}