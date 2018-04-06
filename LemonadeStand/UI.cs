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
            Console.WriteLine("Welocome to the lemonade stand game " + player.playerName + "!");
            Console.WriteLine("The main object of this is to make as much money as you can selling lemonade");
            Console.WriteLine("You will have $50 in you wallet to begin with");
            Console.WriteLine("You will play this game over seven days or rounds. Before each day you will have a infromation about current weather as well as the forcast for the future weather");
            Console.WriteLine("Before each round you will have a chance to use our inventory place where you can buy ingridients(lemons, ice, cups and sugar");
            Console.WriteLine("At the end of the game you will have a daily report of how you did in the given day.");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

        }
        public static void DisplayChicesToBuy(Store store, Player player)
        {
            string userchoice;
            Console.WriteLine("Please enter items that you need to buy. (Enter: Ice, Lemons, Cups, Sugar). \n When you finished shopping enter 'done' ");
            userchoice = Console.ReadLine().ToLower();

            if (userchoice == "lemons")
            {

                store.SelectionOfLemons(player);
                DiplayUserIngredients(store, player);
            }
            else if (userchoice == "ice")
            {
                store.SelectionOfIce(player);
                DiplayUserIngredients(store, player);

            }
            else if (userchoice == "cups")
            {
                store.SelectionOfCups(player);
                DiplayUserIngredients(store, player);

            }
            else if (userchoice == "sugar")
            {
                store.SelectionOfSugar(player);
                DiplayUserIngredients(store, player);
            }
            else if (userchoice == "r")
            {

            }

        }


        public static void DiplayWeatherConditions(Day day, Random rnd)
        {
            int random = rnd.Next(0, 4);
            Console.WriteLine(" The weather conditions for today are: ");
            Console.WriteLine(" Weather forcast " + day.weather.ObtainWeatherConditions(random));
            Console.WriteLine(" The temperature is " + day.weather.GenerateTemperature());


        }

        public static void DiplayUserIngredients(Store store, Player player)
        {
            Console.WriteLine();
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine(" You have purchased following items:");
            Console.WriteLine(" Paper cups: " + store.cups);
            Console.WriteLine(" Ice cubes: " + store.iceToBuy);
            Console.WriteLine(" Sugar: " + store.sugarToBuy);
            Console.WriteLine(" Lemons: " + store.lemonsToBuy);
            Console.WriteLine("______________________________________________________________________");
            DisplayChicesToBuy(store, player);
        }
        public static void AskForPlayerRecipe(Recipe recipe)
        {
            string userChoice;
            Console.WriteLine();
            Console.WriteLine(" Here is the summary of you recipe ");
            Console.WriteLine(" Price is $" + recipe.setPricePerCup);
            Console.WriteLine(" Number of ice cubes in your lemonade: " + recipe.iceCubesUsed);
            Console.WriteLine(" Number of lemons in your lemonade: " + recipe.lemonsUsed);
            Console.WriteLine(" Number of sugar cubes in your lemonade : " + recipe.sugarsUsed);
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine(" Now since you have entered the ingredients let make a recipe for 1 cup of lemonade");
            Console.WriteLine(" You can enter amount of ingredients now and set you price per cup");
            Console.WriteLine(" Plese enter S(ugar), I(ce), L(emons), P(rice) for you lemonade");
            userChoice = Console.ReadLine().ToUpper();
            switch (userChoice)
            {
                case "I":
                    recipe.AddingIceCubes(recipe);
                    AskForPlayerRecipe(recipe);

                    break;
                case "L":
                    recipe.AddingLemons(recipe);
                    AskForPlayerRecipe(recipe);
                    break;
                case "S":
                    recipe.AddingSugar(recipe);
                    AskForPlayerRecipe(recipe);
                    break;
                case "P":
                    recipe.SettingPrice(recipe);
                    AskForPlayerRecipe(recipe);
                    break;
            }
           

        }
    }
}

