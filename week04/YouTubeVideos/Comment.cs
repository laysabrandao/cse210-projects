using System;

public class Comment
{
    private string _author;
    private string _text;

    //constructor
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    //metohd to display the comment
    public void Display()
    {
        Console.WriteLine($"{_author}: {_text}");
    }
}








