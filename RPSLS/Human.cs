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

        //public int playerInput = 0;
        //public List<Gesture> gestures;
        //public Gesture playerOneGesture;
        //public Gesture playerTwoGesture;
        //int whichGesture;
        public string humanGesture;

        public Human()
        {

        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Please enter Rock, Paper, Scissors, Lizard or Spock");
            string playerGesture = Console.ReadLine();
            humanGesture = playerGesture.ToLower();


            //Console.WriteLine("Please enter 1-5 for Rock, Paper, Scissors, Lizard, or Spock");
            //bool validChoice = false;
            //while (!validChoice)
            //{
            //    int playerInput = int.Parse(Console.ReadLine());
            //    switch (playerInput)
            //    {
            //        case 1:
            //            playerOneGesture = new Gesture(3, 4, 2, 1, 5);
            //            validChoice = true;
            //            break;
            //        case 2:
            //            playerOneGesture = new Gesture(2, 3, 4, 5, 1);
            //            validChoice = true;
            //            break;
            //        case 3:
            //            playerOneGesture = new Gesture(2, 4, 3, 5, 1);
            //            validChoice = true;
            //            break;
            //        case 4:
            //            playerOneGesture = new Gesture(4, 2, 5, 3, 1);
            //            validChoice = true;
            //            break;
            //        case 5:
            //            playerOneGesture = new Gesture(2, 4, 1, 5, 3);
            //            validChoice = true;
            //            break;
            //        default:
            //            Console.WriteLine("Please enter 1-5");
            //            break;
            //    }
            //}
            ////reset player input to 0 after everything in this function, because that's how the function will test whether it's
            ////playerOne or playerTwo making their choice
        }
    }
}
