
public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base (title, description, date, time, address, "Lecture" )
    {
        _speaker  = speaker;
        _capacity = capacity;
    }
    public override string CompleteDetails()
    {
        return Details() + $"\n Speaker: {_speaker}\n Capacity: {_capacity}\n";
    }

}