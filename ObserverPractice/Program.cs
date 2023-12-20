using ObserverPractice;

class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        NewsAgency agency1 = new NewsAgency("Alpha news");
        weatherStation.Attach(agency1);
        NewsAgency agency2 = new NewsAgency("Alpha2 news");
        weatherStation.Attach(agency2);
        NewsAgency agency3 = new NewsAgency("Alpha3 news");
        weatherStation.Attach(agency3);
        NewsAgency agency4 = new NewsAgency("Alpha4 news");
        weatherStation.Attach(agency4);


        weatherStation.Temperature = 31.2f;
        weatherStation.Temperature = 28f;
        weatherStation.Temperature = 46.8f;
        weatherStation.Temperature = 30f;

        Console.ReadLine();




    }




}