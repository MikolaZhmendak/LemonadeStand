using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Report
    {
  //      private Recipe recipe;
        private Player player;
        private int cupsSold;
        private int iceUsedToday;
        private int lemonsUsedToday;
        private int sugarUsedToday;
      //  private Random rnd;

          public Report(Player player)
        {
            this.player = player;
        }
      public void  TotalIceUsed(Recipe recipe)
        {
            iceUsedToday = cupsSold * player.recipe.IceUsed;
            player.inventory.Ice = player.inventory.Ice - player.recipe.IceUsed;

        }
        public void TotalLemonsUsed(Recipe recipe)
        {
            lemonsUsedToday = cupsSold * player.recipe.LemonsUsed;
            player.inventory.Lemons = player.inventory.Lemons - player.recipe.LemonsUsed;

        }
        public void TotalSugarUsed(Recipe recipe)
        {
            sugarUsedToday = cupsSold * player.recipe.SugarUsed;
            player.inventory.Sugar = player.inventory.Sugar - player.recipe.SugarUsed;

        }
        //public void CupsSoldToday(Day day)
        //{
        //    for (int i = 1; i < day.customer.Count-1; i++)
        //    {
        //    //    if (player.CheckLevelOfIngredients() == true)
        //        {
        //      //      if ((day.GeneratingCustomerThirstBasedOnTemperature(rnd) == 4 && day.GeneratingCustomerDemandBasedOnPricePerCup() == 3) || (day.GeneratingCustomerThirstBasedOnTemperature(rnd) == 3 && day.GeneratingCustomerDemandBasedOnPricePerCup() == 2) || ( day.GeneratingCustomerThirstBasedOnTemperature(rnd) == 2 && day.GeneratingCustomerDemandBasedOnPricePerCup() == 1))
        //            {
        //                cupsSold += 1;
        //                player.inventory.Cups -= 1;
        //                TotalIceUsed(recipe);
        //                TotalLemonsUsed(recipe);
        //                TotalSugarUsed(recipe);
        //            }
        //            else
        //            {
            //            Console.WriteLine("You have missed sale");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("You need to check you ingredients level");
            //    }
            //}
        }
    }











    

