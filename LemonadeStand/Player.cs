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
        public string PlayerName;
        private float StartingCash;

        //Constructor

        public Player()
        {
            StartingCash = 100.00f;
            GetPlayerName();
        }

        public string GetPlayerName()
        {
           Console.WriteLine("Please enter player's name");
            PlayerName = Console.ReadLine();
            return PlayerName;
      }
        //public string PlayerName
        //{
        //    get
        //    {
        //        return PlayerName;
        //    }
        //    set
        //    {
        //        return PlayerName;
        //    }
        //}




        public void CheckYouWalet()
        {
            if (StartingCash <= 0)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
       

        }
    }







