// ListingActivity.cs
using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();
    private int _itemsCounted = 0;

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5); // Give time to prepare

        Console.WriteLine(); // Add a newline after countdown

        DateTime startTime = DateTime.Now;
        _itemsCounted = 0;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            // We expect the user to type something and press enter
            // This is a simple loop, in a real app you might want a non-blocking input or timer to end
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) // Only count if something was typed
            {
                _itemsCounted++;
            }
        }

        Console.WriteLine($"You listed {_itemsCounted} items!");
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
}