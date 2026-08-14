using System;

class Program
{
    static void Main(string[] args)
    {   
        DateTime swimmingDate = new DateTime(2026, 8, 10);
        Swimming swimming = new Swimming(swimmingDate, 25, 20);

        DateTime runningDate = new DateTime(2026, 8, 14);
        Running running = new Running(runningDate, 30, 5);

        DateTime cyclingDate = new DateTime(2026, 8, 12);
        Cycling cycling = new Cycling(cyclingDate, 50, 20);

        List<Activity> activities = new List<Activity>();

        activities.Add(swimming);
        activities.Add(running);
        activities.Add(cycling);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
        
    }
}