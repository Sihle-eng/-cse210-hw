using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2025,08, 12), 20, 3.4),
            new CyclingActivity(new DateTime(2025, 08, 12), 10, 23),
            new SwimmingActivity(new DateTime(2025, 08, 12), 39, 21),

        };

        foreach (Activity  activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}