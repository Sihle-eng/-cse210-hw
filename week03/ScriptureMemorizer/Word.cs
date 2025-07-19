using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        // var words = _text.Split(' ');
        // Random message = new Random();
        // int index = message.Next(words.Length);
        // _text = string.Join("_", words);
        _isHidden = true;

    }
    public void Show()
    {
        Console.WriteLine(_text);

    }
    public bool IsHidden()
    {

        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length): _text;
    }
}

