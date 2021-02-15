using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RunGame
    {
        //int playerOneScore;
        //int playerTwoScore;
        //int playerInput;
        //bool validChoice;

        Player playerOne;
        Player playerTwo;

        public RunGame()
        {
            playerOne = new Human();
        }

        public int playerOneScore = 0;
        public int playerTwoScore = 0;
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
            
            if (userInputPlayerOption == 1)
            {
                Console.WriteLine("Alright! This game is against the CPU.");
                playerTwo = new Computer();
            }
            else if (userInputPlayerOption == 2)
            {
                Console.WriteLine("Great! You'll be playing against another person!");
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Sorry. That's not an available choice. Please choose again!");
                ChooseOpponent();

            }

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
        public void CompareActions()
        {
            //rock 0, paper 1, scissors 2, lizard 3, spock 4

            Console.WriteLine($"{playerOne.playerName} chose {playerOne.playerGesture}.");
            Console.WriteLine($"{playerTwo.playerName} picked {playerTwo.playerGesture}.")
            
            if (playerOne.playerGesture = 0 && playerTwo.playerGesture = 2)
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;

            }
            else if //p1 rock, p2 lizard
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p2 rock, p1 scissors
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p2 rock, p1 lizard
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p1 paper, p2 rock
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p1 paper, p2 spock
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p2 paper, p1 rock
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p2 paper, p1 spock
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p1 scissors, p2 paper
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p1 scissors, p2 lizard
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p2 scissors, p1 paper
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p2 scissors, p1 lizard
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p1 lizard, p2 paper
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p1 lizard, p2 spock
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p2 lizard, p2 paper
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p2 lizard, p2 spock
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p1 spock, p2 rock
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p1 spock, p2 scissors
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if //p2 spock, p1 rock
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if //p2 spock, p1 scissors
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else
            {
                Console.WriteLine("Both of you chose the same action! It's a tie! Try again!");
            }
        }

        public void DisplayWinner(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine($"Congratulations {playerOne.playerName}, you won!");
                Console.WriteLine("The game is over.");
            }
            else
            {
                Console.WriteLine($"Congratulations {playerTwo.playerName}, you won!");
                Console.WriteLine("The game is over.");
            }
        }
        public void PlayRound()
        {
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                CompareActions();
                playerOne.PlayerGesture();
                playerTwo.PlayerGesture();
            }
        }

    }
}
