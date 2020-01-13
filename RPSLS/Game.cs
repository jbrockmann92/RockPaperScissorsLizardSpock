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
        int playerInput;
        Gesture rock;
        Gesture paper;
        Gesture scissors;
        Gesture lizard;
        Gesture spock;


        Player player = new Player();

        public void PlayGame()
        {
            //Need to do both playerOne and playerTwo
            //Assigning values to each of the Gesture variables depending on which choice P1 makes
            //I don't think this will be very clean. We'll see

            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            int oneOrTwoPlayer = int.Parse(Console.ReadLine());

            Console.WriteLine("Press 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, and 4 for Spock");

            if (playerInput == 0)
            {
                rock = new Gesture(3, 4, 2, 1, 5);
            }
            else if (playerInput == 1)
            {
               paper = new Gesture(2, 3, 4, 5, 1);
            }
            else if (playerInput == 2)
            {
                scissors = new Gesture(2, 4, 3, 5, 1);
            }
            else if (playerInput == 3)
            {
                lizard = new Gesture(4, 2, 5, 3, 1);
            }
            else if (playerInput == 3)
            {
                spock = new Gesture(2, 4, 1, 5, 3);
            }
            
            while (playerTwoScore < 6)
            {

                //gestures.GestureChoice(); - Probably not right, but fix later

            }
        }

    }
}
