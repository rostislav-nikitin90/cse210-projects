namespace Foundation3;

public class LectureEvent : Event
{
    private string _speakerName;
    private string _capacity;

    public LectureEvent(string eventTitle, string description, string date, string time, Address eventAddress, string speakerName, string capacity) : base(eventTitle, description, date, time, eventAddress, "Lecture")
    {
        _speakerName = speakerName;
        _capacity =  capacity;
    }
    public override string GetFullEventDetails()
    {
        return GetStandardEventDetails() + $"Speaker: {_speakerName}\nCapacity: {_capacity}\n";
    }
}