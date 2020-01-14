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
        int winningNumber;
        Player playerOne;
        Player playerTwo;


        public int HumanOrComputer()
        {
            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            //do a switch statement here to validate
            int oneOrTwoPlayer = int.Parse(Console.ReadLine());
            return oneOrTwoPlayer;
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

        public void RoundsNumber()
        {
            //make odd only
            Console.WriteLine("How many points would you like to play to? You can play up to 7");
            winningNumber = int.Parse(Console.ReadLine());
        }

        //call in the main PlayGame method

        public void PlayGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! Let's go over the rules quickly and We'll get right into it");
            Console.WriteLine("This game is a lot like Rock, Paper, Scissors, but it adds two more choices: Lizard and Spock");
            Console.WriteLine("As usual, Rock beats Scissors, but loses to Paper; Paper beats Rock, but loses to Scissors; ");
            Console.WriteLine("and Scissors beats Paper, but loses to Rock.");
            Console.WriteLine("In this verison, Lizard beats Paper and Spock, but loses to Scissors and Rock,");
            Console.WriteLine("while Spock beats Scissors and Rock, but loses to Paper and Lizard");
            Console.WriteLine("");
            Console.WriteLine("Or, to put it another way:");
            Console.WriteLine("Paper and Spock >> Rock >> Scissors and Lizard");
            Console.WriteLine("Scissors and Lizard >> Paper >> Rock and Spock");
            Console.WriteLine("Rock and Spock >> Scissors >> Paper and Lizard");
            Console.WriteLine("Scissors and Rock >> Lizard >> Paper and Spock");
            Console.WriteLine("Paper and Lizard >> Spock >> Rock and Scissors");
            Console.WriteLine("Everything to the left beats the middle choice, but everything to the right loses to it. Make sense?");
            Console.ReadLine();

            //Need to do both playerOne and playerTwo
            //Assigning values to each of the Gesture variables depending on which choice P1 makes
            //I don't think this will be very clean. We'll see

            //something with the loop is being infinite around here. Need a generic player in which I can run the HumanOrComputer method?
            //Where am I putting the input from HumanOrComputer?

            //OneOrTwoPlayer(HumanOrComputer());

            //Clean up. Clear console after each turn. Print what both users chose before you print who wins the round.

            while (playerOneScore < winningNumber && playerTwoScore < winningNumber)
            {
                string playerOneGesture = playerOne.ChooseGesture();
                Console.Clear();
                string playerTwoGesture = playerTwo.ChooseGesture();
                Console.Clear();
                if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Draw! Try again");
                }
                else if (playerOneGesture == "rock")
                {
                    if (playerTwoGesture == "scissors" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine("Player One wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "paper" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine("Player Two wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"Player One chose rock, and Player Two chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "paper")
                {
                    if (playerTwoGesture == "rock" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine("Player One wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "scissors" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine("Player Two wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"Player One chose paper, and Player Two chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "scissors")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine("Player One wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "rock" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine("Player Two wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"Player One chose scissors, and Player Two chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "lizard")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine("Player One wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "scissors" || playerTwoGesture == "rock")
                    {
                        Console.WriteLine("Player Two wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"Player One chose lizard, and Player Two chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "spock")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine("Player One wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "rock" || playerTwoGesture == "scissors")
                    {
                        Console.WriteLine("Player Two wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"Player One chose spock, and Player Two chose {playerTwoGesture}");
                }

                Console.WriteLine($"Player One's score is |{playerOneScore}|");
                Console.WriteLine($"Player Two's score is |{playerTwoScore}|");


                //playerOne.ChooseGesture();
                //playerTwo.ChooseGesture();

                ////playerOneChoice = playerOne.ChooseInput();
                ////playerTwoChoice = playerTwo.ChooseInput();

                //if (3 > playerTwo.PlayerTwoGesture)
                //{
                //    playerOneScore++;
                //    Console.WriteLine("Player one scores a point");
                //}
                //else if (playerTwoChoice > 3)
                //{
                //    playerTwoScore++;
                //    Console.WriteLine("Player two scores a point");
                //}
                //else if (playerOneChoice == playerTwoChoice)
                //{
                //    Console.WriteLine("You draw");
                //    //infinite loop here. break is not fixing. Must be using it wrong.
                //}
            }
            if (playerOneScore >= winningNumber)
            {
                Console.WriteLine("Player One wins!");
            }
            else if (playerTwoScore >= winningNumber)
            {
                Console.WriteLine("Player Two wins!");
            }
            Console.ReadLine();
        }

    }
}
