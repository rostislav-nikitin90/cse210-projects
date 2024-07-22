namespace Foundation3;

public class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent(string eventTitle, string description, string date, string time, Address eventAddress, string weatherForecast) : base(eventTitle, description, date, time, eventAddress, "Outdoor Gathering")
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullEventDetails()
    {
        return GetStandardEventDetails() + $"Weather Forecast: {_weatherForecast}\n";
    }
}