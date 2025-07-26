using System;
using System.Runtime.ExceptionServices;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comment = new List<Comment>();

    public void DisplayVideos()
    {
        Console.WriteLine($"Title:{_title} Author:{_author} Length of Video:{_length}");
    }
    public string GetList()
    {
        string result = "";
        foreach (Comment comment in _comment)
        {
            result += comment.ToString();
        }
        return result;
    }

}