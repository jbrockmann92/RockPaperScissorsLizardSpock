using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Need to instantiate two Player objects here. One human and one either human or computer, depending on input.
        //Here is where I will also assign the values to each of the 5 depending on which of the 5 choices the first user inputs
        //Make sure to clear out the values after each round. While loop for the duration of the game. 'if' statements for the firstPlayer choices
        //This is where I want to worry about gestureChoice????

        int playerOneScore;
        int playerTwoScore;

        Player player = new Player();

        public void PlayGame()
        {
            //Need to do both playerOne and playerTwo
            //Assigning values to each of the Gesture variables depending on which choice P1 makes
            Gesture rock = new Gesture(3, 4, 2, 1, 5);
            Gesture paper = new Gesture(2, 3, 4, 1, 5);
            Gesture scissors = new Gesture(2, 4, 3, 5, 1);
            Gesture lizard = new Gesture(4, 2, 5, 3, 1);
            Gesture spock = new Gesture(2, 4, 1, 5, 3);
            
            while (playerTwoScore < 6)
            {

                //gestures.GestureChoice(); - Probably not right, but fix later

            }
        }

    }
}
