
public abstract class Goal
{
    protected bool _isFinished;
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _type;

    public Goal (string name, string description, int points, bool isFinished)
    {
        _name = name;
        _description = description;
        _isFinished = isFinished;
        _points = points;
    }
    public abstract void DisplayGoals(int Options);
    public abstract void SetIsCompleted();
    public abstract string GetStringRep();

    public bool GetIsComplete()
    {
        return _isFinished;
    }
    public int GetPoints()
    {
        return _points;
    }
    

}