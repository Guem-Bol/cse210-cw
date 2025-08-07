// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    public int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }
    
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints, int amountCompleted)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _targetAmount)
        {
            _amountCompleted++;
            Console.WriteLine($"You recorded an event for '{_name}' and earned {_points} points!");
            if (_amountCompleted == _targetAmount)
            {
                Console.WriteLine($"Congratulations! You have completed all steps and earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine($"You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _targetAmount;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonusPoints}|{_targetAmount}|{_amountCompleted}";
    }
}