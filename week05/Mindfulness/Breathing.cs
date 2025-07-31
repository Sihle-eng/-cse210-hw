using System;

public class Breathing : Activity
{
    public Breathing(int duration) : base("Breathing", "This activity will help you relax", duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("Take a deep breath in...");
        ShowCountdown(3);
        Console.WriteLine("Now breathe out...");
        ShowCountdown(3);
        Console.WriteLine("Breathe in again...");
        ShowCountdown(3);
        Console.WriteLine("And breather out...");
        ShowCountdown(3);
        DisplayEndingMessage();
    }
}