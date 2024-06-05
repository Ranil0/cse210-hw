using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandard()
    {
        string standardDetails = "Title: " + _title + "\n";
        standardDetails += "Description: " + _description + "\n";
        standardDetails += _date + " | " + _time + "\n";

        string address = _address.GenerateCompleteAddress();
        standardDetails += address;
        return standardDetails;
    }

    public string GenerateShort()
    {
        string shortDesc = "Title: " + _title + "\n";

        shortDesc += _date + "\n";
        return shortDesc;
    }
}