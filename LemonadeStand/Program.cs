using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Day day = new Day(rnd);
            day.GeneratingCustomersBasedOnWeather(rnd);
            Console.ReadLine();
        //    game.StartGame();
            Console.ReadLine();
        }
    }
}
