using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Cup
    {
        public string name = "Cup";
        public int amountOfCup;
        double priceOfCup;
        int amountOfCupRecipe;
        public Cup()
        {
            amountOfCup = 0;
            priceOfCup = 0.10;
            amountOfCupRecipe = 3;
        }
        public void SetCupPrice(double newPriceOfCup)
        {
            priceOfCup = newPriceOfCup;
        }
        public void SetAmountOfCup(int newAmountOfCup)
        {
            amountOfCup += newAmountOfCup;
        }
        public void SetAmountOfCupRecipe(int newAmountOfCupRecipe)
        {
            amountOfCupRecipe = newAmountOfCupRecipe;
        }
        public int GetAmountOfCupRecipe()
        {
            return amountOfCupRecipe;
        }
        public int GetAmountOfCup()
        {
            return amountOfCup;
        }
        public double GetPriceOfCup()
        {
            return priceOfCup;
        }
    }
}
