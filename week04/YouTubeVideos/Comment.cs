using System;

public class Comment
{
    public string _nameOfPerson;
    public string _textComment;

    public void DisplayTextComment()
    {
        Console.WriteLine($"Name:{_nameOfPerson} Comment:{_textComment}");
    }

}