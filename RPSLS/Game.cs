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
        int playerOneInput;
        int playerTwoInput;
        int playerOneChoice;
        int playerTwoChoice;
        Player playerOne;
        Player playerTwo;


        public void PlayGame()
        {
            //Need to do both playerOne and playerTwo
            //Assigning values to each of the Gesture variables depending on which choice P1 makes
            //I don't think this will be very clean. We'll see

            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            int oneOrTwoPlayer = int.Parse(Console.ReadLine());

            if (oneOrTwoPlayer == 1)
            {
                playerOne = new Player();
                playerTwo = new Computer();
            }
            else if (oneOrTwoPlayer == 2)
            {
                playerOne = new Player();
                playerTwo = new Computer();
            }

            playerOne.HumanOrComputer();
            //something with the loop is being infinite around here. Need a generic player in which I can run the HumanOrComputer method?
            //Where am I putting the input from HumanOrComputer?

            while (playerTwoScore < 4)
            {
                while (playerOneScore < 4)
                {
                    playerOne.ChooseGesture(1);
                    playerTwo.ChooseGesture(4);

                    if (playerOneChoice > playerTwoChoice)
                    {
                        playerOneScore++;
                        Console.WriteLine("Player one scores a point");

                    }
                    else if (playerTwoChoice > playerOneChoice)
                    {
                        playerTwoScore++;
                        Console.WriteLine("Player two scores a point");
                    }
                    else
                    {
                        Console.WriteLine("You tied");
                        //infinite loop here
                    }
                }
            }
        }

    }
}
