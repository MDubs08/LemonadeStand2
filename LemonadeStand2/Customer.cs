using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Customer : Day
    {
        public int temperatureEffect;
        public int weatherEffect;
        public int chanceToBuy;

        public Customer()
        {
            chanceToBuy = temperatureEffect + weatherEffect;
        }
        public void SetTemperatureEffect(Weather temperature)
        {
            for (int i = 0; i > 95; i++)
                temperatureEffect += 10;
            for (int i = 0; i > 85; i++)
                temperatureEffect += 5;
            for (int i = 0; i > 75; i++)
                temperatureEffect -= 5;
            for (int i = 0; i > 65; i++)
                temperatureEffect -= 10;
        }
        public void SetWeatherTypeEffect(Weather weatherType)
        {
            for (int i = 0; i == 1; i++)
                weatherEffect += 5;
            for (int i = 0; i == 2; i++)
                weatherEffect -= 5;
            for (int i = 0; i == 3; i++)
                weatherEffect += 10;
            for (int i = 0; i == 4; i++)
                weatherEffect -= 10;
        }
    }
}
