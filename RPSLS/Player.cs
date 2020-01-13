using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //Need to figure out Human or Computer here, because Game will just have firstPlayer and secondPlayer. secondPlayer will be either human or computer
        //ints or strings? Bool?

        public int oneOrTwoPlayer;
        public int playerInput;
        Gesture rock;
        Gesture paper;
        Gesture scissors;
        Gesture lizard;
        Gesture spock;

        public Player()
        {

        }

        public void HumanOrComputer()
        {
            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            oneOrTwoPlayer = int.Parse(Console.ReadLine());
        }

        public virtual void ChooseGesture(int playerInput)
        {
            switch (playerInput)
            {
                case 0:
                    rock = new Gesture(3, 4, 2, 1, 5);
                    break;
                case 1:
                    paper = new Gesture(2, 3, 4, 5, 1);
                    break;
                case 2:
                    scissors = new Gesture(2, 4, 3, 5, 1);
                    break;
                case 3:
                    lizard = new Gesture(4, 2, 5, 3, 1);
                    break;
                default:
                    spock = new Gesture(2, 4, 1, 5, 3);
                    break;
            }
        }
       

    }
}
