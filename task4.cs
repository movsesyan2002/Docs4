// Task 4: Weather Forecast System
// Task: Create a class WeatherReport with:
// Fields: temperature, humidity, and weatherCondition.
// In Main(), create an array of WeatherReport objects for different cities and display the reports.

class WeatherReport
{   
    private string city;
    private string temperature;
    private string humidity;
    private string weatherCondition;

    public WeatherReport(string city, string temperature, string humidity, string weatherCondition)
    {
        this.city = city;
        this.temperature = temperature;
        this.humidity = humidity;
        this.weatherCondition = weatherCondition;
    } 

    public string City
    {
        get { return city; }
        set { city = value;}
    }
    public string Temperature
    {
        get { return temperature; }
        set { temperature = value; }
    }

    public string Humidity
    {
        get { return humidity; }
        set { humidity = value;}
    }

    public string WeatherCondition
    {
        get { return weatherCondition; }
        set { weatherCondition = value;}
    }

    public void Displayinfo() 
    {
        Console.WriteLine($"In {this.city} temperature {this.temperature} humidity {this.Humidity} wheather condition {this.WeatherCondition}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        WeatherReport moscow = new WeatherReport("Moscow","-15","26°","Cloudly");
        WeatherReport newyork = new WeatherReport("NewYork","-10","24°","Cloudly");
        WeatherReport prague = new WeatherReport("Prague","-6","36°","Rainly");

        moscow.Displayinfo();
        newyork.Displayinfo();
        prague.Displayinfo();
    }
}


