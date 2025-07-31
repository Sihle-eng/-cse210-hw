using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(int duration) : base("Listing", "his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(4);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
        ShowCountdown(10);
        Console.WriteLine("You may being in your list now:");
        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            _count++;
        }
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            {
                userList.Add(response);
                _count++;
            }
        }
        return userList;
    }
}