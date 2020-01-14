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

        int playerOneScore = 0;
        int playerTwoScore = 0;
        int playerOneInput;
        int playerTwoInput;
        int playerOneChoice;
        int playerTwoChoice;
        Player playerOne;
        Player playerTwo;


        public int GetNumberPlayers()
        {
            Console.WriteLine("Would you like to play with two players or against a computer?");
            return int.Parse(Console.ReadLine());
        }

        public void OneOrTwoPlayer(int oneOrTwoPlayer)
        {
            if (oneOrTwoPlayer == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (oneOrTwoPlayer == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
        }

        //call in the main PlayGame method

        public void PlayGame()
        {
            //Need to do both playerOne and playerTwo
            //Assigning values to each of the Gesture variables depending on which choice P1 makes
            //I don't think this will be very clean. We'll see

            //something with the loop is being infinite around here. Need a generic player in which I can run the HumanOrComputer method?
            //Where am I putting the input from HumanOrComputer?

            OneOrTwoPlayer(GetNumberPlayers());

            while (playerTwoScore < 4 && playerOneScore < 4)
            {
                playerOne.ChooseGesture(playerOne.ChooseInput());
                playerTwo.ChooseGesture(playerTwo.ChooseInput());
                
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
                else if (playerOneChoice == playerTwoChoice)
                {
                    Console.WriteLine("You tied");
                    //infinite loop here. break is not fixing. Must be using it wrong.
                }
            }
        }

    }
}
