using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }

        public override void PlayerName()
        {
            Console.WriteLine("Please enter your name");
            playerName = Console.ReadLine();

        }
        public override void PlayerGesture()
        {
            Console.WriteLine("Please choose an action for your turn");
            playerGesture = Console.ReadLine();
        }

    }

}
