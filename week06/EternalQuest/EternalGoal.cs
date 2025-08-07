using System;

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return "Etre";
    }
}