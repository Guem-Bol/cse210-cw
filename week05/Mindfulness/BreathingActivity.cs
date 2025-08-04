// BreathingActivity.cs
using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Begin breathing...");

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Breath in... ");
            ShowCountdown(4); // Breath in for 4 seconds
            Console.WriteLine();

            Console.Write("Now breath out... ");
            ShowCountdown(6); // Breath out for 6 seconds
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}