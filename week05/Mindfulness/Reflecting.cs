using System;

public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting(int duration) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine("Reflect on the following prompt:");
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
        // ShowCountdown(10);
        Console.WriteLine("You may being your reflection now:");
        ShowCountdown(10);
        // DateTime endTime = DateTime.Now.AddSeconds(3);
        // while (DateTime.Now < endTime)

        Console.WriteLine("Now, consider the following question:");
        Random random1 = new Random();
        int questionIndex = random1.Next(_questions.Count);
        Console.WriteLine($"-{_questions[questionIndex]}");
        ShowCountdown(10);

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }
    public void DisplayPrompts()
    {
        GetRandomPrompt();
    }
    public void DisplayQuestion()
    {
        GetRandomQuestion();
    }

}