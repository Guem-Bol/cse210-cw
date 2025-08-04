// Activity.cs

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // In seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3); // Prepare for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3); // Pause for 3 seconds
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3); // Final pause
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinnerFrames[i]);
            Thread.Sleep(200); // Pause for 200 milliseconds
            Console.Write("\b \b"); // Erase the spinner character
            i = (i + 1) % spinnerFrames.Count;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Erase the number
            // If the number has two digits, erase twice
            if (i >= 10) {
                Console.Write("\b \b");
            }
        }
    }

    // Abstract method to be implemented by derived classes
    public abstract void Run();
}