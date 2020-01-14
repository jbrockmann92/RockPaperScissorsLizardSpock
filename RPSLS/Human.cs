using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //Simple enough here. Allow the player to choose. One player will be guaranteed to be Human, and the other will be optional. 
        //Both do the same thing, but the Computer will randomize the same actions that the Human player will get to choose from.
        //I'll want a list of the 5 options in this class that will be assigned values ultimately in the Game class
        //Human and computer will inherit from the Player class

        public int playerInput = 0;
        public List<Gesture> gestures;
        Gesture rock;
        Gesture paper;
        Gesture scissors;
        Gesture lizard;
        Gesture spock;
        int whichGesture;

        public Human()
        {

        }

        public override void ChooseGesture(int playerInput)
        {
            if (playerInput == 0)
            {
                switch (playerInput)
                {
                    case 1:
                        rock = new Gesture(3, 4, 2, 1, 5);
                        break;
                    case 2:
                        paper = new Gesture(2, 3, 4, 5, 1);
                        break;
                    case 3:
                        scissors = new Gesture(2, 4, 3, 5, 1);
                        break;
                    case 4:
                        lizard = new Gesture(4, 2, 5, 3, 1);
                        break;
                    case 5:
                        spock = new Gesture(2, 4, 1, 5, 3);
                        break;
                    default:
                        Console.WriteLine("Please enter 1-5");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter 1-5 for Rock, Paper, Scissors, Lizard, or Spock");
                whichGesture = int.Parse(Console.ReadLine());
            }
            //reset player input to 0 after everything in this function, because that's how the function will test whether it's
            //playerOne or playerTwo making their choice
            playerInput = 0;
        }
    }
}
