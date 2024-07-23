namespace Foundation4;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double distance, int activityDuration) : base(date, "Running Activity", activityDuration)
    {
        _distance = distance;
    }

    protected override double GetActivityDistance()
    {
        return _distance;
    }

    protected override double GetActivitySpeed()
    {
        return (_distance / GetActivityDurationInMinutes()) * 60.0;
    }

    protected override double GetActivityPace()
    {
        return GetActivityDurationInMinutes() / GetActivityDistance();
    }
}