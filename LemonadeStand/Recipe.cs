using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int sugarsUsed;
        public int lemonsUsed;
        public int iceCubesUsed;
        public double setPricePerCup;


        public int IceUsed
        {
            get { return iceCubesUsed; }
            set { iceCubesUsed = value; }
         
           
        }
        public int SugarUsed
        {
           get { return sugarsUsed; }
           set { sugarsUsed = value; }
        }

        public int LemonsUsed
        {
            get { return lemonsUsed; }
            set { lemonsUsed = value;}
            
            
        }
        public double SetPrice
        {
           get { return setPricePerCup; }
           set { setPricePerCup = value; }
            
        }


        public void AddingIceCubes(Recipe recipe)
    {
            Console.WriteLine(" How many ice cubes do you want to include in you lemonde? ");
            iceCubesUsed = Int32.Parse(Console.ReadLine());
            UI.AskForPlayerRecipe(recipe);
            

    }
        public void AddingLemons(Recipe recipe)
        {
            Console.WriteLine(" How many lemons do you want to include in you lemonade? ");
            lemonsUsed = Int32.Parse(Console.ReadLine());
            UI.AskForPlayerRecipe(recipe);
        }
        public void AddingSugar(Recipe recipe)
        {
            Console.WriteLine(" How much sugar do you want to include in you lemonade? ");
            sugarsUsed = Int32.Parse(Console.ReadLine());
            UI.AskForPlayerRecipe(recipe);
        }
        public void SettingPrice(Recipe recipe)
        {
            Console.WriteLine(" Enter the price per one cup of lemonade (between $0.5 and $4.5)");
            setPricePerCup = Double.Parse(Console.ReadLine());
            UI.AskForPlayerRecipe(recipe);
        }
}
}
