using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        int _timesRecorded = 0;
        _timesRecorded++;
        Console.WriteLine(_points);
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetDetailsString()}";
    }
    public override int GetPoints()
    {
        return _points; 
    }
}