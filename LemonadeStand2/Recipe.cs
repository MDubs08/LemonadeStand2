using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Recipe
    {
        public int recipeAmountLemons = 0;
        public int recipeAmountIce = 0;
        public int recipeAmountSugar = 0;
        private int recipeAmountCups = 12;
        public int priceOfLemonade;
        public int recipePitcher;
        public int getRecipe;
        public int[] pitcher;
        
        public Recipe()
        {
            recipeAmountLemons = 4;
            recipeAmountIce = 12;
            recipeAmountSugar = 4;
            recipeAmountCups = recipePitcher;
            pitcher = new int[] { recipeAmountIce, recipeAmountLemons, recipeAmountSugar };
            foreach (int item in pitcher)
            {
                Console.WriteLine("Lemons", pitcher, " ");
            }
        }
        public void SetRecipeAmountLemons(int newRecipeAmountLemons)
        {
            recipeAmountLemons = newRecipeAmountLemons;
        }
        public void SetRecipeAmountIce(int newRecipeAmountIce)
        {
            recipeAmountIce = newRecipeAmountIce;
        }
        public void SetRecipeAmountSugar(int newRecipeAmountSugar)
        {
            recipeAmountSugar = newRecipeAmountSugar;
        }
        public void SetPriceOfLemonade(int newPriceOfLemonade)
        {
            priceOfLemonade = newPriceOfLemonade;
        }
        public void AdjustRecipe()
        {
            Console.WriteLine("What would you like to adjust?");
            Console.WriteLine("\nLemons \nIce \nSugar \nPrice \nExit");
            string ChangeRecipe = Console.ReadLine();
            switch (ChangeRecipe.ToLower())
            {
                case "lemon":
                    Console.WriteLine("Enter amount to change lemons to: ");
                    SetRecipeAmountLemons(Console.Read());
                    break;

                case "ice":
                    Console.WriteLine("Enter amount to change ice to: ");
                    SetRecipeAmountIce(Console.Read());
                    break;

                case "sugar":
                    Console.WriteLine("Enter amount to change sugar to: ");
                    SetRecipeAmountSugar(Console.Read());
                    break;

                case "price":
                    Console.WriteLine("Enter the price you want to chance the price to: ");
                    SetPriceOfLemonade(Console.Read());
                    break;

                case "exit":
                    break;
            }
            
        }
    }
}
