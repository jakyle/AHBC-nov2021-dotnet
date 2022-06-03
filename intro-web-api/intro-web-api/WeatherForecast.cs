using System;

namespace intro_web_api
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
            Console.WriteLine("hello world!");
        }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
