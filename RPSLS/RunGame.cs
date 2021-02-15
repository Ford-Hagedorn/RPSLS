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
            Console.WriteLine($"{playerTwo.playerName} picked {playerTwo.playerGesture}.");



            if (playerOne.playerGesture == playerTwo.playerGesture)
            {
                Console.WriteLine("It's a tie! Try again!");
            }

            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "scissors")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;

            }
            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "lizard")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerTwo.playerGesture == "rock" && playerOne.playerGesture == "scissors")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerTwo.playerGesture == "rock" && playerOne.playerGesture == "lizard")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "rock")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "spock")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerTwo.playerGesture == "paper" && playerOne.playerGesture == "rock")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerTwo.playerGesture == "paper" && playerOne.playerGesture == "spock")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "paper")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "lizard")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerTwo.playerGesture == "scissors" && playerOne.playerGesture == "paper")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerTwo.playerGesture == "scissors" && playerOne.playerGesture == "lizard")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "paper")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "spock")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerTwo.playerGesture == "lizard" && playerOne.playerGesture == "paper")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerTwo.playerGesture == "lizard" && playerOne.playerGesture == "spock")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "rock")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "scissors")
            {
                Console.WriteLine($"{playerOne.playerName} won this round!");
                playerOneScore++;
            }
            else if (playerTwo.playerGesture == "spock" && playerOne.playerGesture == "rock")
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
            else 
            {
                Console.WriteLine($"{playerTwo.playerName} won this round!");
                playerTwoScore++;
            }
           
        }

        public void DisplayWinner()
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
