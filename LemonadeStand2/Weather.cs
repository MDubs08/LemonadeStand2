using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Weather
    {
        public int temperature;
        public string weatherType;
        static int WeatherType;
        static Random weatherRandom = new Random();

        public Weather()
        {
            temperature = weatherRandom.Next(65, 106);
            SetWeatherType();
        }
        public string SetWeatherType()
        {
            WeatherType = weatherRandom.Next(1, 4);
            if (WeatherType == 1)
            {
                weatherType = "Sunny";
            }
            if (WeatherType == 2)
            {
                weatherType = "Cloudy";
            }
            if (WeatherType == 3)
            {
                weatherType = "Humid";
            }
            if (WeatherType == 4)
            {
                weatherType = "Rainy";
            }
            return weatherType;
        }
    }
}
       
