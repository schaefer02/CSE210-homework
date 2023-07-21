 
 public class Swimming :Activity
 {
    private int _laps;

    public Swimming(string date, int laps, int time) : base(date, "Swimming Activity", time)
    {
        _laps = laps;

    }
    protected override double GetDistance()
    {
        return (_laps * 50.0) / 1000;
    }
    protected override double GetSpeed()
    {
        return (GetDistance() / GetTimeinMinutes()) *60.0;
    }
    protected override double GetPace()
    {
        return GetTimeinMinutes() / GetDistance();
    }















 }