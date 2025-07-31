using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // foreach (string animation in animationStrings)
        // {
        //     Console.WriteLine(animation);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (startTime < endTime)
        {
            foreach (string animation in animationStrings)
            {
                Console.Write(animation);
                Thread.Sleep(500);
                Console.Write("\b \b");
                startTime = DateTime.Now;
                if (startTime >= endTime)
                {
                    break;
                }
                }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}