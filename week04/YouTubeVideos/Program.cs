using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Welcome to Program 1: YouTube Videos!");

        // --- Video 1 ---
        Video video1 = new Video("C# Programming Basics", "CodeWithMosh", 1200); // 20 minutes
        video1.AddComment("Alice", "Great tutorial, very clear!");
        video1.AddComment("Bob", "Helped me understand constructors better.");
        video1.AddComment("Charlie", "Can you make a video on LINQ next?");

        // --- Video 2 ---
        Video video2 = new Video("Deep Sea Exploration: Mariana Trench", "National Geographic", 2700); // 45 minutes
        video2.AddComment("David", "Absolutely breathtaking footage!");
        video2.AddComment("Eve", "Makes you realize how much we don't know.");
        video2.AddComment("Frank", "What kind of sub do they use for that depth?");
        video2.AddComment("Grace", "Incredible! I learned so much.");

        // --- Video 3 ---
        Video video3 = new Video("Healthy Smoothie Recipes", "FitLife Kitchen", 450); // 7 minutes 30 seconds
        video3.AddComment("Heidi", "These look delicious! Trying the berry blast.");
        video3.AddComment("Ivan", "Any tips for making it less chunky?");

        // Display details for each video
        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }
}