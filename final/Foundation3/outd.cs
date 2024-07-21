public class Outdoor : Event
{
    private string _weatherForcast = "23˚C - Clear Skies";

    public Outdoor()
    {
        SetEventType("Outdoor");
    }

    private string GetWeatherForecast()
    {
        return _weatherForcast;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Weather Forecast : {GetWeatherForecast()}\n");
        DisplayStandardDetails();
    }
}
