using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Store
    {
        public int _Amount;
        public Store()
        {
            Lemon lemon = new Lemon();
            Ice ice = new Ice();
            Sugar sugar = new Sugar();
            Cup cup = new Cup();
            StoreIntro();
        }
        public void StoreIntro()
        {
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine("\n What would you like to buy today?");
            Console.WriteLine("\n1 Lemons -- $0.15 \n2 Ice -- $0.05 \n3 Sugar -- $0.10 \n4 Cups -- $0.10");
            GetItems();
        }
        public void GetItems()
        {
            
        }
    }
}
