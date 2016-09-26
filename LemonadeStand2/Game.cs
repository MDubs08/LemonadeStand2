using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Game
    {
        Player player;
        string PlayerName;
        Day day;
        Store store;
        Recipe recipe;

        public Game()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("What is your name?");
            PlayerName = Console.ReadLine();
            player = new Player();
        }
        public void LemonadeStand()
        {
            for (int i = 0; i < 7; i++)
            {
                day = new Day();
                DayOverview(day);
            }
            Console.WriteLine("Congratulations! You have finished the game.");
            Replay();
        }
        public void Replay()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("\n1  -- Yes \n2 -- No");
            int replayValue = Convert.ToInt32(Console.ReadLine());
            switch (replayValue)
            {
                case 1:
                    LemonadeStand();
                    break;

                case 2:
                    Console.WriteLine("Thank you for Playing!");
                    break;

                default:
                    Console.WriteLine("Invalid Selection.");
                    Replay();
                    break;
            }
        }
        public void DayOverview(Day day)
        {
            Console.WriteLine("The weather for today: \n {0} and {1}", day.weather.temperature, day.weather.weatherType);
        }
    }
}
