using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public Random rnd;

        public Day()
        {
            rnd = new Random();

            Weather weather = new Weather(rnd);
        }

    }

}