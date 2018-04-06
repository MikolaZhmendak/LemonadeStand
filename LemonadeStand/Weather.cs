using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        // member var.
        private Random rnd;
        private double temperature;

        private List<string> WeatherConditions = new List<string>();
        public string weatherCondition;





        public Weather(Random rnd)
        {
            this.rnd = rnd;
            WeatherConditions.Add("Sunny");
            WeatherConditions.Add("Rainy");
            WeatherConditions.Add("Windy");
            WeatherConditions.Add("Cloudy");

        }

        public string ObtainWeatherConditions( int rnumber)
        {
           
          //  result = rnd.Next(0, WeatherConditions.Count - 1);
            weatherCondition = WeatherConditions[rnumber];
            return weatherCondition.ToString();
        }
        public double GenerateTemperature()
        {
            temperature = rnd.Next(40, 100);
            return temperature;

        }
    }
}
        