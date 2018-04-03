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
            amountOfCustomers = rnd.Next(40, 90);
            for (int i = 1; i <= amountOfCustomers; i++)
            {
                customer.Add(new Customer());
            }
            weather = new Weather(rnd);
        }

        
    }
}

     

            
