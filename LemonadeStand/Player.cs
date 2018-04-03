using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member var.
        public string playerName;
        public double cash;
        public Inventory inventory;
        public Recipe recipe;

        //Constructor

        public Player()
        {
            cash = 100.00f;
            GetPlayerName();
            recipe = new Recipe();
            inventory = new Inventory();
        }

        public string GetPlayerName()
        {
            Console.WriteLine("Please enter player's name");
            playerName = Console.ReadLine();
            return playerName;
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }




        public void CheckYouWalet()
        {
            if (cash <= 0)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
        //public bool CheckLevelOfIngredients()
        //{
        //    if (inventory.Ice >= recipe.iceCubesUsed && inventory.Sugar >= recipe.sugarsUsed && inventory.Lemons >= recipe.lemonsUsed && inventory.Cups >= 0)
        //        return true;
        //}
        //return false;
       
    }
}






