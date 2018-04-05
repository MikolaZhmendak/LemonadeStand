using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Game game = new Game();
         
           
            game.StartGame();
            Console.ReadLine();
        }
    }
}
