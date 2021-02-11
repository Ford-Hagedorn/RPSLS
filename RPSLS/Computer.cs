using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer
    {
        public string playerName;
        public string playerNumber;

        public Computer ComputerPlayer(string playerName, string playerNumber)
        {
            this.playerName = "CPU";
            this.playerNumber = "Player Two";
        }
    }
}
