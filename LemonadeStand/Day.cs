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
        int thirstFactor;
        double priceFactor;
        public Weather weather;
        public Recipe recipe;
        public Random rnd;
        public List<Customer> customer = new List<Customer>();

        public Day(Random rnd)
        {
            this.rnd = rnd;
            weather = new Weather(rnd);
            recipe = new Recipe();
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
            string checkWeatherResult = weather.ObtainWeatherConditions();
            if (checkWeatherResult == "Sunny")
            {
                amountOfCustomers = rnd.Next(50, 80);
                //  customer.Add(new Customer());
            }
            else if (checkWeatherResult == "Rainy")
            {
                amountOfCustomers = rnd.Next(20, 30);
                //  customer.Add(new Customer());
            }
            else if (checkWeatherResult == "Windy")
            {
                amountOfCustomers = rnd.Next(30, 50);
                // customer.Add(new Customer());
            }

            else if (checkWeatherResult == "Cloudy")
            {

                amountOfCustomers = rnd.Next(40, 60);
                //  customer.Add(new Customer());
            }
            return amountOfCustomers;
        }

           public double GeneratingCustomerThirstBasedOnTemperature(Random rnd)
        {
            double checkTemperature = weather.GenerateTemperature();
            if (checkTemperature >=80 && checkTemperature <= 100 )
            {
                thirstFactor = 4;
            }
            else if (checkTemperature >=60 && checkTemperature <= 80)
            {
                thirstFactor = 3;
            }
            else if (checkTemperature >=40 && checkTemperature <=60)
            {
                thirstFactor = 2;
            }
            return thirstFactor;
        }
        //public double GeneratingCustomerDemandBasedOnPricePerCup()
        //{
        // //   double checkPrice = recipe.SettingPrice();
        //    if ( checkPrice >= 4.5 && checkPrice <= 3.5)
        //    {
        //        priceFactor = 2;
        //    }
        //    else if ( checkPrice >= 2.5 && checkPrice <=3.5)
        //    {
        //        priceFactor = 3;
        //    }
        //    else if (checkPrice >= .5 && checkPrice <= 2.5)
        //    {
        //        priceFactor = 4;
        //    }
        //    return priceFactor;
        //}
    }


}
            
