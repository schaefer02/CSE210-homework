public class EternalGoal : Goal
{
    private int _xDone;
    public EternalGoal(string name, string description, int xDone, int points) : base (name, description, points, false)
    {
        _type = 2;
        _xDone = xDone;
    }
    public override void SetIsCompleted()
    {
        _xDone += 1;
        _isFinished = false;
        Console.WriteLine($"You have earned {_points} points");
    }
    public override void DisplayGoals(int Options)
    {
        if (Options == 0)
        {
            Console.WriteLine($" {_name} {_description} Times done: {_xDone}");
        }
        else
        {
            Console.WriteLine($"{_name}");

        }
    }
    public override string GetStringRep()
    {
        return $"{_type}|{_name} | {_description} | {_xDone}| {_points}";
    }

}