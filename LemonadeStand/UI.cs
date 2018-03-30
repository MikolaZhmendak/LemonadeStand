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
            Console.WriteLine("Welocome to the lemonade stand game"  +player.PlayerName+"!");

        }

    }
}
