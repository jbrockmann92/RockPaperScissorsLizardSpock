using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        int playerOneScore = 0;
        int playerTwoScore = 0;
        int winningNumber;
        Player playerOne;
        Player playerTwo;


        public int HumanOrComputer()
        {
            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            int oneOrTwoPlayer = int.Parse(Console.ReadLine());
            return oneOrTwoPlayer;
        }

        public void OneOrTwoPlayer(int oneOrTwoPlayer)
        {
            if (oneOrTwoPlayer == 1)
            {
                playerOne = new Human();
                playerOne.GetName();
                playerTwo = new Computer();
                playerTwo.GetName();
            }
            else if (oneOrTwoPlayer == 2)
            {
                playerOne = new Human();
                playerOne.GetName();
                playerTwo = new Human();
                playerTwo.GetName();
            }
        }

        public void RoundsNumber()
        {
            Console.WriteLine("How many points would you like to play to? You can play up to 7");
            winningNumber = int.Parse(Console.ReadLine());
        }

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

            while (playerOneScore < winningNumber && playerTwoScore < winningNumber)
            {
                string playerOneGesture = playerOne.ChooseGesture("");
                Console.Clear();
                string playerTwoGesture = playerTwo.ChooseGesture("");
                Console.Clear();
                if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Draw! Try again");
                }

                else if (playerOneGesture == "rock")
                {
                    if (playerTwoGesture == "scissors" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine($"{playerOne.name} wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "paper" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine($"{playerTwo.name} wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"{playerOne.name} chose rock, and {playerTwo.name} chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "paper")
                {
                    if (playerTwoGesture == "rock" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine($"{playerOne.name} wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "scissors" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine($"{playerTwo.name} wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"{playerOne.name} chose paper, and {playerTwo.name} chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "scissors")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine($"{playerOne.name} wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "rock" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine($"{playerTwo.name} wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"{playerOne.name} chose scissors, and {playerTwo.name} chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "lizard")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "spock")
                    {
                        Console.WriteLine($"{playerOne.name} wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "scissors" || playerTwoGesture == "rock")
                    {
                        Console.WriteLine($"{playerTwo.name} wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"{playerOne.name} chose lizard, and {playerTwo.name} chose {playerTwoGesture}");
                }
                else if (playerOneGesture == "spock")
                {
                    if (playerTwoGesture == "paper" || playerTwoGesture == "lizard")
                    {
                        Console.WriteLine($"{playerOne.name} wins a point!");
                        playerOneScore++;
                    }
                    else if (playerTwoGesture == "rock" || playerTwoGesture == "scissors")
                    {
                        Console.WriteLine($"{playerTwo.name} wins a point!");
                        playerTwoScore++;
                    }
                    Console.WriteLine($"{playerOne.name} chose spock, and {playerTwo.name} chose {playerTwoGesture}");
                }

                Console.WriteLine($"{playerOne.name}'s score is |{playerOneScore}|");
                Console.WriteLine($"{playerTwo.name}'s score is |{playerTwoScore}|");
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
