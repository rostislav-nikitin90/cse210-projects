namespace Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("91 Charles St W", "Toronto", "Ontario", "Canada");
        addresses[1] = new Address("180 Central Park S", "New York", "New York", "USA");
        addresses[2] = new Address("278 Golden Vale Rd", "Sutton Forest", "New South Wales", "Australia");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("NFC Distinguished Lecture | Early Modern Artificial Intelligence", "Join us for the NFC Distinguished Lecture given by Bill Egginton, Decker Professor of Humanities at Johns Hopkins University", "09/26/2024", "04:00pm", addresses[0], "Bill Egginton", "1000 Attendees");
        events[1] = new ReceptionEvent("The Catholic Renewal Saint Francis Reception", "Please join Catholic Renewal for the Saint Francis Reception benefitting Catholic Charities' Emergency Food Programs", "09/12/2024", "06:00pm", addresses[1], "mary.fitzsimmons@catholiccharitiesny.org");
        events[2] = new OutdoorEvent("Golden Vale Nature Walk","Welcome spring at Golden Vale with a spectacular walking tour and light picnic lunch at this rarely accessed historic homestead", "10/20/2024", "10:00am", addresses[2], "Mostly sunny");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Event N°{i + 1}");
            Console.WriteLine("Standart details:");
            Console.WriteLine(events[i].GetStandardEventDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(events[i].GetFullEventDetails());
            Console.WriteLine("Short Details:");
            Console.WriteLine(events[i].GetShortEventDetails());  
        }
    }
}