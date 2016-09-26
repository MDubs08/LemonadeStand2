using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Sugar
    {
        public string name = "Sugar";
        public int amountOfSugar;
        double priceOfSugar;
        int amountOfSugarRecipe;
        public Sugar()
        {
            amountOfSugar = 0;
            priceOfSugar = 0.10;
            amountOfSugarRecipe = 3;
        }
        public void SetSugarPrice(double newPriceOfSugar)
        {
            priceOfSugar = newPriceOfSugar;
        }
        public void SetAmountOfSugar(int newAmountOfSugar)
        {
            amountOfSugar += newAmountOfSugar;
        }
        public void SetAmountOfSugarRecipe(int newAmountOfSugarRecipe)
        {
            amountOfSugarRecipe = newAmountOfSugarRecipe;
        }
        public int GetAmountOfSugarRecipe()
        {
            return amountOfSugarRecipe;
        }
        public int GetAmountOfSugar()
        {
            return amountOfSugar;
        }
        public double GetPriceOfSugar()
        {
            return priceOfSugar;
        }
    }
}
