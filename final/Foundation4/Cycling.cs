
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double speed, int time) : base (date, "Cycling Activity", time)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return (_speed / 60.0) * GetTimeinMinutes();
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override double GetPace()
    {
        return GetTimeinMinutes() / GetDistance();
    }
}