using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Player
    {
        string PlayerName;
        
        public Inventory inventory;
        public UserInterface userInterface;

        public Player()
        {
            PlayerName = "";
            userInterface = new UserInterface();
            inventory = new Inventory();
        }
        public string GetPlayerName()
        {
            return PlayerName;
        }
        public void SetPlayerName(string NewPlayerName)
        {
           NewPlayerName = PlayerName;
        }

    }
}
