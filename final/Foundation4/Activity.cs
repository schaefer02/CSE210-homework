
public class Activity
{
    protected string _activityType;
    protected int _time;
    protected string _date;

    public Activity(string date, string activityType, int time )
    {
        _date         = date;
        _activityType = activityType;
        _time         = time;
    }
    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_time}min)> Distance {GetDistance()} km || Speed: {Math.Round(GetSpeed(), 2)} kph || Pace: {Math.Round(GetPace(), 2)} min per km";
    }
    protected virtual double GetDistance()
    {
        return 0;
    }
    protected virtual double GetSpeed()
    {
        return 0;
    }
    protected virtual double GetPace()
    {
        return 0;
    }
    protected int GetTimeinMinutes()
    {
        return _time;
    }


}