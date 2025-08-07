using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    // public GetDetailsString("") : base()
    // {

    // }
    public override string GetStringRepresentation()
    {

        return "";  
    }
}