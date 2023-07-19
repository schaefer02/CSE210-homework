
public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int point, bool isFinished) : base (name, description, point, isFinished )
    {
        _type = 1;
    }
    public override string GetStringRep()
    {
        return $"{_type}|{_name}| {_description}| {_points} | {_isFinished}";
    }

    public override void DisplayGoals(int Options)
    {
        if ( Options ==0)
        {

            if (GetIsComplete())
            {
                Console.Write("[x]");
            }
            else
            {
                Console.WriteLine("[ ]");

            }
            Console.WriteLine($"{_name} {_description}");
        }
        else
        {
            Console.WriteLine($"{_name}");

        }

    }
    public override void SetIsCompleted()
    {
        _isFinished = true;
        Console.WriteLine($"You have earned {_points} points.");
    }

}