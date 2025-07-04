using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        int number;
        int guessNumber;
    
        do
        {
            Random randomGenerator = new Random();
            number = randomGenerator.Next(1, 100);
    
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
    
            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == number)
            {
                Console.WriteLine("You guessed it!");
            }
        }while (guessNumber != number);
        
    }
}