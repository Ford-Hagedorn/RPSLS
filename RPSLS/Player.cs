using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string playerName;
        public string playerNumber;

        

        public Player(string playerName, string playerNumber)
        {
            this.playerName = Console.ReadLine();
            this.playerNumber = playerNumber;
            Console.WriteLine("Please enter your name!");
            playerName = Console.ReadLine();
            Console.WriteLine($"Awesome! Welcome to the game {playerName}!" +
                $"you'll be {playerNumber}!");

            

        }



    }
}
