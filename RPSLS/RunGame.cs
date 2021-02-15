using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RunGame
    {
        int playerOneScore;
        int playerTwoScore;
        int playerInput;
        bool validChoice;
        public RunGame()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");

        }

        public void ChooseOpponent()
        {
            Console.WriteLine("Who will you be playing against?" +
                "Type 1 for a CPU player" +
                "Type 2 for another human player");
            int userInputPlayerOption = Convert.ToInt32(Console.ReadLine());
            return userInputPlayerOption;


        }

        public void DisplayRules()
        {
            Console.WriteLine("The rules of this game are fairly simple." +
                "While they may be more complicated than traditional" +
                "'Rock Paper Scissors', the general idea is the same." +
                "There are 5 options instead of just 3. Each option either wins" +
                "or loses against a different option. Of course, if the options chosen" +
                "match each other, then it's a tie. " +
                "Let's go over each option, shall we?" +
                "'Rock': beats Scissors and Lizard, but is beaten by Paper or Spock." +
                "'Paper': beats Rock and Spock, but loses to Scissors or Lizard." +
                "'Scissors': beats Paper and Lizard, but won't win against Rock or Spock." +
                "'Lizard': beats Spock and Paper, but can't stand up to Rock or Scissors." +
                "'Spock': beats Scissors and Rock, but will lose to Paper or Lizard." +
                "It's a lot to take in at first, but you'll get the hang of it soon!" +
                "Let's get this party started!" +
                "I hope you have fun!");
        }
        public void CompareActions(Player PlayerName, Player PlayerGesture)
        {

            Player PlayerName = 

            Console.WriteLine($"{PlayerName} chose {PlayerGesture}.");
            
            if
            {

            }
            else if
            {

            }
            else
            {
                Console.WriteLine("The players tied! Try again!");
            }
        }

        public void DisplayWinner(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine($"Congratulations {playerOneName}, you won!");
                Console.WriteLine("The game is over.");
            }
            else
            {
                Console.WriteLine($"Congratulations {playerTwoName}, you won!");
                Console.WriteLine("The game is over.");
            }
        }
        public void PlayRound()
        {


        }

    }
}
