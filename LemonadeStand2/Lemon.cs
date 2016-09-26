using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Lemon
    {
        public string name = "Lemons";
        public int amountOfLemons;
        double priceOfLemons;
        int amountOfLemonsRecipe;
        public Lemon()
        {
            amountOfLemons = 0;
            priceOfLemons = 0.15;
            amountOfLemonsRecipe = 3;
        }
        public void SetLemonPrice(double newPriceOfLemon)
        {
            priceOfLemons = newPriceOfLemon;
        }
        public void SetAmountOfLemons (int newAmountOfLemons)
        {
            amountOfLemons += newAmountOfLemons;
        }
        public void SetAmountOfLemonsRecipe(int recipeAdjustLemonAmount)
        {
            amountOfLemonsRecipe = recipeAdjustLemonAmount;
        }
        public int GetAmountOfLemonsRecipe ()
        {
            return amountOfLemonsRecipe;
        }
        public int GetAmountOfLemons()
        {
            return amountOfLemons;
        }
        public double GetPriceOfLemon()
        {
            return priceOfLemons;
        }
    }
}
