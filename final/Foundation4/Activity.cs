namespace Foundation4;

public class Activity
{
    protected string _date;
    protected int _activityDuration;
    protected string _activityType;

    public Activity(string date, string activityType, int activityDuration)
    {
        _date = date;
        _activityType = activityType;
        _activityDuration = activityDuration;
    }

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_activityDuration} min) - Distance {GetActivityDistance()} km, Speed: {Math.Round(GetActivitySpeed(), 2)} kph, Pace: {Math.Round(GetActivityPace(), 2)} min per km";
    }

    protected virtual double GetActivityDistance()
    {
       return 0;
    }

    protected virtual double GetActivitySpeed()
    {
        return 0;
    }

    protected virtual double GetActivityPace()
    {
        return 0;
    }

    protected int GetActivityDurationInMinutes()
    {
        return _activityDuration;
    }
}