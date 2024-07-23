namespace Foundation4;

public class StationaryCyclingActivity : Activity
{
    private double _speed;
    
    public StationaryCyclingActivity(string date, double speed, int activityDuration) : base(date, "Stationary Cycling Activity", activityDuration)
    {
        _speed = speed;
    }

    protected override double GetActivityDistance()
    {
        return (_speed / 60.0) * GetActivityDurationInMinutes();
    }

    protected override double GetActivitySpeed()
    {
        return _speed;
    }

    protected override double GetActivityPace()
    {
        return GetActivityDurationInMinutes() / GetActivityDistance();
    }
}