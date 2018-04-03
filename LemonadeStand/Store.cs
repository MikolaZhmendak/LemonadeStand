using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public int lemonsToBuy;
        public int iceToBuy;
        public int sugarToBuy;
        public int cups;
              
        public Store()
        {
            lemonsToBuy = 0;
            iceToBuy = 0;
            sugarToBuy = 0;
            cups = 0;
           
        }

        public void SelectionOfLemons(Player player)
        {

            int amount = 0;
            int userInput;

            double totalcost = 0;
            Console.WriteLine("Please tell me how much lemons you want to buy? ");
            Console.WriteLine("Press 1  if you want to buy 10 lemons for .80");
            Console.WriteLine("Press 2  if you want to buy 30 lemons for 1.30");
            Console.WriteLine("Press 3  if you want to buy 50 lemons for 1.65");
            userInput = Int32.Parse(Console.ReadLine());
  

            switch (userInput)
            {
                case 1:
                    amount = 10;
                    totalcost = .80;
                    break;
                case 2:
                    amount = 30;
                    totalcost = 1.30;
                    break;
                case 3:
                    amount = 50;
                    totalcost = 1.65;
                    break;
            }

            lemonsToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("You have " + player.cash + " left in you walet");
        

            //  int howManyLemons = player.inventory.lemons.Count
            // player.inventory.lemons.Add(new Lemons()); // putting one lemon in the inventory
          //  for (int i = 0; i < amount; i++)
          //  {
          //    player.inventory.lemons.Add(new Lemon()); // will add the user amount of lemons inside the player inventory (10,30,50).
          //  }
        }

        public void SelectionOfIce(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("Please tell me how much icecubes you want to buy? ");
            Console.WriteLine("Press 1  if you want to buy 100 icecubes for .50");
            Console.WriteLine("Press 2  if you want to buy 200 icecubes for .90");
            Console.WriteLine("Press 3  if you want to buy 300 icecubes for 1.20");
            int userinput = Int32.Parse(Console.ReadLine());
        

            switch (userinput)
            {
                case 1:
                    amount = 100;
                    totalcost = .50;
                    break;
                case 2:
                    amount = 200;
                    totalcost = .90;
                    break;
                case 3:
                    amount = 300;
                    totalcost = 1.20;
                    break;
            }  
            iceToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("You have " + player.cash + " left in you walet");

            //  int howManyLemons = player.inventory.lemons.Count;
            // player.inventory.lemons.Add(new Lemons()); // putting one lemon in the inventory
         //   for (int i = 0; i < amount; i++)
         //   {
         //    player.inventory.iceCubes.Add(new IceCube()); // will add the user amount of lemons inside the player inventory (10,30,50).
           }

     

        public void SelectionOfSugar(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("Please tell me how much cups sugar  you want to buy? ");
            Console.WriteLine("Press 1  if you want to buy 5 cups of sugar for .60");
            Console.WriteLine("Press 2  if you want to buy 10 cups of sugar for .90");
            Console.WriteLine("Press 3  if you want to buy 15 cubes for 1.20");
            int userinput = Int32.Parse(Console.ReadLine());
        

            switch (userinput)
            {
                case 1:
                    amount = 5;
                    totalcost = .60;
                    break;
                case 2:
                    amount = 10;
                    totalcost = .90;
                    break;
                case 3:
                    amount = 15;
                    totalcost = 1.20;
                    break;
            }
           
            sugarToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("You have " + player.cash + " left in you walet");

            //  int howManyLemons = player.inventory.lemons.Count;
          //  player.inventory.sugarcubes.Add(new Sugar()); // putting one lemon in the inventory
        //    for (int i = 0; i < amount; i++)
         //   {
          //    player.inventory.sugarCubes.Add(new Sugar()); // will add the user amount of lemons inside the player inventory (10,30,50).
           // }
       }

        public void SelectionOfCups(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("Please tell me how much paper cups  you want to buy? ");
            Console.WriteLine("Press 1  if you want to buy 25 cups for .80");
            Console.WriteLine("Press 2  if you want to buy 50 cups for 1.80");
            Console.WriteLine("Press 3  if you want to buy 100 cups for 2.70");
            int userinput = Int32.Parse(Console.ReadLine());
  

            switch (userinput)
            {
                case 1:
                    amount = 25;
                    totalcost = .80;
                    break;
                case 2:
                    amount = 50;
                    totalcost = 1.80;
                    break;
                case 3:
                    amount = 100;
                    totalcost = 2.70;
                    break;
            }
     
            cups = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("You have " + player.cash + " left in you walet");

            //  int howManyLemons = player.inventory.lemons.Count;
            // player.inventory.lemons.Add(new Lemons()); // putting one lemon in the inventory
         //   for (int i = 0; i < amount; i++)
          //  {
         //   player.inventory.cups.Add(new Cup()); // will add the user amount of lemons inside the player inventory (10,30,50).
          //  }
        }
}
}


