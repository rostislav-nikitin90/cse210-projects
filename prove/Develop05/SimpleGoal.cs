using System;

namespace Develop05;

public class SimpleGoal : Goal
{
    private string _type = "Simple Goal:";
    private bool _isComplete;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points)
    {
        _isComplete = isComplete;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public override void GetDetailsString(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetShortName()} ({GetDescription()})");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetShortName()} ({GetDescription()})");
        }
    }

    public override string GetStringRepresentaion()
    {
        return $"{_type}|{GetShortName()}|{GetDescription()}|{GetUserPoints()}|{_isComplete}";
    }

    public override void RecordEvent(List<Goal> _goals)
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetUserPoints()} points!");
    }
}