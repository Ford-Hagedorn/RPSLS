using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human
    {
        public string playerName;
        public string playerNumber;

        public Human PlayerOne(string playerName,string playerNumber)
        {
            this.playerName = Console.ReadLine();
            this.playerNumber = "Player One";

        }

        public Human PlayerTwo(string playerName, string playerNumber)
        {
            this.playerName = Console.ReadLine();
            this.playerNumber = "Player Two";

        }
    }

}
