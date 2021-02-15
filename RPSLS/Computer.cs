using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Random random;
        public Computer()
        {
            random = new Random();
        }
        public override void PlayerGesture()
        {
            int randomNumber = random.Next(0, actions.Count);
            playerGesture = actions[randomNumber].name;
        }

        public override void PlayerName()
        {
            playerName = "COMPUTER154263";
        }
    }
}
