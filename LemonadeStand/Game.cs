using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Random random = new Random();
        private Player player;
        private Weather weather;
        private Store store;
        private Day day;
        private List<Day> totalDaysPlayed;
    //    private List<string> WeatherConditions = new List<string>();
    //    private string weatherCondition;

        public Game()
        {
            player = new Player();
            totalDaysPlayed = new List<Day>();
            totalDaysPlayed.Add(new Day());
            store = new Store();
            day = new Day();
        }




      public void StartGame()
        {
            UI.DisplayPlayerInstructions(player);
            UI.DiplayWeatherConditions(day);
            UI.DisplayChicesToBuy(store);           }
     
        }
    }



