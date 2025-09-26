using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    //add a comment
    public void AddComment(string author, string text)
    {
        _comments.Add(new Comment(author, text));
    }

    //get num of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    //display info
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine(new string('-', 40));
    }
}


