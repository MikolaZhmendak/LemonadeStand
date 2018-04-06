using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace UnitTestProject1
{
    [TestClass]
    public class LemonadeStandTest1
    {
        [TestMethod]
        public void Text_RangeOfMyTemperatureFunction()
        {


            Random rnd = new Random();
            Weather weather = new Weather(rnd);
            double actualTemperature = weather.GenerateTemperature();


            Assert.IsTrue(actualTemperature >= 40 && actualTemperature <= 100);
        }
    }



    [TestClass]
    public class LemonadeStandTest2
    {
        [TestMethod]
        public void Text_IsMyTemperatureFunctionIsNotNull()
        {


            Random rnd = new Random();
            Weather weather = new Weather(rnd);
            double actualTemperature = weather.GenerateTemperature();

            Assert.IsNotNull(actualTemperature);

        }

        [TestClass]
        public class LemonadeStandTest3
        {
            [TestMethod]
            public void SetWeather_Index0_Rainy()
            {
                string excetedValue = "Sunny";
                Random rnd = new Random();
                Weather w = new Weather(rnd);
                w.ObtainWeatherConditions(0);
                string actualValue = w.weatherCondition;                
                Assert.AreEqual(excetedValue, actualValue);
            }
        }
    }
}

    
