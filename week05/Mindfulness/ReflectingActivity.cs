// ReflectingActivity.cs
using System;
using System.Threading;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you apply this learning to future situations?"
    };

    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have thought about the prompt, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5); // Give time to prepare

        Console.Clear(); // Clear the screen before questions start

        DateTime startTime = DateTime.Now;
        int questionDuration = 10; // Time for each question
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            DisplayQuestion();
            ShowSpinner(questionDuration); // Show spinner while user thinks
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    private void DisplayQuestion()
    {
        int index = _random.Next(0, _questions.Count);
        Console.WriteLine($"> {_questions[index]}");
    }
}