using System;

namespace Develop05;

public abstract class Goal
{
    private string _type;
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetGoalType()
    {
        return _type;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetUserPoints()
    {
        return _points;
    }
    public abstract void GetDetailsString(int i); 

    public abstract string GetStringRepresentaion();

    public abstract void RecordEvent(List<Goal> _goals);
}