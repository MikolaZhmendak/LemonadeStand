using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {

        int amountOfCustomers;
        public Weather weather;
        public Random rnd;
        public List<Customer> customer = new List<Customer>();

        public Day(Random rnd)
        {
            this.rnd = rnd;
            weather = new Weather(rnd);
            amountOfCustomers = GeneratingCustomersBasedOnWeather(rnd);
            for (int i = 1; i <= amountOfCustomers; i++)
            {
                customer.Add(new Customer());
            }
        //    weather = new Weather(rnd);
        }
        public int GeneratingCustomersBasedOnWeather(Random rnd)
        {
            //    day = new Day(rnd);
            //  day.weather.ObtainWeatherConditions();
            string checkResult = weather.ObtainWeatherConditions();
            if (checkResult == "Sunny")
            {
                amountOfCustomers = rnd.Next(50, 80);
                //  customer.Add(new Customer());
            }
            else if (checkResult == "Rainy")
            {
                amountOfCustomers = rnd.Next(20, 30);
                //  customer.Add(new Customer());
            }
            else if (checkResult == "Windy")
            {
                amountOfCustomers = rnd.Next(30, 50);
                // customer.Add(new Customer());
            }

            else if (checkResult == "Cloudy")
            {

                amountOfCustomers = rnd.Next(40, 60);
                //  customer.Add(new Customer());
            }
            return amountOfCustomers;
        }
    }


}
            
