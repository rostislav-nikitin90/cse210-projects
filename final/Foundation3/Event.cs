namespace Foundation3;
public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _eventAddress;
    private string _eventType;

    public Event(string eventTitle, string description, string date, string time, Address eventAddress, string eventType)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _eventAddress = eventAddress;
        _eventType = eventType;
    }

    public string GetStandardEventDetails()
    {
        return $"{_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{_eventAddress.GetEventAddressInfo()}\n";
    }

    public virtual string GetFullEventDetails()
    {
        return "";
    }

    public string GetShortEventDetails()
    {
        return $"Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}\n";
    }
}