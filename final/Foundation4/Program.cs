namespace Foundation4;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new RunningActivity("16 Jul 2024", 8.5, 30));
        activities.Add(new StationaryCyclingActivity("18 Apr 2019", 10.2, 30));
        activities.Add(new LapSwimmingActivity("27 Oct 2023", 60, 30));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nActivity N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}