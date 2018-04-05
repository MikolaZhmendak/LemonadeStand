using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace UnitTestProject1
{
    [TestClass]
    public class LemonadeStandText
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
    public class LemonadeStandText1
    {
        [TestMethod]
        public void Text_IsMyTemperatureFunctionIsNotNull()
        {


            Random rnd = new Random();
            Weather weather = new Weather(rnd);
            double actualTemperature = weather.GenerateTemperature();

            Assert.IsNotNull(actualTemperature);

        }
    }
}

