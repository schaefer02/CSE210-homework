
public class Reception : Event
{
    private string _RSVP;
    public Reception(string title, string description, string date, string time, Address address, string RSVP): base(title, description, date, time, address,"Reception")
    {
        _RSVP = RSVP;
    }
    public override string CompleteDetails()
    {
        return Details() + $"\nRSVP Email:{_RSVP}\n";
    }
}