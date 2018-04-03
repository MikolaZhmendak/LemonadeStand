using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public double cups;
        public double lemons;
        public double cupsOfSugar;
        public double iceCubes;

        public Inventory()
        {

        }

        public double Cups
        {
            get { return cups;}
            set { cups = value;}   
        }
        public double Lemons
        {
            get { return lemons;}
            set { lemons = value;}
        }
        public double Ice
        {
            get { return iceCubes;}
            set { iceCubes = value;}

        }
        public double Sugar
        {
            get { return cupsOfSugar;}
            set { cupsOfSugar = value;}
        }
        

        }
    }


