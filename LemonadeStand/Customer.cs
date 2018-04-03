using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random rnd = new Random();
        public int amountOfCustomers;
        public Day day;
        
        
    public int GeneratingCustomersBasedOnWeather(Weather weather, Random rnd)
        {
            day = new Day();

            if (day.weather.ObtainWeatherConditions == "Sunny")
            {
                amountOfCustomers = rnd.Next(50, 80);
                customer.Add(new Customer());
            }
            else if (day.weather.ObtainWeatherConditions == "Rainy")
            {
                amountOfCustomers = rnd.Next(20, 30);
                customer.Add(new Customer());
            }
            else if (day.weather.ObtainWeatherConditions == "Windy")
            {
                amountOfCustomers = rnd.Next(30, 50);
                customer.Add(new Customer());
            }

            else if (day.weather.ObtainWeatherConditions == "Cloudy")
            {

                amountOfCustomers = rnd.Next(40, 60);
                customer.Add(new Customer());
            }

         }
      }
}
