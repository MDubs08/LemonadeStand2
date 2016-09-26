using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Ice
    {
        public string name = "Ice";
        public int amountOfIce;
        double priceOfIce;
        int amountOfIceRecipe;
        public Ice()
        {
            amountOfIce = 0;
            priceOfIce = 0.10;
            amountOfIceRecipe = 3;
        }
        public void SetIcePrice(double newPriceOfIce)
        {
            priceOfIce = newPriceOfIce;
        }
        public void SetAmountOfIce(int newAmountOfIce)
        {
            amountOfIce += newAmountOfIce;
        }
        public void SetAmountOfIceRecipe(int newAmountOfIceRecipe)
        {
            amountOfIceRecipe = newAmountOfIceRecipe;
        }
        public int GetAmountOfIceRecipe()
        {
            return amountOfIceRecipe;
        }
        public int GetAmountOfIce()
        {
            return amountOfIce;
        }
        public double GetPriceOfIce()
        {
            return priceOfIce;
        }
    }
}
