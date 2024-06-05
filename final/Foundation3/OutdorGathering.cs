using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "The weather will be " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string GenerateDetailedOutdoorGathering()
    {
        string Fulldetails = "";
        string weatherStatement = GenerateWeatherStatement();
        
        Fulldetails += GenerateStandard() + "\n";
        Fulldetails += "Statement of the Weather: " + weatherStatement;
        return Fulldetails;
    }
    public string GenerateShortOutdoorGathering()
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Event Type: " + eventType + "\n";
        shortOG += GenerateShort();
        return shortOG;
    }
}