using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Need to figure out Human or Computer here, because Game will just have firstPlayer and secondPlayer. secondPlayer will be either human or computer
        //ints or strings? Bool?

        public Player()
        {

        }

        public int ChooseInput()
        {
            Console.WriteLine("Please enter 1-5 for Rock, Paper, Scissors, Lizard, or Spock");
            return int.Parse(Console.ReadLine());
        }

        public int HumanOrComputer()
        {
            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            int oneOrTwoPlayer = int.Parse(Console.ReadLine());
            return oneOrTwoPlayer;
        }

        public abstract void ChooseGesture(int playerInput);
    }
}
