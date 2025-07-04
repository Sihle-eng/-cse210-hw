using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List <int> numbers = new List <int> ();
        float total = 0;
        int len;
        float real;
        float average;
        
        do 
        {
            Console.Write("Enter number: ");
            string entered = Console.ReadLine();
            number = int.Parse(entered);
            numbers.Add(number);
            total += number;
            len = numbers.Count;
        }while (number != 0);

        Console.WriteLine($"The sum is {total}");
        real = len - 1;
        average = total / real;
        Console.WriteLine($"The average is {average}");

        int high = numbers[0];
        
        foreach (int num in numbers)
        {
            if (num > high)
            {
                high = num;
            }
        }
        Console.WriteLine($"The max is {high}");
    }
}