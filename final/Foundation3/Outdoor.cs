
public class Outdoor: Event
{
    private string _weather;
    public Outdoor( string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, "Outdoor Gathering Event")
    {
        _weather = weather;
    }
    public override string CompleteDetails()
    {
        return Details() + $"\nWeather Forcast: {_weather}\n";
    }
}