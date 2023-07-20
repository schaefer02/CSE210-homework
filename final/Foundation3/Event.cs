
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title       = title;
        _description = description;
        _date        = date;
        _time        = time;
        _address     = address;
        _type        = type;

    }
    public string Details()
    {
        return $"Title: {_title}\n Description: {_description}\n Date: {_date}\n Time: {_time}\n Address: {_address.ToString()}\n";
    }
    public virtual string CompleteDetails()
    {
        return "";
    }
    public string ShortDetails()
    {
        return $"Type: {_type}\n Title: {_title}\n Date: {_date}";
    }
}