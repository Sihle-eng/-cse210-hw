using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        // _amountCompleted++;
        // if (_amountCompleted > _target)
        // {
        //     _amountCompleted = _target;
        // }
        int earnedPoints = _points;
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                earnedPoints += _bonus;
                Console.WriteLine($"You have {earnedPoints}");
            }
            else
            {
                Console.WriteLine($"You have {_points}");
            }
        }

    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        // string status = "";
        // if (_amountCompleted < _target)
        // {
        //     status = $"[ ] {_shortName} | {_description} | {_points} | (------Currently Completed: {_amountCompleted}/{_target})\n";
        // }
        // else if (_amountCompleted == _target)
        // {
        //     status = $"[X] {_shortName} | {_description} | {_points} | (------Completed: {_amountCompleted}/{_target})\n";
        // }
        // return status;
        string status = IsComplete() ? "[X]" : "[ ]";
        string progress = $"{_amountCompleted}/{_target}";
        string label = IsComplete() ? "Completed" : "Currently Completed";

        return $"{status} {_shortName} | {_description} | {_points} | (------{label}: {progress})\n";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName} | {_description} | {_points}| {_amountCompleted} |{_target}|{_bonus}";
    }
    public override int GetPoints()
    {
        int total = _amountCompleted * _points;
        if (_amountCompleted >= _target)
        {
            total += _bonus;
        }
        return total;
    }
}