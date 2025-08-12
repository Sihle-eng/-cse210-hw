using System;

public class RunningActivity: Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int minutes,double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / Minutes);

    public override double GetPace() => Minutes /_distance;

    // public override string GetStringSummary()
    // {
    //     return$"Distance: {_distance} Speed: {_speed} Pace: {_pace}";
    // }
}