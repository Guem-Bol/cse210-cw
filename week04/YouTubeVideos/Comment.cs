// Comment.cs
using System;

public class Comment
{
    // Private fields (encapsulation)
    private string _commenterName;
    private string _text;

    // Constructor to initialize a new Comment object
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Public method to get the commenter's name
    public string GetCommenterName()
    {
        return _commenterName;
    }

    // Public method to get the comment text
    public string GetCommentText()
    {
        return _text;
    }

    // Optional: A method to display the comment cleanly
    public void DisplayComment()
    {
        Console.WriteLine($"    - {_commenterName}: \"{_text}\"");
    }
}