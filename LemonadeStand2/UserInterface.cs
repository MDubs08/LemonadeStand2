using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class UserInterface
    {
        Recipe recipe;
        Day day;
        Weather weather;
        Inventory inventory;
        Player player;
        private int result;

        public UserInterface()
        {
            UserInterfaceSelection();
        }
        public void UserInterfaceSelection()
        {
            Console.Clear();
            day = new Day();
            DayOverview();
            do
            {
                Console.WriteLine("\nWelcome to your User Interface!");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("1.  Adjust Lemonade Recipe");
                Console.WriteLine("2.  Check Forecast");
                Console.WriteLine("3.  Check Inventory");
                Console.WriteLine("4.  Go to the Store");
                Console.WriteLine("5.  Start New Day");
                int result = Convert.ToInt32(Console.ReadLine());
                if (result == 1)
                {
                    Console.Write(recipe.recipePitcher);
                }
                else if (result == 2)
                {
                    Console.Write("The temperature for today is {0} degrees and is {1}.", day.weather.temperature, day.weather.weatherType);
                }
                else if (result == 3)
                {
                    Console.WriteLine("Inventory: ");
                    Console.WriteLine("Lemons: {0}", player.inventory.lemon);
                    Console.WriteLine("Ice:    {1}", player.inventory.ice);
                    Console.WriteLine("Sugar:  {2}", player.inventory.sugar);
                    Console.WriteLine("Cups:   {3}", player.inventory.cup);
                    Console.WriteLine("Money:  {4}", player.inventory.money);
                }
                else if (result == 4)
                {
                    Store store = new Store();
                }
                while (result == 5)
                    for (int i = 0; i < 7; i++)
                    {
                        //day = new Day();

                        UserInterfaceSelection();
                    }
                while (result > 5)
                {
                    Console.WriteLine("Invalid Selection");
                    UserInterfaceSelection();
                }
            } while (result < 5);
        }
            public void DayOverview()
        {
            Console.WriteLine("The weather for today: {0} and {1}", day.weather.temperature, day.weather.weatherType);
        }
    }
}