using System;

namespace Develop05;

public class EternalGoal : Goal
{
    private string _type = "Eternal Goal:";
    private bool _isComplete;

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void GetDetailsString(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetShortName()} ({GetDescription()})");
    }

    public override string GetStringRepresentaion()
    {
        return $"{_type}|{GetShortName()}|{GetDescription()}|{GetUserPoints()}|{_isComplete}";
    }
    public override void RecordEvent(List<Goal> _goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetUserPoints()} points!");   
    }
}