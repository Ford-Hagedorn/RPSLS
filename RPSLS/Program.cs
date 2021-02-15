using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame runGame = new RunGame();
            runGame.WelcomeMessage();
            runGame.ChooseOpponent();
            runGame.DisplayRules();
            runGame.PlayRound();
            runGame.DisplayWinner();
            Console.ReadLine();


        }
    }
}
