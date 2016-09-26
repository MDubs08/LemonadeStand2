using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Inventory
    {
        public double money;

        public List<Lemon> lemon = new List<Lemon>();
        public List<Ice> ice = new List<Ice>();
        public List<Sugar> sugar = new List<Sugar>();
        public List<Cup> cup = new List<Cup>();
        public Inventory()
        {
            money = 10.00;
        }
    }
}
