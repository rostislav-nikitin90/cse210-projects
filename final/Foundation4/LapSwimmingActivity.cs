namespace Foundation4;

public class LapSwimmingActivity : Activity
{
    private int _numberOfLaps;

    public LapSwimmingActivity(string date, int numberOfLaps, int activityDuration) : base(date, "Lap Swimming Activity", activityDuration)
    {
        _numberOfLaps = numberOfLaps;
    }

    protected override double GetActivityDistance()
    {
        return (_numberOfLaps * 50.0) / 1000;
    }

    protected override double GetActivitySpeed()
    {
        return (GetActivityDistance() / GetActivityDurationInMinutes()) * 60.0;
    }

    protected override double GetActivityPace()
    {
        return GetActivityDurationInMinutes() / GetActivityDistance();
    }
}