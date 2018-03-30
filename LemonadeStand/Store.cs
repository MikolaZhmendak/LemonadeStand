using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public string inventoryType;
        public int amount;
        public double totalcost;
        public Store()
        {

        }

        public void LemondsToBuy()
        {
            Console.WriteLine("");
        }
        public void CupsToBuy()
        {
            Console.WriteLine("");
        }
        public void SugarToBuy()
        {
            Console.WriteLine("");
        }
        public void IceToBuy(Player player, Day day)
        {
            int numberOfCubes;
            Console.WriteLine("Please tell me how much ice you want to buy? ");
            Console.WriteLine("Press 1  if you want to buy 25 cubes for .80");
            Console.WriteLine("Press 2  if you want to buy 50 cubes for 1.10");
            Console.WriteLine("Press 3  if you want to buy 75 cubes for 1.45");
            numberOfCubes = Int32.Parse(Console.ReadLine());
            inventoryType = "Ice Cubes";

            switch (inventoryType)
            {
                case "1":
                    amount = 25;
                    totalcost = 25 * .80;
                    break;
                case "2":
                    amount = 50;
                    totalcost = 50 * 1.10;
                    break;
                case "3":
                    amount = 75;
                    totalcost = 75 * 1.45;
                    break;
            }
        }
    }
}

