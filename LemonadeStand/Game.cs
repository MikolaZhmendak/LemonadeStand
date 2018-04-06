using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Random rnd = new Random();
        private Player player;
        //  private Weather weather;
        private Store store;
        public Day day;
        private List<Day> totalDaysPlayed;
        private Recipe recipe;



        public Game()
        {
            player = new Player();
            totalDaysPlayed = new List<Day>();
            totalDaysPlayed.Add(new Day(rnd));
            //{
            //    new Day(rnd) { Name = "Moday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Thusday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Wednesday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Thursday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Friday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Saturday", weather = new Weather(rnd) };
            //    new Day(rnd) { Name = "Sunday", weather = new Weather(rnd) };
            //}
            store = new Store();
            day = new Day(rnd);
            recipe = new Recipe();


        }




        public void StartGame()
        {
            UI.DisplayPlayerInstructions(player);
            for (int i = 1; i < 8; i++)
            {
                UI.DiplayWeatherConditions(day,rnd);
                day.GeneratingCustomersBasedOnWeather(rnd);
                UI.DisplayChicesToBuy(store, player);
                UI.DiplayUserIngredients(store, player);
                UI.AskForPlayerRecipe(recipe);

            }




        }
    }

}




