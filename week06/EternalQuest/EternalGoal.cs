// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded an event for '{_name}' and earned {_points} points!");
    }

    public override bool IsComplete()
    {
        // Eternal goals are never truly complete
        return false;
    }

    public override string GetDetailsString()
    {
        // No completion status, as they are never complete
        return $"[ ] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}