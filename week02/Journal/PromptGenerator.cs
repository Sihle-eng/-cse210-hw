using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        string [] _prompts = {"Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",};

        Random message = new Random();
        int index = message.Next(_prompts.Length);

        return (_prompts[index]); 
    }
}