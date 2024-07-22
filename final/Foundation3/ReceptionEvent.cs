namespace Foundation3;

public class ReceptionEvent : Event
{
    private string _email;
    
    public ReceptionEvent(string eventTitle, string description, string date, string time, Address eventAddress, string email) : base(eventTitle, description, date, time, eventAddress, "Reception")
    {
        _email = email;
    }

    public override string GetFullEventDetails()
    {
        return GetStandardEventDetails() + $"Email: {_email}\n";
    }
}