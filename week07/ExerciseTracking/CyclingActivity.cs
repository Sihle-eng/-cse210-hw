using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetSpeed() => _speed;

    public override double GetDistance() => (_speed * Minutes) / 60;

    public override double GetPace() => 60 / _speed;

    // public override string GetStringSummary()
    // {
    //     return $"Distance: {_distance} Speed: {_speed} Pace: {_pace}";
    // }
}