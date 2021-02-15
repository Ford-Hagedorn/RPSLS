using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string playerName;
        public int playerScore;
        public List<Gesture> actions;
        public string playerGesture;

        public Player()
        {

            actions = new List<Gesture>();
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");

            actions.Add(rock);
            actions.Add(paper);
            actions.Add(scissors);
            actions.Add(lizard);
            actions.Add(spock);
        }

        public abstract void PlayerName();
        public abstract void PlayerGesture();


    }
}
