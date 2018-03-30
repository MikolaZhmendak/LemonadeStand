using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member var.
        private Random rnd;
        private double temperature;
        private double demandBasedOnWeather;
        private List<string> WeatherConditions = new List<string>();
        private string weatherCondition;
        private double DemandLevel;
        protected double SunnyDemandFactor = 1.5;
        protected double WindyDemandFactor = 1.2;
        protected double CloudyDemandFactor = 0.8;
        protected double RainyDemandFactor = 0.6;



        public Weather()
        {




        }

        public string ObtainWeatherConditions()
        {
            int result;
            WeatherConditions.Add("Sunny");
            WeatherConditions.Add("Rainy");
            WeatherConditions.Add("Windy");
            WeatherConditions.Add("Cloudy");
            result = rnd.Next(1, WeatherConditions.Count);
            weatherCondition = WeatherConditions[result];
            return weatherCondition;
        }
        public double GenerateTemperature()
        {
            temperature = rnd.Next(55, 100);
            return temperature;

        }
        public void GenerateDemand()
        {
            if (weatherCondition == "Sunny")
            {
                demandBasedOnWeather = temperature * SunnyDemandFactor;
            }
            else if (weatherCondition == "Windy")
            {
                demandBasedOnWeather = temperature * WindyDemandFactor;
            }
            else if (weatherCondition == "Cloudy")
            {
                demandBasedOnWeather = temperature * CloudyDemandFactor;
            }
            else if (weatherCondition == "Rainy")
            {
                demandBasedOnWeather = temperature * RainyDemandFactor;
            }
        }
    }
}

