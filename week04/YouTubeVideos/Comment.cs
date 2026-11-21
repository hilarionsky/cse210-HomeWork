using System;
 
public class Comment
{
    private string _CommenterName;
    private string _text;
 
    public Comment(string CommenterName, string text)
    {
        _CommenterName = CommenterName;
        _text = text;
    }
 
    public void Display()
    {
        Console.WriteLine($"- {_CommenterName}: {_text}");
    }
}