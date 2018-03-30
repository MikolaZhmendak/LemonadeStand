using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public static class UI
    {
        public static void DisplayPlayerInstructions(Player player)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Welocome to the lemonade stand game "  +player.PlayerName+"!");
            Console.WriteLine("The main object of this is to make as much money as you can selling lemonade");
            Console.WriteLine("You will have $50 in you wallet to begin with");
            Console.WriteLine("You will play this game over seven days or rounds. Before each day you will have a infromation about current weather as well as the forcast for the future weather");
            Console.WriteLine("Before each round you will have a chance to use our inventory place where you can buy ingridients(lemons, ice, cups and sugar");
            Console.WriteLine("At the end of the game you will have a daily report of how you did in the given day.");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
         
        }
        public static void DisplayChicesToBuy(Store store)
        {
            string userchoice;
            Console.WriteLine("Please enter items that you need to buy. (Enter: Ice, Lemons, Cups, Sugar");
            Console.ReadLine().ToUpper();
            userchoice = Console.ReadLine();
        }
            //if (userchoice == "Ice")
            //{
            //    store.IceToBuy();
            //}
            //else if (userchoice == "Lemons")
            //{
            //    store.LemondsToBuy();
            //}
            //else if (userchoice == "Cups")
            //{
            //    store.CupsToBuy();
        //    }
        //    else if (userchoice == "Sugar")
         //   {
         //       store.SugarToBuy();
          //  }
       // }

           public static void DiplayWeatherConditions(Day day)
       {
         Console.WriteLine(" The weather conditions for today are: ");
         Console.WriteLine(" Weather forcast " + day.weather.ObtainWeatherConditions());
         Console.WriteLine(" The temperature is " + day.weather.GenerateTemperature());
         

        }

    }
}
