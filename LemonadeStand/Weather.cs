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
        private string weatherCondition;





        public Weather(Random rnd)
        {
            this.rnd = rnd;


        }

        public string ObtainWeatherConditions()
        {
            int result;
            WeatherConditions.Add(" Clear and Sunny");
            WeatherConditions.Add("Rainy");
            WeatherConditions.Add("Windy");
            WeatherConditions.Add("Cloudy");
            result = rnd.Next(0, WeatherConditions.Count - 1);
            weatherCondition = WeatherConditions[result];
            return weatherCondition.ToString();
        }
        public double GenerateTemperature()
        {
            temperature = rnd.Next(50, 90);
            return temperature;

        }
    }
}
        