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
        private List<Day> totalDaysPlayed;


        public Game()
        {
            player = new Player();
            totalDaysPlayed = new List<Day>();
            totalDaysPlayed.Add(new Day());

        }




        public void StartGame()
        {
           UI.DisplayPlayerInstructions(player);
        }
    }
}
Day



