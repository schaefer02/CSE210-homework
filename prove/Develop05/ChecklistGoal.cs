
public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _xToGetDone;
    private int _xDone;
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int xToGetDone, int xDone, bool isFinished) : base (name, description, points, isFinished)
    {
        _type = 3;
        _bonusPoints = bonusPoints;
        _xToGetDone = xToGetDone;
        _xDone = xDone;
    }
    public override void SetIsCompleted()
    {
        _xDone += 1;
        if (_xToGetDone == _xDone)
        {
            _isFinished = true;
            _points += _bonusPoints;
        }
        Console.WriteLine($"Congrats, You got {_points} points");

    }
    public override string GetStringRep()
    {
        return $"{_type} | {_name} | {_description} | {_points} | {_bonusPoints} | {_xToGetDone}| {_xDone} | {_isFinished}";
    }
    public override void DisplayGoals(int Options)
    {
        if (Options == 0)
        {
            if (GetIsComplete())
            {
                Console.Write(("[X]"));
            }
            else 
            {
                Console.Write("([ ])");

            }
            Console.WriteLine($"{_name} {_description} : Times Accomplished = {_xDone}/{_xToGetDone}");

        }
        else
        {
            Console.WriteLine($"{_name}");

        }
        
    }


}