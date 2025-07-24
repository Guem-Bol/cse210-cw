// Video.cs
using System;
using System.Collections.Generic; // Required for List<T>

public class Video
{
    // Private fields
    private string _title;
    private string _author;
    private int _lengthInSeconds; // Length of the video in seconds
    private List<Comment> _comments; // Composition: A Video "has-a" list of Comment objects

    // Constructor to initialize a new Video object
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>(); // Initialize the list of comments
    }

    // Public method to add a comment to the video's list
    public void AddComment(string commenterName, string text)
    {
        Comment newComment = new Comment(commenterName, text);
        _comments.Add(newComment);
    }

    // Public method to get the number of comments on the video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Public method to display all details of the video, including its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"\n--- Video Details ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        // Format length nicely (e.g., 125 seconds -> 02:05)
        TimeSpan videoDuration = TimeSpan.FromSeconds(_lengthInSeconds);
        Console.WriteLine($"Length: {videoDuration.Minutes:00}:{videoDuration.Seconds:00}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}"); // Calls another method

        Console.WriteLine("Comments:");
        if (_comments.Count == 0)
        {
            Console.WriteLine("    (No comments yet)");
        }
        else
        {
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment(); // Calls a method from the Comment object
            }
        }
        Console.WriteLine("---------------------\n");
    }
}