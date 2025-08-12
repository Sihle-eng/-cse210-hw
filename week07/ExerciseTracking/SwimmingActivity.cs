using System;

public class SwimmingActivity: Activity
{
    private int _lap;

    public SwimmingActivity(DateTime date, int minutes, int lap) : base(date, minutes)
    {
        _lap = lap;
    }
    public override double GetDistance() => (_lap* 50)/ 1000.0;

    public override double GetSpeed() => (GetDistance()/ Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();

    // public override string GetStringSummary()
    // {
    //     return$"Distance: {_distance} Speed: {_speed} Pace: {_pace}";
    // }
}